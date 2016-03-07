namespace FlyingShapes
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    using FlyingShapes.Logic;
    using FlyingShapes.Models;

    public partial class Main : Form
    {
        private readonly ShapeManager shapeManager;

        public Main()
        {
            InitializeComponent();
            shapeManager = new ShapeManager();
            mainTimer.Start();
        }

        private void AddCircleBtnClick(object sender, EventArgs e)
        {
            var circle = new Circle();
            AddShape(circle);
        }

        private void AddRectangleBtnClick(object sender, EventArgs e)
        {
            var rectangle = new Square();
            AddShape(rectangle);
        }

        private void AddShape<T>(T shape) where T : Shape
        {
            shapeManager.AddShape(shape);
            mainPicBox.Invalidate();

            AddShapeToTreeView(shape);

            mainTreeView.ExpandAll();
        }

        private void AddShapeToTreeView<T>(T shape) where T : Shape
        {
            if (mainTreeView.Nodes.Count == 0)
            {
                mainTreeView.Nodes.Add(new TreeNode(Text = "Shapes"));
                mainTreeView.Nodes[0].Nodes.Add(new TreeNode(Text = "Squares"));
                mainTreeView.Nodes[0].Nodes.Add(new TreeNode(Text = "Triangles"));
                mainTreeView.Nodes[0].Nodes.Add(new TreeNode(Text = "Circles"));
            }

            var node = new TreeNode(Text = shape.GetType().Name)
                           {
                               ForeColor = shape.Color,
                               NodeFont =
                                   new Font("Microsoft Sans Serif", 8, FontStyle.Regular)
                           };

            switch (shape.GetType().Name)
            {
                case "Square":
                    mainTreeView.Nodes[0].Nodes[0].Nodes.Add(node);
                    break;
                case "Triangle":
                    mainTreeView.Nodes[0].Nodes[1].Nodes.Add(node);
                    break;
                case "Circle":
                    mainTreeView.Nodes[0].Nodes[2].Nodes.Add(node);
                    break;
            }

            mainTreeView.ExpandAll();
        }

        private void AddTriangleBtnClick(object sender, EventArgs e)
        {
            var triangle = new Triangle();
            AddShape(triangle);
        }

        private void BackwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(-5);
            ShowPauseButton();
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control control in Controls)
            {
                var resources = new ComponentResourceManager(GetType());
                resources.ApplyResources(control, control.Name, new CultureInfo(lang));
            }
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            var selectedNode = mainTreeView.SelectedNode;
            if (mainTreeView.Nodes.Count != 0)
            {
                if (mainTreeView.Nodes[0].IsSelected)
                {
                    shapeManager.RemoveAllShapes();
                    foreach (var node in mainTreeView.Nodes[0].Nodes.Cast<TreeNode>())
                    {
                        node.Nodes.Clear();
                    }
                }
                else
                {
                    if (mainTreeView.Nodes[0].Nodes.Contains(selectedNode))
                    {
                        var node = mainTreeView.Nodes[0].Nodes.Cast<TreeNode>()
                            .Single(n => n.IsSelected);
                        shapeManager.RemoveShapesByType(node.Text);
                        node.Nodes.Clear();
                    }
                    else
                    {
                        var shape = shapeManager.GetShape(selectedNode.Parent.Text, selectedNode.Index);
                        shapeManager.RemoveShape(shape);
                        mainTreeView.Nodes.Remove(selectedNode);
                    }
                }

                mainPicBox.Refresh();
            }
        }

        private void FastBackwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(-10);
            ShowPauseButton();
        }

        private void FastForwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(10);
            ShowPauseButton();
        }

        private void FillSelectedShape()
        {
            var selectedNode = mainTreeView.SelectedNode;
            if (selectedNode != null)
            {
                var shape = shapeManager.GetShape(selectedNode.Parent.Text, selectedNode.Index);

                shapeManager.ShapeList.ForEach(s => s.IsFilled = false);
                shapeManager.ShapeList.Find(s => s.Equals(shape)).IsFilled = true;
                mainPicBox.Invalidate();
            }
        }

        private void ForwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(5);
            ShowPauseButton();
        }

        private void LangBtnClick(object sender, EventArgs e)
        {
            langLabel.Visible = false;
            langListBox.Visible = true;
        }

        private void LangListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLanguageIndex = langListBox.SelectedIndex;

            switch (selectedLanguageIndex)
            {
                case 0:
                    ChangeLanguage("en");
                    break;
                case 1:
                    ChangeLanguage("ru");
                    break;
                case 2:
                    ChangeLanguage("uk");
                    break;
                default:
                    ChangeLanguage("en");
                    break;
            }

            langLabel.Visible = true;
            langListBox.Visible = false;
        }

        private void LoadBtnClick(object sender, EventArgs e)
        {
            var shapes = ShapeSerializer.DeserializeFromBinary();

            // var shapes = ShapeSerializer.DeserializeFromXml();
            // var shapes = ShapeSerializer.DeserializeFromJson();
            shapeManager.ShapeList = shapes;
            mainTreeView.Nodes.Clear();
            shapes.ForEach(AddShapeToTreeView);
            mainPicBox.Invalidate();
        }

        private void MainListViewMouseEnter(object sender, EventArgs e)
        {
            FillSelectedShape();
        }

        private void MainListViewMouseLeave(object sender, EventArgs e)
        {
            shapeManager.ShapeList.ForEach(shape => shape.IsFilled = false);
            mainPicBox.Invalidate();
        }

        private void MainPicBoxPaint(object sender, PaintEventArgs e)
        {
            if (!playBtn.Visible)
            {
                shapeManager.MoveAllShapes(mainPicBox);
            }

            shapeManager.DrawAllShapes(e.Graphics);
        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            mainPicBox.Invalidate();
            playBtn.Visible = false;
            pauseBtn.Visible = true;
        }

        private void MainTreeViewNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedNode = mainTreeView.SelectedNode;
            if (selectedNode?.Parent.Parent != null)
            {
                FillSelectedShape();
            }
            else
            {
                shapeManager.ShapeList.ForEach(s => s.IsFilled = false);
            }

            mainPicBox.Invalidate();
        }

        private void PauseBtnClick(object sender, EventArgs e)
        {
            mainTimer.Stop();
            ToglePlayButton();
        }

        private void PlayBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            ToglePlayButton();
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            var shapes = shapeManager.ShapeList;
            ShapeSerializer.SerializeToBinary(shapes);
            ShapeSerializer.SerializeToXml(shapes);
            ShapeSerializer.SerializeToJson(shapes);
        }

        private void ShowPauseButton()
        {
            playBtn.Visible = false;
            playLabel.Visible = false;
            pauseBtn.Visible = true;
            pauseLabel.Visible = true;
        }

        private void ShowPlayButton()
        {
            playBtn.Visible = true;
            playLabel.Visible = true;
            pauseBtn.Visible = false;
            pauseLabel.Visible = false;
        }

        private void ToglePlayButton()
        {
            if (playBtn.Visible && !pauseBtn.Visible)
            {
                ShowPauseButton();
            }
            else
            {
                ShowPlayButton();
            }
        }
    }
}