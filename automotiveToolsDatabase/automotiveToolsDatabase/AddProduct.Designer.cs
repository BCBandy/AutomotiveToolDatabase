namespace automotiveToolsDatabase
{
    partial class AddProduct
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
            this.tb_sku = new System.Windows.Forms.TextBox();
            this.tb_sale = new System.Windows.Forms.TextBox();
            this.tb_vendor = new System.Windows.Forms.TextBox();
            this.tb_cat = new System.Windows.Forms.TextBox();
            this.tb_avail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_sku
            // 
            this.tb_sku.Location = new System.Drawing.Point(101, 32);
            this.tb_sku.Name = "tb_sku";
            this.tb_sku.Size = new System.Drawing.Size(94, 20);
            this.tb_sku.TabIndex = 0;
            // 
            // tb_sale
            // 
            this.tb_sale.Location = new System.Drawing.Point(101, 58);
            this.tb_sale.Name = "tb_sale";
            this.tb_sale.Size = new System.Drawing.Size(94, 20);
            this.tb_sale.TabIndex = 1;
            // 
            // tb_vendor
            // 
            this.tb_vendor.Location = new System.Drawing.Point(101, 84);
            this.tb_vendor.Name = "tb_vendor";
            this.tb_vendor.Size = new System.Drawing.Size(94, 20);
            this.tb_vendor.TabIndex = 2;
            // 
            // tb_cat
            // 
            this.tb_cat.Location = new System.Drawing.Point(101, 110);
            this.tb_cat.Name = "tb_cat";
            this.tb_cat.Size = new System.Drawing.Size(94, 20);
            this.tb_cat.TabIndex = 3;
            // 
            // tb_avail
            // 
            this.tb_avail.Location = new System.Drawing.Point(101, 136);
            this.tb_avail.Name = "tb_avail";
            this.tb_avail.Size = new System.Drawing.Size(94, 20);
            this.tb_avail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sale price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendor price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Availability";
            // 
            // tb_run
            // 
            this.tb_run.Location = new System.Drawing.Point(87, 186);
            this.tb_run.Name = "tb_run";
            this.tb_run.Size = new System.Drawing.Size(75, 23);
            this.tb_run.TabIndex = 10;
            this.tb_run.Text = "Run";
            this.tb_run.UseVisualStyleBackColor = true;
            this.tb_run.Click += new System.EventHandler(this.tb_run_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 231);
            this.Controls.Add(this.tb_run);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_avail);
            this.Controls.Add(this.tb_cat);
            this.Controls.Add(this.tb_vendor);
            this.Controls.Add(this.tb_sale);
            this.Controls.Add(this.tb_sku);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_sku;
        private System.Windows.Forms.TextBox tb_sale;
        private System.Windows.Forms.TextBox tb_vendor;
        private System.Windows.Forms.TextBox tb_cat;
        private System.Windows.Forms.TextBox tb_avail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tb_run;
    }
}