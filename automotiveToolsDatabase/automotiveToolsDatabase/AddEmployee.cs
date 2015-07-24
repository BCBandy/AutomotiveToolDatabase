using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace automotiveToolsDatabase
{
    public partial class AddEmployee : Form
    {
        NpgsqlCommand cmd;
        NpgsqlConnection con;
        SqlDataAdapter da;

        public AddEmployee()
        {
            InitializeComponent();
        }
        private bool errorCheckAddEmployeeForm()
        {
            Label[] labels = new Label[4];
            labels[0] = tv_name; labels[1] = tv_ssn; labels[2] = tv_wage; labels[3] = tv_manager;

                
                
            if (string.IsNullOrWhiteSpace(tb_first.Text.ToString()) || string.IsNullOrWhiteSpace(tb_last.Text.ToString()))
            {
                if (string.IsNullOrWhiteSpace(tb_first.Text.ToString()))
                {
                    tb_first.Text = "First";
                    tv_name.ForeColor = System.Drawing.Color.Red;
                }
                if (string.IsNullOrWhiteSpace(tb_last.Text.ToString()))
                {
                    tb_last.Text = "Last";
                    tv_name.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                tv_name.ForeColor = SystemColors.ControlText;
            }

            int ssn;
            if (!int.TryParse(tb_ssn.Text, out ssn))
            {
                tv_ssn.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                tv_ssn.ForeColor = SystemColors.ControlText;
            }

            float wage;
            if (!float.TryParse(tb_wage.Text, out wage))
            {
                tv_wage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                tv_wage.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrWhiteSpace(tb_manager.Text.ToString()))
            {
                tv_manager.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                tv_manager.ForeColor = SystemColors.ControlText;
            }

            int total = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                if (labels[i].ForeColor == SystemColors.ControlText)
                {
                    total += 1;
                }
                if (total == 4)
                {
                    return true;
                }
               
            }
            return false;
                
        }

        private void tb_first_TextChanged(object sender, EventArgs e)
        {
            
        
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            bool validEntry = false;

            validEntry = errorCheckAddEmployeeForm();
            if (validEntry)
            {
                //add info to database here
                //con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Blake\Documents\Visual Studio 2013\Projects\automotiveToolsDatabase\automotiveToolsDatabase\products.mdf;Integrated Security=True";
                con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
                //con.Open();
                cmd = new NpgsqlCommand("INSERT INTO employees VALUES (@firstn, @lastn, @ssn, @wage, @manager)", con);
                //cmd.CommandText = "INSERT INTO employees (firstn, ssn, wage, manager ssn, lastn) VALUES (@firstn, @ssn, @wage, @manager ssn,@last)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                
                cmd.Parameters.AddWithValue("@firstn", tb_first.Text);
                cmd.Parameters.AddWithValue("@lastn", tb_last.Text);
                cmd.Parameters.AddWithValue("@ssn", int.Parse(tb_ssn.Text));
                cmd.Parameters.AddWithValue("@wage", decimal.Parse(tb_wage.Text));
                cmd.Parameters.AddWithValue("@manager", tb_manager.Text);
                

                con.Open();
                NpgsqlDataReader dr = cmd.ExecuteReader();
               // cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(tb_first.Text + " " +tb_last.Text+ " added");
                con.Close();
                this.Close();
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        

    }

}
