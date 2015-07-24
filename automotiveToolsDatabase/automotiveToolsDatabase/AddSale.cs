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
    
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
            string date = System.DateTime.Now.ToString("mm/dd/yyyy");
            textBox6.Text = date;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            TextBox[] tbarr = new TextBox[5];

            tbarr[0] = textbox1; tbarr[1] = textBox2; tbarr[2] = textBox3; tbarr[3] = textBox4; tbarr[4] = textBox5;
            bool valid = true;

            for (int i = 0; i < 5; i++)
            {
                if (String.IsNullOrWhiteSpace(tbarr[i].Text))
                {
                    valid = false;
                }
            }
            Console.WriteLine("pre");
            if (valid == true)
            {
                Console.WriteLine("valid = true");
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
                //con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sales (lastn, sku, order_number, total, employee_ssn, date_of_purchase) VALUES ('" + textbox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + System.DateTime.Now.ToString("MM/dd/yyyy") + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sale added!");
                this.Close();
            }
            
                
        }
    }
}
