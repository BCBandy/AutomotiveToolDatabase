using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace automotiveToolsDatabase
{
    public partial class DeleteSale : Form
    {
        public DeleteSale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from sales where order_number = '"+textBox1.Text+"'", con);
            
            num = cmd.ExecuteNonQuery();
            
            con.Close();

            if (num == 0)
            {
                MessageBox.Show("Order number not found");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sale deleted!");
                this.Close();
            }           
        }
    }
}
