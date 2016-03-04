namespace FlyingShapes
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainPicBox = new System.Windows.Forms.PictureBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.mainListView = new System.Windows.Forms.ListView();
            this.addRectangleBtn = new System.Windows.Forms.Button();
            this.addTriangleBtn = new System.Windows.Forms.Button();
            this.addCircleBtn = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backwardBtn = new System.Windows.Forms.Button();
            this.fastBackwardBtn = new System.Windows.Forms.Button();
            this.fastForwardBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.triangleLabel = new System.Windows.Forms.Label();
            this.circleLabel = new System.Windows.Forms.Label();
            this.fBackwardlabel = new System.Windows.Forms.Label();
            this.backwardLabel = new System.Windows.Forms.Label();
            this.playLabel = new System.Windows.Forms.Label();
            this.forwardLabel = new System.Windows.Forms.Label();
            this.fForwardLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.langListBox = new System.Windows.Forms.ListBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.shapeGroupBox = new System.Windows.Forms.GroupBox();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.playbeckGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPicBox
            // 
            resources.ApplyResources(this.mainPicBox, "mainPicBox");
            this.mainPicBox.Name = "mainPicBox";
            this.mainPicBox.TabStop = false;
            this.mainPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPicBox_Paint);
            // 
            // pauseBtn
            // 
            resources.ApplyResources(this.pauseBtn, "pauseBtn");
            this.pauseBtn.FlatAppearance.BorderSize = 0;
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // mainListView
            // 
            resources.ApplyResources(this.mainListView, "mainListView");
            this.mainListView.BackColor = System.Drawing.SystemColors.Control;
            this.mainListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainListView.FullRowSelect = true;
            this.mainListView.GridLines = true;
            this.mainListView.Name = "mainListView";
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.List;
            this.mainListView.SelectedIndexChanged += new System.EventHandler(this.mainListView_SelectedIndexChanged);
            this.mainListView.MouseEnter += new System.EventHandler(this.mainListView_MouseEnter);
            this.mainListView.MouseLeave += new System.EventHandler(this.mainListView_MouseLeave);
            // 
            // addRectangleBtn
            // 
            resources.ApplyResources(this.addRectangleBtn, "addRectangleBtn");
            this.addRectangleBtn.FlatAppearance.BorderSize = 0;
            this.addRectangleBtn.Name = "addRectangleBtn";
            this.addRectangleBtn.UseVisualStyleBackColor = true;
            this.addRectangleBtn.Click += new System.EventHandler(this.addRectangleBtn_Click);
            // 
            // addTriangleBtn
            // 
            resources.ApplyResources(this.addTriangleBtn, "addTriangleBtn");
            this.addTriangleBtn.FlatAppearance.BorderSize = 0;
            this.addTriangleBtn.Name = "addTriangleBtn";
            this.addTriangleBtn.UseVisualStyleBackColor = true;
            this.addTriangleBtn.Click += new System.EventHandler(this.addTriangleBtn_Click);
            // 
            // addCircleBtn
            // 
            resources.ApplyResources(this.addCircleBtn, "addCircleBtn");
            this.addCircleBtn.FlatAppearance.BorderSize = 0;
            this.addCircleBtn.Name = "addCircleBtn";
            this.addCircleBtn.UseVisualStyleBackColor = true;
            this.addCircleBtn.Click += new System.EventHandler(this.addCircleBtn_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // clearBtn
            // 
            resources.ApplyResources(this.clearBtn, "clearBtn");
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // playBtn
            // 
            resources.ApplyResources(this.playBtn, "playBtn");
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.Name = "playBtn";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // forwardBtn
            // 
            resources.ApplyResources(this.forwardBtn, "forwardBtn");
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backwardBtn
            // 
            resources.ApplyResources(this.backwardBtn, "backwardBtn");
            this.backwardBtn.FlatAppearance.BorderSize = 0;
            this.backwardBtn.Name = "backwardBtn";
            this.backwardBtn.UseVisualStyleBackColor = true;
            this.backwardBtn.Click += new System.EventHandler(this.backwardBtn_Click);
            // 
            // fastBackwardBtn
            // 
            resources.ApplyResources(this.fastBackwardBtn, "fastBackwardBtn");
            this.fastBackwardBtn.FlatAppearance.BorderSize = 0;
            this.fastBackwardBtn.Name = "fastBackwardBtn";
            this.fastBackwardBtn.UseVisualStyleBackColor = true;
            this.fastBackwardBtn.Click += new System.EventHandler(this.fastBackwardBtn_Click);
            // 
            // fastForwardBtn
            // 
            resources.ApplyResources(this.fastForwardBtn, "fastForwardBtn");
            this.fastForwardBtn.FlatAppearance.BorderSize = 0;
            this.fastForwardBtn.Name = "fastForwardBtn";
            this.fastForwardBtn.UseVisualStyleBackColor = true;
            this.fastForwardBtn.Click += new System.EventHandler(this.fastForwardBtn_Click);
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            resources.ApplyResources(this.loadBtn, "loadBtn");
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveLabel
            // 
            resources.ApplyResources(this.saveLabel, "saveLabel");
            this.saveLabel.Name = "saveLabel";
            // 
            // loadLabel
            // 
            resources.ApplyResources(this.loadLabel, "loadLabel");
            this.loadLabel.Name = "loadLabel";
            // 
            // squareLabel
            // 
            resources.ApplyResources(this.squareLabel, "squareLabel");
            this.squareLabel.Name = "squareLabel";
            // 
            // triangleLabel
            // 
            resources.ApplyResources(this.triangleLabel, "triangleLabel");
            this.triangleLabel.Name = "triangleLabel";
            // 
            // circleLabel
            // 
            resources.ApplyResources(this.circleLabel, "circleLabel");
            this.circleLabel.Name = "circleLabel";
            // 
            // fBackwardlabel
            // 
            resources.ApplyResources(this.fBackwardlabel, "fBackwardlabel");
            this.fBackwardlabel.Name = "fBackwardlabel";
            // 
            // backwardLabel
            // 
            resources.ApplyResources(this.backwardLabel, "backwardLabel");
            this.backwardLabel.Name = "backwardLabel";
            // 
            // playLabel
            // 
            resources.ApplyResources(this.playLabel, "playLabel");
            this.playLabel.Name = "playLabel";
            // 
            // forwardLabel
            // 
            resources.ApplyResources(this.forwardLabel, "forwardLabel");
            this.forwardLabel.Name = "forwardLabel";
            // 
            // fForwardLabel
            // 
            resources.ApplyResources(this.fForwardLabel, "fForwardLabel");
            this.fForwardLabel.Name = "fForwardLabel";
            // 
            // pauseLabel
            // 
            resources.ApplyResources(this.pauseLabel, "pauseLabel");
            this.pauseLabel.Name = "pauseLabel";
            // 
            // deleteLabel
            // 
            resources.ApplyResources(this.deleteLabel, "deleteLabel");
            this.deleteLabel.Name = "deleteLabel";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // langListBox
            // 
            resources.ApplyResources(this.langListBox, "langListBox");
            this.langListBox.BackColor = System.Drawing.SystemColors.Control;
            this.langListBox.FormattingEnabled = true;
            this.langListBox.Items.AddRange(new object[] {
            resources.GetString("langListBox.Items"),
            resources.GetString("langListBox.Items1"),
            resources.GetString("langListBox.Items2")});
            this.langListBox.Name = "langListBox";
            this.langListBox.SelectedIndexChanged += new System.EventHandler(this.langListBox_SelectedIndexChanged);
            // 
            // langLabel
            // 
            resources.ApplyResources(this.langLabel, "langLabel");
            this.langLabel.Name = "langLabel";
            // 
            // shapeGroupBox
            // 
            resources.ApplyResources(this.shapeGroupBox, "shapeGroupBox");
            this.shapeGroupBox.Name = "shapeGroupBox";
            this.shapeGroupBox.TabStop = false;
            // 
            // fileGroupBox
            // 
            resources.ApplyResources(this.fileGroupBox, "fileGroupBox");
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.TabStop = false;
            // 
            // playbeckGroupBox
            // 
            resources.ApplyResources(this.playbeckGroupBox, "playbeckGroupBox");
            this.playbeckGroupBox.Name = "playbeckGroupBox";
            this.playbeckGroupBox.TabStop = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.langListBox);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.fForwardLabel);
            this.Controls.Add(this.forwardLabel);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.backwardLabel);
            this.Controls.Add(this.fBackwardlabel);
            this.Controls.Add(this.circleLabel);
            this.Controls.Add(this.triangleLabel);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fastForwardBtn);
            this.Controls.Add(this.fastBackwardBtn);
            this.Controls.Add(this.backwardBtn);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addCircleBtn);
            this.Controls.Add(this.addTriangleBtn);
            this.Controls.Add(this.addRectangleBtn);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.mainPicBox);
            this.Controls.Add(this.shapeGroupBox);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.playbeckGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicBox;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.Button addRectangleBtn;
        private System.Windows.Forms.Button addTriangleBtn;
        private System.Windows.Forms.Button addCircleBtn;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button backwardBtn;
        private System.Windows.Forms.Button fastBackwardBtn;
        private System.Windows.Forms.Button fastForwardBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.Label triangleLabel;
        private System.Windows.Forms.Label circleLabel;
        private System.Windows.Forms.Label fBackwardlabel;
        private System.Windows.Forms.Label backwardLabel;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label forwardLabel;
        private System.Windows.Forms.Label fForwardLabel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox langListBox;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.GroupBox shapeGroupBox;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.GroupBox playbeckGroupBox;
    }
}

