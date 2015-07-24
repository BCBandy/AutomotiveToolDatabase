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
    public partial class NewReturn : Form
    {
        public NewReturn()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            
            decimal tmp;

            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            //con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sales where order_number = "+tb_ordernum.Text, con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            
            con.Open();
            //NpgsqlDataReader dr = cmd.ExecuteReader();
            
            // cmd.ExecuteNonQuery();
            //MessageBox.Show(tb_first.Text + " " + tb_last.Text + " added");
            try
            {
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tb_lastn.Text = reader.GetString(0);
                    tb_sku.Text = reader.GetString(1);

                    tmp = reader.GetDecimal(3);
                    tb_total.Text = tmp.ToString();

                    tb_empssn.Text = reader.GetInt32(4).ToString();
                    tb_datepurchase.Text = reader.GetString(5);
                    tb_datereturn.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Order number not found");
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Invalid entry");
            }
            
        }

        private bool entryExists(string txt){

            int res = 0;
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            //con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from returns where order_number = '"+txt+"'", con);
            //cmd.CommandType = CommandType.Text;
            con.Open();
            res = cmd.ExecuteNonQuery();
            con.Close();
            Console.Write(res);
            if (res == -1)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_lastn != null && !entryExists(tb_ordernum.Text))
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
                //con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into returns (lastn, sku, order_number, total, employee_ssn, date_of_purchase, date_of_return) VALUES ('"+tb_lastn.Text+"', '"+tb_sku.Text+"', '"+int.Parse(tb_ordernum.Text)+"', '"+decimal.Parse(tb_total.Text)+"', '"+int.Parse(tb_empssn.Text)+"', '"+tb_datepurchase.Text+"', '"+tb_datereturn.Text+"')", con);
                //cmd.CommandType = CommandType.Text;
                con.Open();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Return added");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid entry");
            }
        }

        private void NewReturn_Load(object sender, EventArgs e)
        {

        }
    }
}
