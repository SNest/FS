using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FlyingShapes.Logic;
using FlyingShapes.Models;
using Rectangle = FlyingShapes.Models.Rectangle;

namespace FlyingShapes
{
    public partial class Main : Form
    {
        private readonly ShapeManager shapeManager;
        public Main()
        {
            InitializeComponent();
            shapeManager = new ShapeManager();
            mainTimer.Start();
        }

        #region Add shapes
        private void addRectangleBtn_Click(object sender, EventArgs e)
        {
            var rectngle = new Rectangle();
            AddShape(rectngle);
        }

        private void addTriangleBtn_Click(object sender, EventArgs e)
        {
            var triangle = new Triangle();
            AddShape(triangle);

        }

        private void addCircleBtn_Click(object sender, EventArgs e)
        {
            var circle = new Circle();
            AddShape(circle);
        }
        private void AddShape(Shape shape)
        {
            shapeManager.AddShape(shape);
            mainPicBox.Invalidate();
            var item = new ListViewItem()
            {
                Text = shape.GetType().Name,
                ForeColor = shape.Color
            };
            mainListView.Items.Add(item);
        }
        #endregion

        #region Playback

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            mainPicBox.Invalidate();
            playBtn.Visible = false;
            pauseBtn.Visible = true;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
            ToglePlayButton();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            ToglePlayButton();
        }

        private void fastBackwardBtn_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(-10);
            ToglePlayButton();
        }

        private void backwardBtn_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(-5);
            ToglePlayButton();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(5);
            ToglePlayButton();
        }

        private void fastForwardBtn_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeAllShapesSpeed(10);
            ToglePlayButton();
        }

        #endregion

        private void mainPicBox_Paint(object sender, PaintEventArgs e)
        {
            if (!playBtn.Visible)
            {
                shapeManager.MoveAllShapes(mainPicBox);
            }
            shapeManager.DrawAllShapes(e.Graphics);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            shapeManager.RemoveAllShapes();
            mainListView.Clear();
            mainPicBox.Refresh();
        }

        private void mainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSelectedShape();

            //var selectedIndices = FillSelectedShape();
            //clearBtn.Click += (o, args) =>
            //{
            //    foreach (int index in selectedIndices)
            //    {
            //        shapeManager.ShapeList.Remove(shapeManager.ShapeList[index]);
            //    }
            //};  

            mainPicBox.Invalidate();
        }

        private void mainListView_MouseEnter(object sender, EventArgs e)
        {
            FillSelectedShape();
        }

        private void mainListView_MouseLeave(object sender, EventArgs e)
        {
            shapeManager.ShapeList.ForEach(shape => shape.IsFilled = false);
            mainPicBox.Invalidate();
        }

        private void FillSelectedShape()
        {
            var selectedIndices = mainListView.SelectedIndices;
            foreach (int index in selectedIndices)
            {
                shapeManager.ShapeList.ForEach(shape => shape.IsFilled = false);
                shapeManager.ShapeList[index].IsFilled = true;
            }
            mainPicBox.Invalidate();
        }
      
        private void ToglePlayButton()
        {
            if (playBtn.Visible && !pauseBtn.Visible)
            {
                playBtn.Visible = false;
                pauseBtn.Visible = true;
            }
            else
            {
                playBtn.Visible = true;
                pauseBtn.Visible = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var shapes = shapeManager.ShapeList;
            ShapeSerializer.SerializeToBinary(shapes);
            ShapeSerializer.SerializeToXml(shapes);
            ShapeSerializer.SerializeToJson(shapes);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var shapes = ShapeSerializer.DeserializeFromBinary();
            //var shapes = ShapeSerializer.DeserializeFromXml();
            //var shapes = ShapeSerializer.DeserializeFromJson();

            shapeManager.ShapeList = shapes;
            mainListView.Items.Clear();
            shapes.ForEach(shape =>
            {
                mainListView.Items.Add(new ListViewItem()
                {
                    Text = shape.GetType().Name,
                    ForeColor = shape.Color
                });
            });
            mainPicBox.Invalidate();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            langLabel.Visible = false;
            langListBox.Visible = true;
        }

        private void langListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                var resources = new ComponentResourceManager(GetType());
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
    }
}
