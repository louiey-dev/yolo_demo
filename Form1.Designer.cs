namespace Yolo_Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnYoloInit = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnVideoConvert = new Button();
            groupBox2 = new GroupBox();
            rbYoloModelObbDetection = new RadioButton();
            rbYoloModelPoseEstimation = new RadioButton();
            rbYoloModelSegmentation = new RadioButton();
            rbYoloModelObjectDetection = new RadioButton();
            rbYoloModelClassification = new RadioButton();
            groupBox1 = new GroupBox();
            rbYoloVersionV10 = new RadioButton();
            rbYoloVersionV8 = new RadioButton();
            tabPage2 = new TabPage();
            splitContainer4 = new SplitContainer();
            pbSrc = new PictureBox();
            pbDst = new PictureBox();
            splitContainer2 = new SplitContainer();
            richTextBoxLog = new RichTextBox();
            btnLogClear = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSrc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // btnYoloInit
            // 
            btnYoloInit.Location = new Point(408, 24);
            btnYoloInit.Name = "btnYoloInit";
            btnYoloInit.Size = new Size(116, 23);
            btnYoloInit.TabIndex = 0;
            btnYoloInit.Text = "Yolo Convert";
            btnYoloInit.UseVisualStyleBackColor = true;
            btnYoloInit.Click += btnYoloInit_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1057, 629);
            splitContainer1.SplitterDistance = 489;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(1057, 489);
            splitContainer3.SplitterDistance = 150;
            splitContainer3.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1057, 150);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnVideoConvert);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(btnYoloInit);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1049, 122);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Basic";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnVideoConvert
            // 
            btnVideoConvert.Location = new Point(408, 78);
            btnVideoConvert.Name = "btnVideoConvert";
            btnVideoConvert.Size = new Size(116, 23);
            btnVideoConvert.TabIndex = 2;
            btnVideoConvert.Text = "Video Convert";
            btnVideoConvert.UseVisualStyleBackColor = true;
            btnVideoConvert.Click += btnVideoConvert_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbYoloModelObbDetection);
            groupBox2.Controls.Add(rbYoloModelPoseEstimation);
            groupBox2.Controls.Add(rbYoloModelSegmentation);
            groupBox2.Controls.Add(rbYoloModelObjectDetection);
            groupBox2.Controls.Add(rbYoloModelClassification);
            groupBox2.Location = new Point(115, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ModelType";
            // 
            // rbYoloModelObbDetection
            // 
            rbYoloModelObbDetection.AutoSize = true;
            rbYoloModelObbDetection.Location = new Point(6, 72);
            rbYoloModelObbDetection.Name = "rbYoloModelObbDetection";
            rbYoloModelObbDetection.Size = new Size(100, 19);
            rbYoloModelObbDetection.TabIndex = 0;
            rbYoloModelObbDetection.Text = "ObbDetection";
            rbYoloModelObbDetection.UseVisualStyleBackColor = true;
            // 
            // rbYoloModelPoseEstimation
            // 
            rbYoloModelPoseEstimation.AutoSize = true;
            rbYoloModelPoseEstimation.Location = new Point(149, 47);
            rbYoloModelPoseEstimation.Name = "rbYoloModelPoseEstimation";
            rbYoloModelPoseEstimation.Size = new Size(106, 19);
            rbYoloModelPoseEstimation.TabIndex = 0;
            rbYoloModelPoseEstimation.Text = "PoseEstimation";
            rbYoloModelPoseEstimation.UseVisualStyleBackColor = true;
            // 
            // rbYoloModelSegmentation
            // 
            rbYoloModelSegmentation.AutoSize = true;
            rbYoloModelSegmentation.Location = new Point(149, 24);
            rbYoloModelSegmentation.Name = "rbYoloModelSegmentation";
            rbYoloModelSegmentation.Size = new Size(100, 19);
            rbYoloModelSegmentation.TabIndex = 0;
            rbYoloModelSegmentation.Text = "Segmentation";
            rbYoloModelSegmentation.UseVisualStyleBackColor = true;
            // 
            // rbYoloModelObjectDetection
            // 
            rbYoloModelObjectDetection.AutoSize = true;
            rbYoloModelObjectDetection.Location = new Point(6, 47);
            rbYoloModelObjectDetection.Name = "rbYoloModelObjectDetection";
            rbYoloModelObjectDetection.Size = new Size(112, 19);
            rbYoloModelObjectDetection.TabIndex = 0;
            rbYoloModelObjectDetection.Text = "ObjectDetection";
            rbYoloModelObjectDetection.UseVisualStyleBackColor = true;
            // 
            // rbYoloModelClassification
            // 
            rbYoloModelClassification.AutoSize = true;
            rbYoloModelClassification.Checked = true;
            rbYoloModelClassification.Location = new Point(6, 22);
            rbYoloModelClassification.Name = "rbYoloModelClassification";
            rbYoloModelClassification.Size = new Size(95, 19);
            rbYoloModelClassification.TabIndex = 0;
            rbYoloModelClassification.TabStop = true;
            rbYoloModelClassification.Text = "Classification";
            rbYoloModelClassification.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbYoloVersionV10);
            groupBox1.Controls.Add(rbYoloVersionV8);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(96, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yolo Version";
            // 
            // rbYoloVersionV10
            // 
            rbYoloVersionV10.AutoSize = true;
            rbYoloVersionV10.Location = new Point(9, 49);
            rbYoloVersionV10.Name = "rbYoloVersionV10";
            rbYoloVersionV10.Size = new Size(45, 19);
            rbYoloVersionV10.TabIndex = 0;
            rbYoloVersionV10.Text = "v10";
            rbYoloVersionV10.UseVisualStyleBackColor = true;
            rbYoloVersionV10.CheckedChanged += rbYoloVersionV10_CheckedChanged;
            // 
            // rbYoloVersionV8
            // 
            rbYoloVersionV8.AutoSize = true;
            rbYoloVersionV8.Checked = true;
            rbYoloVersionV8.Location = new Point(9, 24);
            rbYoloVersionV8.Name = "rbYoloVersionV8";
            rbYoloVersionV8.Size = new Size(38, 19);
            rbYoloVersionV8.TabIndex = 0;
            rbYoloVersionV8.TabStop = true;
            rbYoloVersionV8.Text = "v8";
            rbYoloVersionV8.UseVisualStyleBackColor = true;
            rbYoloVersionV8.CheckedChanged += rbYoloVersionV8_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1049, 122);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Feature";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(pbSrc);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(pbDst);
            splitContainer4.Size = new Size(1057, 335);
            splitContainer4.SplitterDistance = 528;
            splitContainer4.TabIndex = 0;
            // 
            // pbSrc
            // 
            pbSrc.Dock = DockStyle.Fill;
            pbSrc.Location = new Point(0, 0);
            pbSrc.Name = "pbSrc";
            pbSrc.Size = new Size(528, 335);
            pbSrc.SizeMode = PictureBoxSizeMode.Zoom;
            pbSrc.TabIndex = 0;
            pbSrc.TabStop = false;
            // 
            // pbDst
            // 
            pbDst.Dock = DockStyle.Fill;
            pbDst.Location = new Point(0, 0);
            pbDst.Name = "pbDst";
            pbDst.Size = new Size(525, 335);
            pbDst.SizeMode = PictureBoxSizeMode.Zoom;
            pbDst.TabIndex = 0;
            pbDst.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnLogClear);
            splitContainer2.Panel1.Controls.Add(richTextBoxLog);
            splitContainer2.Size = new Size(1057, 136);
            splitContainer2.SplitterDistance = 660;
            splitContainer2.TabIndex = 0;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Dock = DockStyle.Fill;
            richTextBoxLog.Location = new Point(0, 0);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.Size = new Size(660, 136);
            richTextBoxLog.TabIndex = 0;
            richTextBoxLog.Text = "";
            // 
            // btnLogClear
            // 
            btnLogClear.Location = new Point(582, 110);
            btnLogClear.Name = "btnLogClear";
            btnLogClear.Size = new Size(75, 23);
            btnLogClear.TabIndex = 1;
            btnLogClear.Text = "Clear";
            btnLogClear.UseVisualStyleBackColor = true;
            btnLogClear.Click += btnLogClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 629);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Yolo Demo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSrc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDst).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnYoloInit;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private RichTextBox richTextBoxLog;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private PictureBox pbSrc;
        private PictureBox pbDst;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private RadioButton rbYoloVersionV8;
        private RadioButton rbYoloModelObbDetection;
        private RadioButton rbYoloModelPoseEstimation;
        private RadioButton rbYoloModelSegmentation;
        private RadioButton rbYoloModelObjectDetection;
        private RadioButton rbYoloModelClassification;
        private RadioButton rbYoloVersionV10;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnVideoConvert;
        private Button btnLogClear;
    }
}
