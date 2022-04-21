namespace testBottleCount
{
    partial class LoginNew
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
            this.btn_FaceLogin_tab = new System.Windows.Forms.Button();
            this.btn_UserNamePasswdLogin_tab = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_FaceLogin_tab
            // 
            this.btn_FaceLogin_tab.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FaceLogin_tab.Location = new System.Drawing.Point(-7, 19);
            this.btn_FaceLogin_tab.Name = "btn_FaceLogin_tab";
            this.btn_FaceLogin_tab.Size = new System.Drawing.Size(493, 272);
            this.btn_FaceLogin_tab.TabIndex = 2;
            this.btn_FaceLogin_tab.Text = "Face Login";
            this.btn_FaceLogin_tab.UseVisualStyleBackColor = true;
            // 
            // btn_UserNamePasswdLogin_tab
            // 
            this.btn_UserNamePasswdLogin_tab.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserNamePasswdLogin_tab.Location = new System.Drawing.Point(525, 19);
            this.btn_UserNamePasswdLogin_tab.Name = "btn_UserNamePasswdLogin_tab";
            this.btn_UserNamePasswdLogin_tab.Size = new System.Drawing.Size(481, 272);
            this.btn_UserNamePasswdLogin_tab.TabIndex = 3;
            this.btn_UserNamePasswdLogin_tab.Text = "Username Login";
            this.btn_UserNamePasswdLogin_tab.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btn_UserNamePasswdLogin_tab);
            this.panelLogin.Controls.Add(this.btn_FaceLogin_tab);
            this.panelLogin.Location = new System.Drawing.Point(26, 280);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1009, 340);
            this.panelLogin.TabIndex = 2;
            // 
            // LoginNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 1101);
            this.Controls.Add(this.panelLogin);
            this.Name = "LoginNew";
            this.Text = "Login window";
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FaceLogin_tab;
        private System.Windows.Forms.Button btn_UserNamePasswdLogin_tab;
        private System.Windows.Forms.Panel panelLogin;
    }
}