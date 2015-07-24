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
    public partial class MonthlySales : Form
    {
        public MonthlySales()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            decimal total = 0, returned = 0;
            if (tb_month != null && tb_year != null)
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
                con.Open();

                string tmp = "";
                //NpgsqlDataReader result;
                for (int i = 1; i <= 31; i++)
                {
                    try
                    {
                        tmp = tb_month.Text + "/" + i.ToString() + "/" + tb_year.Text;
                        var cmd = new NpgsqlCommand(@"select total 
                                                                from sales 
                                                                where date_of_purchase = '"+tmp+"'", con);
                        //cmd.Parameters.Add("@tmp", tmp);
                        var result = cmd.ExecuteReader();

                        if (result.Read())
                        {
                            total += result.GetDecimal(0);
                        }
                        result.Close();
                    }
                    catch { MessageBox.Show("Invalid entry"); }
                }

                for (int i = 1; i <= 31; i++)
                {
                    try
                    {
                        tmp = tb_month.Text + "/" + i.ToString() + "/" + tb_year.Text;
                        var cmd = new NpgsqlCommand(@"select total 
                                                                from returns 
                                                                where date_of_return = '" + tmp + "'", con);
                        var result = cmd.ExecuteReader();

                        if (result.Read())
                        {
                            returned += result.GetDecimal(0);
                        }
                        result.Close();
                    }
                    catch { }
                }
                
                con.Close();
                MessageBox.Show("Month total: " + (total - returned).ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid data");
            }
            
        }

        private void MonthlySales_Load(object sender, EventArgs e)
        {

        }
    }
}
