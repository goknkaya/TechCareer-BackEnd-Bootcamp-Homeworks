namespace ClientTestProject
{
    partial class Form1
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
            this.BtnGetToken = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtApiKey = new System.Windows.Forms.TextBox();
            this.TxtSecretKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtToken = new System.Windows.Forms.TextBox();
            this.BtnGetDoctorApointments = new System.Windows.Forms.Button();
            this.DataGridViewDoctorApointments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDoctorApointments)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetToken
            // 
            this.BtnGetToken.Location = new System.Drawing.Point(469, 148);
            this.BtnGetToken.Name = "BtnGetToken";
            this.BtnGetToken.Size = new System.Drawing.Size(254, 73);
            this.BtnGetToken.TabIndex = 0;
            this.BtnGetToken.Text = "Get Token";
            this.BtnGetToken.UseVisualStyleBackColor = true;
            this.BtnGetToken.Click += new System.EventHandler(this.BtnGetToken_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(49, 50);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(392, 38);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.Text = "tuncgulec";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(49, 108);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(392, 38);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "12345";
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtApiKey
            // 
            this.TxtApiKey.Location = new System.Drawing.Point(49, 166);
            this.TxtApiKey.Name = "TxtApiKey";
            this.TxtApiKey.Size = new System.Drawing.Size(392, 38);
            this.TxtApiKey.TabIndex = 3;
            this.TxtApiKey.Text = "123456789";
            // 
            // TxtSecretKey
            // 
            this.TxtSecretKey.Location = new System.Drawing.Point(49, 224);
            this.TxtSecretKey.Name = "TxtSecretKey";
            this.TxtSecretKey.Size = new System.Drawing.Size(392, 38);
            this.TxtSecretKey.TabIndex = 4;
            this.TxtSecretKey.Text = "987654321";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "BtnGetNow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtToken
            // 
            this.TxtToken.Location = new System.Drawing.Point(49, 268);
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(770, 38);
            this.TxtToken.TabIndex = 6;
            // 
            // BtnGetDoctorApointments
            // 
            this.BtnGetDoctorApointments.Location = new System.Drawing.Point(469, 318);
            this.BtnGetDoctorApointments.Name = "BtnGetDoctorApointments";
            this.BtnGetDoctorApointments.Size = new System.Drawing.Size(352, 122);
            this.BtnGetDoctorApointments.TabIndex = 7;
            this.BtnGetDoctorApointments.Text = "Randevu Listesini Al";
            this.BtnGetDoctorApointments.UseVisualStyleBackColor = true;
            this.BtnGetDoctorApointments.Click += new System.EventHandler(this.BtnGetDoctorApointments_Click);
            // 
            // DataGridViewDoctorApointments
            // 
            this.DataGridViewDoctorApointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDoctorApointments.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataGridViewDoctorApointments.Location = new System.Drawing.Point(871, 0);
            this.DataGridViewDoctorApointments.Name = "DataGridViewDoctorApointments";
            this.DataGridViewDoctorApointments.RowHeadersWidth = 102;
            this.DataGridViewDoctorApointments.RowTemplate.Height = 40;
            this.DataGridViewDoctorApointments.Size = new System.Drawing.Size(671, 907);
            this.DataGridViewDoctorApointments.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 907);
            this.Controls.Add(this.DataGridViewDoctorApointments);
            this.Controls.Add(this.BtnGetDoctorApointments);
            this.Controls.Add(this.TxtToken);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtSecretKey);
            this.Controls.Add(this.TxtApiKey);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.BtnGetToken);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDoctorApointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetToken;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtApiKey;
        private System.Windows.Forms.TextBox TxtSecretKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtToken;
        private System.Windows.Forms.Button BtnGetDoctorApointments;
        private System.Windows.Forms.DataGridView DataGridViewDoctorApointments;
    }
}

