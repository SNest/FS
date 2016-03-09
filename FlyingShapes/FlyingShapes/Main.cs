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

        private readonly TreeNode shapeNode;

        public Main()
        {
            InitializeComponent();
            shapeManager = new ShapeManager();
            mainTimer.Start();

            shapeNode = mainTreeView.Nodes[0];

            mainTreeView.ExpandAll();
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
            shapeManager.AddShape(shape, mainPicBox);
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
                                   new Font(
                                   "Microsoft Sans Serif", 
                                   8, 
                                   FontStyle.Regular)
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
            shapeManager.ChangeShapesSpeed(-5);
            ShowPauseButton();
        }

        private void ChangeLanguage(string lang)
        {
            var resources = new ComponentResourceManager(GetType());
            foreach (Control control in Controls)
            {
                resources.ApplyResources(control, control.Name, new CultureInfo(lang));
            }
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            var selectedNode = mainTreeView.SelectedNode;
            
            if (selectedNode == null || shapeNode.IsSelected)
            {
                shapeManager.RemoveShapes();
                shapeNode.Nodes.Cast<TreeNode>().ToList().ForEach(n => n.Nodes.Clear());
            }
            else if (shapeNode.Nodes.Contains(selectedNode))
            {
                shapeManager.RemoveShapes(selectedNode.Text);
                selectedNode.Nodes.Clear();
            }
            else
            {
                var shape = shapeManager.GetShape(selectedNode.Parent.Text, selectedNode.Index);
                shapeManager.RemoveShape(shape);
                mainTreeView.Nodes.Remove(selectedNode);
            }

            mainPicBox.Refresh();
        }

        private void FastBackwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeShapesSpeed(-10);
            ShowPauseButton();
        }

        private void FastForwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeShapesSpeed(10);
            ShowPauseButton();
        }

        private void ForwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeShapesSpeed(5);
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

        private void MainPicBoxPaint(object sender, PaintEventArgs e)
        {
            if (!playBtn.Visible)
            {
                shapeManager.MoveShapes(mainPicBox);
            }

            shapeManager.DrawShapes(e.Graphics);
        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            mainPicBox.Invalidate();
            playBtn.Visible = false;
            pauseBtn.Visible = true;
        }

        private void MainTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = mainTreeView.SelectedNode;
            shapeManager.UnfillShapes();

            if (shapeNode.IsSelected)
            {
                shapeManager.FillShapes();
            }
            else if (shapeNode.Nodes.Contains(selectedNode))
            {
                shapeManager.FillShapes(selectedNode.Text);
            }
            else
            {
                var shape = shapeManager.GetShape(selectedNode.Parent.Text, selectedNode.Index);
                shapeManager.FillShape(shape);
            }

            mainPicBox.Refresh();
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