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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.pauseBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.pauseBtn, "pauseBtn");
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
            this.addRectangleBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addRectangleBtn, "addRectangleBtn");
            this.addRectangleBtn.Name = "addRectangleBtn";
            this.addRectangleBtn.UseVisualStyleBackColor = true;
            this.addRectangleBtn.Click += new System.EventHandler(this.addRectangleBtn_Click);
            // 
            // addTriangleBtn
            // 
            this.addTriangleBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addTriangleBtn, "addTriangleBtn");
            this.addTriangleBtn.Name = "addTriangleBtn";
            this.addTriangleBtn.UseVisualStyleBackColor = true;
            this.addTriangleBtn.Click += new System.EventHandler(this.addTriangleBtn_Click);
            // 
            // addCircleBtn
            // 
            this.addCircleBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addCircleBtn, "addCircleBtn");
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
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.playBtn, "playBtn");
            this.playBtn.Name = "playBtn";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.forwardBtn, "forwardBtn");
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backwardBtn
            // 
            this.backwardBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.backwardBtn, "backwardBtn");
            this.backwardBtn.Name = "backwardBtn";
            this.backwardBtn.UseVisualStyleBackColor = true;
            this.backwardBtn.Click += new System.EventHandler(this.backwardBtn_Click);
            // 
            // fastBackwardBtn
            // 
            this.fastBackwardBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.fastBackwardBtn, "fastBackwardBtn");
            this.fastBackwardBtn.Name = "fastBackwardBtn";
            this.fastBackwardBtn.UseVisualStyleBackColor = true;
            this.fastBackwardBtn.Click += new System.EventHandler(this.fastBackwardBtn_Click);
            // 
            // fastForwardBtn
            // 
            this.fastForwardBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.fastForwardBtn, "fastForwardBtn");
            this.fastForwardBtn.Name = "fastForwardBtn";
            this.fastForwardBtn.UseVisualStyleBackColor = true;
            this.fastForwardBtn.Click += new System.EventHandler(this.fastForwardBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.loadBtn, "loadBtn");
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

