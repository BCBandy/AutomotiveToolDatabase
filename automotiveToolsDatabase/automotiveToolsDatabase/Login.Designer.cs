namespace automotiveToolsDatabase
{
    partial class Login
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tv_user = new System.Windows.Forms.Label();
            this.tv_pass = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(113, 36);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(158, 20);
            this.tb_user.TabIndex = 0;
            this.tb_user.Text = "Blake Bandy";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(113, 62);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(158, 20);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.Text = "222222222";
            // 
            // tv_user
            // 
            this.tv_user.AutoSize = true;
            this.tv_user.Location = new System.Drawing.Point(48, 43);
            this.tv_user.Name = "tv_user";
            this.tv_user.Size = new System.Drawing.Size(55, 13);
            this.tv_user.TabIndex = 2;
            this.tv_user.Text = "Username";
            // 
            // tv_pass
            // 
            this.tv_pass.AutoSize = true;
            this.tv_pass.Location = new System.Drawing.Point(48, 67);
            this.tv_pass.Name = "tv_pass";
            this.tv_pass.Size = new System.Drawing.Size(53, 13);
            this.tv_pass.TabIndex = 3;
            this.tv_pass.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(124, 102);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 135);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tv_pass);
            this.Controls.Add(this.tv_user);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label tv_user;
        private System.Windows.Forms.Label tv_pass;
        private System.Windows.Forms.Button btn_login;
    }
}

