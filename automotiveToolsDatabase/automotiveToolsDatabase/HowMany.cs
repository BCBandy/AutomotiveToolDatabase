using System;
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
    public partial class HowMany : Form
    {
        public HowMany()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Manager>().Any())
            {
                Manager.num = tb_number.Text;
                this.Close();
            }
            else
            {
                Employee.num = tb_number.Text;
                this.Close();
            }
        }
    }
}
