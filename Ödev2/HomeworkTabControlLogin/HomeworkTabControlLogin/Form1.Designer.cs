namespace HomeworkTabControlLogin
{
    partial class FrmLogin
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
            this.TabLogin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtPassword1 = new System.Windows.Forms.TextBox();
            this.TxtMailAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TabLogin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.tabPage1);
            this.TabLogin.Controls.Add(this.tabPage2);
            this.TabLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabLogin.Location = new System.Drawing.Point(0, 0);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.SelectedIndex = 0;
            this.TabLogin.Size = new System.Drawing.Size(684, 310);
            this.TabLogin.TabIndex = 0;
            this.TabLogin.SelectedIndexChanged += new System.EventHandler(this.TabLogin_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.TxtPassword1);
            this.tabPage1.Controls.Add(this.TxtMailAddress);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mail ile Giriş";
            // 
            // TxtPassword1
            // 
            this.TxtPassword1.Location = new System.Drawing.Point(159, 89);
            this.TxtPassword1.Name = "TxtPassword1";
            this.TxtPassword1.PasswordChar = '*';
            this.TxtPassword1.Size = new System.Drawing.Size(301, 26);
            this.TxtPassword1.TabIndex = 3;
            // 
            // TxtMailAddress
            // 
            this.TxtMailAddress.Location = new System.Drawing.Point(159, 59);
            this.TxtMailAddress.Name = "TxtMailAddress";
            this.TxtMailAddress.Size = new System.Drawing.Size(301, 26);
            this.TxtMailAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Chocolate;
            this.tabPage2.Controls.Add(this.TxtPassword2);
            this.tabPage2.Controls.Add(this.TxtUsername);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcı Adı ile Giriş";
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Location = new System.Drawing.Point(152, 97);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.PasswordChar = '*';
            this.TxtPassword2.Size = new System.Drawing.Size(301, 26);
            this.TxtPassword2.TabIndex = 7;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(152, 67);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(301, 26);
            this.TxtUsername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 122);
            this.panel1.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(504, 10);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(168, 95);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Çıkış";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(12, 10);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(168, 95);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Giriş";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabLogin);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Ekranı";
            this.TabLogin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabLogin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TxtPassword1;
        private System.Windows.Forms.TextBox TxtMailAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtPassword2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
    }
}

