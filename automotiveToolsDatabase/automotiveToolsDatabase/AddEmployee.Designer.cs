namespace automotiveToolsDatabase
{
    partial class AddEmployee
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
            this.tb_first = new System.Windows.Forms.TextBox();
            this.tb_last = new System.Windows.Forms.TextBox();
            this.tb_ssn = new System.Windows.Forms.TextBox();
            this.tb_wage = new System.Windows.Forms.TextBox();
            this.tb_manager = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tv_name = new System.Windows.Forms.Label();
            this.tv_ssn = new System.Windows.Forms.Label();
            this.tv_wage = new System.Windows.Forms.Label();
            this.tv_manager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_first
            // 
            this.tb_first.Location = new System.Drawing.Point(68, 25);
            this.tb_first.Name = "tb_first";
            this.tb_first.Size = new System.Drawing.Size(80, 20);
            this.tb_first.TabIndex = 0;
            this.tb_first.Text = "First";
            this.tb_first.TextChanged += new System.EventHandler(this.tb_first_TextChanged);
            // 
            // tb_last
            // 
            this.tb_last.Location = new System.Drawing.Point(154, 25);
            this.tb_last.Name = "tb_last";
            this.tb_last.Size = new System.Drawing.Size(93, 20);
            this.tb_last.TabIndex = 1;
            this.tb_last.Text = "Last";
            // 
            // tb_ssn
            // 
            this.tb_ssn.Location = new System.Drawing.Point(68, 51);
            this.tb_ssn.Name = "tb_ssn";
            this.tb_ssn.Size = new System.Drawing.Size(179, 20);
            this.tb_ssn.TabIndex = 2;
            // 
            // tb_wage
            // 
            this.tb_wage.Location = new System.Drawing.Point(68, 77);
            this.tb_wage.Name = "tb_wage";
            this.tb_wage.Size = new System.Drawing.Size(179, 20);
            this.tb_wage.TabIndex = 3;
            // 
            // tb_manager
            // 
            this.tb_manager.Location = new System.Drawing.Point(68, 103);
            this.tb_manager.Name = "tb_manager";
            this.tb_manager.Size = new System.Drawing.Size(179, 20);
            this.tb_manager.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(100, 137);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tv_name
            // 
            this.tv_name.AutoSize = true;
            this.tv_name.Location = new System.Drawing.Point(14, 28);
            this.tv_name.Name = "tv_name";
            this.tv_name.Size = new System.Drawing.Size(35, 13);
            this.tv_name.TabIndex = 6;
            this.tv_name.Text = "Name";
            // 
            // tv_ssn
            // 
            this.tv_ssn.AutoSize = true;
            this.tv_ssn.Location = new System.Drawing.Point(14, 54);
            this.tv_ssn.Name = "tv_ssn";
            this.tv_ssn.Size = new System.Drawing.Size(29, 13);
            this.tv_ssn.TabIndex = 7;
            this.tv_ssn.Text = "SSN";
            // 
            // tv_wage
            // 
            this.tv_wage.AutoSize = true;
            this.tv_wage.Location = new System.Drawing.Point(14, 80);
            this.tv_wage.Name = "tv_wage";
            this.tv_wage.Size = new System.Drawing.Size(36, 13);
            this.tv_wage.TabIndex = 8;
            this.tv_wage.Text = "Wage";
            // 
            // tv_manager
            // 
            this.tv_manager.AutoSize = true;
            this.tv_manager.Location = new System.Drawing.Point(14, 106);
            this.tv_manager.Name = "tv_manager";
            this.tv_manager.Size = new System.Drawing.Size(50, 13);
            this.tv_manager.TabIndex = 9;
            this.tv_manager.Text = "Mgr SSN";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 183);
            this.Controls.Add(this.tv_manager);
            this.Controls.Add(this.tv_wage);
            this.Controls.Add(this.tv_ssn);
            this.Controls.Add(this.tv_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_manager);
            this.Controls.Add(this.tb_wage);
            this.Controls.Add(this.tb_ssn);
            this.Controls.Add(this.tb_last);
            this.Controls.Add(this.tb_first);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_first;
        private System.Windows.Forms.TextBox tb_last;
        private System.Windows.Forms.TextBox tb_ssn;
        private System.Windows.Forms.TextBox tb_wage;
        private System.Windows.Forms.TextBox tb_manager;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label tv_name;
        private System.Windows.Forms.Label tv_ssn;
        private System.Windows.Forms.Label tv_wage;
        private System.Windows.Forms.Label tv_manager;
    }
}