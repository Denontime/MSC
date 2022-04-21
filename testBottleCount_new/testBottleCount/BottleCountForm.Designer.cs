namespace testBottleCount
{
    partial class BottleCountMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSectionPickCount = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.DeviceStatus = new System.Windows.Forms.StatusStrip();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlBoxInfo = new System.Windows.Forms.Panel();
            this.lblLastTotalCount = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblCurrentSectionPickCount = new System.Windows.Forms.Label();
            this.lblQaStatus = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnQA = new System.Windows.Forms.Button();
            this.Released = new System.Windows.Forms.Button();
            this.btnReQA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DeviceStatus.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlBoxInfo.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.lblSectionPickCount);
            this.pnlMain.Controls.Add(this.lblBarcode);
            this.pnlMain.Controls.Add(this.DeviceStatus);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1512, 842);
            this.pnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 642);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(52, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 642);
            this.panel2.TabIndex = 0;
            // 
            // lblSectionPickCount
            // 
            this.lblSectionPickCount.AutoSize = true;
            this.lblSectionPickCount.Location = new System.Drawing.Point(339, 86);
            this.lblSectionPickCount.Name = "lblSectionPickCount";
            this.lblSectionPickCount.Size = new System.Drawing.Size(0, 18);
            this.lblSectionPickCount.TabIndex = 9;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(336, 50);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(0, 18);
            this.lblBarcode.TabIndex = 8;
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DeviceStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.DeviceStatus.Location = new System.Drawing.Point(0, 809);
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.DeviceStatus.Size = new System.Drawing.Size(774, 31);
            this.DeviceStatus.TabIndex = 7;
            this.DeviceStatus.Text = "DeviceStatus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "CurrentSectionPickProduct：";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pnlBoxInfo);
            this.pnlInfo.Controls.Add(this.pnlImage);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(774, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(736, 840);
            this.pnlInfo.TabIndex = 0;
            // 
            // pnlBoxInfo
            // 
            this.pnlBoxInfo.Controls.Add(this.lblLastTotalCount);
            this.pnlBoxInfo.Controls.Add(this.lblTotalCount);
            this.pnlBoxInfo.Controls.Add(this.lblCurrentSectionPickCount);
            this.pnlBoxInfo.Controls.Add(this.lblQaStatus);
            this.pnlBoxInfo.Controls.Add(this.btnTest);
            this.pnlBoxInfo.Controls.Add(this.btnQA);
            this.pnlBoxInfo.Controls.Add(this.Released);
            this.pnlBoxInfo.Controls.Add(this.btnReQA);
            this.pnlBoxInfo.Controls.Add(this.label5);
            this.pnlBoxInfo.Controls.Add(this.label4);
            this.pnlBoxInfo.Controls.Add(this.label3);
            this.pnlBoxInfo.Controls.Add(this.label6);
            this.pnlBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlBoxInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBoxInfo.Name = "pnlBoxInfo";
            this.pnlBoxInfo.Size = new System.Drawing.Size(916, 255);
            this.pnlBoxInfo.TabIndex = 1;
            // 
            // lblLastTotalCount
            // 
            this.lblLastTotalCount.AutoSize = true;
            this.lblLastTotalCount.Location = new System.Drawing.Point(348, 114);
            this.lblLastTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastTotalCount.Name = "lblLastTotalCount";
            this.lblLastTotalCount.Size = new System.Drawing.Size(0, 18);
            this.lblLastTotalCount.TabIndex = 15;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(348, 148);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(0, 18);
            this.lblTotalCount.TabIndex = 14;
            // 
            // lblCurrentSectionPickCount
            // 
            this.lblCurrentSectionPickCount.AutoSize = true;
            this.lblCurrentSectionPickCount.Location = new System.Drawing.Point(348, 78);
            this.lblCurrentSectionPickCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentSectionPickCount.Name = "lblCurrentSectionPickCount";
            this.lblCurrentSectionPickCount.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentSectionPickCount.TabIndex = 13;
            // 
            // lblQaStatus
            // 
            this.lblQaStatus.AutoSize = true;
            this.lblQaStatus.Location = new System.Drawing.Point(346, 50);
            this.lblQaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQaStatus.Name = "lblQaStatus";
            this.lblQaStatus.Size = new System.Drawing.Size(0, 18);
            this.lblQaStatus.TabIndex = 12;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(75, 180);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(118, 34);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnQA
            // 
            this.btnQA.Location = new System.Drawing.Point(242, 180);
            this.btnQA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQA.Name = "btnQA";
            this.btnQA.Size = new System.Drawing.Size(112, 34);
            this.btnQA.TabIndex = 10;
            this.btnQA.Text = "QA";
            this.btnQA.UseVisualStyleBackColor = true;
            this.btnQA.Click += new System.EventHandler(this.btnQA_Click);
            // 
            // Released
            // 
            this.Released.Location = new System.Drawing.Point(596, 180);
            this.Released.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Released.Name = "Released";
            this.Released.Size = new System.Drawing.Size(112, 34);
            this.Released.TabIndex = 9;
            this.Released.Text = "Released";
            this.Released.UseVisualStyleBackColor = true;
            this.Released.Click += new System.EventHandler(this.Released_Click);
            // 
            // btnReQA
            // 
            this.btnReQA.Location = new System.Drawing.Point(424, 180);
            this.btnReQA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReQA.Name = "btnReQA";
            this.btnReQA.Size = new System.Drawing.Size(112, 34);
            this.btnReQA.TabIndex = 8;
            this.btnReQA.Text = "RE-QA";
            this.btnReQA.UseVisualStyleBackColor = true;
            this.btnReQA.Click += new System.EventHandler(this.btnReQA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "CurrentSectionPickCount：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "LastTotalCount：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "QAResult：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "CurrentSectionTotalCount：";
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.PBImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlImage.Location = new System.Drawing.Point(0, 138);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(736, 702);
            this.pnlImage.TabIndex = 0;
            // 
            // PBImage
            // 
            this.PBImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBImage.Location = new System.Drawing.Point(0, 0);
            this.PBImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(736, 702);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 0;
            this.PBImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CurrentSectionPickCount：";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(195, 24);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // BottleCountMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 842);
            this.Controls.Add(this.pnlMain);
            this.Name = "BottleCountMain";
            this.Text = "BottleCountSystem";
            this.Load += new System.EventHandler(this.BottleCountMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.DeviceStatus.ResumeLayout(false);
            this.DeviceStatus.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlBoxInfo.ResumeLayout(false);
            this.pnlBoxInfo.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlBoxInfo;
        private System.Windows.Forms.Button btnQA;
        private System.Windows.Forms.Button Released;
        private System.Windows.Forms.Button btnReQA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip DeviceStatus;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblSectionPickCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblQaStatus;
        private System.Windows.Forms.Label lblLastTotalCount;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblCurrentSectionPickCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

