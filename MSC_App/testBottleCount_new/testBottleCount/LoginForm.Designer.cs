namespace testBottleCount
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFaceLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelVideoSourcePlayer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFaceLogin);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panelVideoSourcePlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 1019);
            this.panel1.TabIndex = 0;
            // 
            // btnFaceLogin
            // 
            this.btnFaceLogin.Location = new System.Drawing.Point(210, 952);
            this.btnFaceLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFaceLogin.Name = "btnFaceLogin";
            this.btnFaceLogin.Size = new System.Drawing.Size(188, 46);
            this.btnFaceLogin.TabIndex = 1;
            this.btnFaceLogin.Text = "Face Login";
            this.btnFaceLogin.UseVisualStyleBackColor = true;
            this.btnFaceLogin.Click += new System.EventHandler(this.btnFaceLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(540, 952);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Normal Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnNormalLogin_Click);
            // 
            // panelVideoSourcePlayer
            // 
            this.panelVideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVideoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.panelVideoSourcePlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelVideoSourcePlayer.Name = "panelVideoSourcePlayer";
            this.panelVideoSourcePlayer.Size = new System.Drawing.Size(873, 942);
            this.panelVideoSourcePlayer.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 1019);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelVideoSourcePlayer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnFaceLogin;
    }
}