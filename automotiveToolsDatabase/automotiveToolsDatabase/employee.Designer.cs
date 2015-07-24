namespace automotiveToolsDatabase
{
    partial class Employee
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
            this.btn_add_emp = new System.Windows.Forms.Button();
            this.btn_remove_emp = new System.Windows.Forms.Button();
            this.dl_tables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.gv_result = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_emp
            // 
            this.btn_add_emp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add_emp.Enabled = false;
            this.btn_add_emp.Location = new System.Drawing.Point(136, 16);
            this.btn_add_emp.Name = "btn_add_emp";
            this.btn_add_emp.Size = new System.Drawing.Size(59, 23);
            this.btn_add_emp.TabIndex = 0;
            this.btn_add_emp.Text = "Add Emp";
            this.btn_add_emp.UseVisualStyleBackColor = true;
            this.btn_add_emp.Click += new System.EventHandler(this.btn_add_emp_Click);
            // 
            // btn_remove_emp
            // 
            this.btn_remove_emp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_remove_emp.Enabled = false;
            this.btn_remove_emp.Location = new System.Drawing.Point(201, 16);
            this.btn_remove_emp.Name = "btn_remove_emp";
            this.btn_remove_emp.Size = new System.Drawing.Size(70, 23);
            this.btn_remove_emp.TabIndex = 2;
            this.btn_remove_emp.Text = "Delete Emp";
            this.btn_remove_emp.UseVisualStyleBackColor = true;
            this.btn_remove_emp.Click += new System.EventHandler(this.btn_remove_emp_Click);
            // 
            // dl_tables
            // 
            this.dl_tables.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dl_tables.FormattingEnabled = true;
            this.dl_tables.Items.AddRange(new object[] {
            "Select...",
            "Employees",
            "Products",
            "Returns",
            "Add sale",
            "Delete sale",
            "New return",
            "Add product",
            "Delete product",
            "Out of stock",
            "Category and range"});
            this.dl_tables.Location = new System.Drawing.Point(12, 44);
            this.dl_tables.Name = "dl_tables";
            this.dl_tables.Size = new System.Drawing.Size(118, 21);
            this.dl_tables.TabIndex = 3;
            this.dl_tables.Text = "Select...";
            this.dl_tables.SelectedIndexChanged += new System.EventHandler(this.cb_tables_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show Table";
            // 
            // btn_run
            // 
            this.btn_run.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_run.Location = new System.Drawing.Point(136, 44);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(135, 23);
            this.btn_run.TabIndex = 7;
            this.btn_run.Text = "Run Query";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // gv_result
            // 
            this.gv_result.AllowUserToAddRows = false;
            this.gv_result.AllowUserToOrderColumns = true;
            this.gv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_result.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_result.Location = new System.Drawing.Point(12, 73);
            this.gv_result.Name = "gv_result";
            this.gv_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gv_result.Size = new System.Drawing.Size(374, 314);
            this.gv_result.TabIndex = 10;
            this.gv_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_result_CellContentClick);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_search.Location = new System.Drawing.Point(277, 18);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(109, 20);
            this.tb_search.TabIndex = 11;
            this.tb_search.Text = "Search...";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search.Location = new System.Drawing.Point(277, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(109, 23);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 399);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.gv_result);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dl_tables);
            this.Controls.Add(this.btn_remove_emp);
            this.Controls.Add(this.btn_add_emp);
            this.MinimumSize = new System.Drawing.Size(415, 237);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_emp;
        private System.Windows.Forms.Button btn_remove_emp;
        private System.Windows.Forms.ComboBox dl_tables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.DataGridView gv_result;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;

       
    }
}