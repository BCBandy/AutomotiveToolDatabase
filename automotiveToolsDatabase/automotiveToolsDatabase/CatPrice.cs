﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automotiveToolsDatabase
{
    public partial class CatPrice : Form
    {
        public CatPrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Manager>().Any())
            {
                Manager.cat = tb_cat.Text;
                Manager.low = tb_low.Text;
                Manager.high = tb_high.Text;
                this.Close();
            }
            else
            {
                Employee.cat = tb_cat.Text;
                Employee.low = tb_low.Text;
                Employee.high = tb_high.Text;
                this.Close();
            }
        }
    }
}
