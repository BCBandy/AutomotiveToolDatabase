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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool getLoginType()
        {            
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(@"select firstn, lastn, ssn 
                                                    from employees 
                                                    where ssn in (
                                                                   select distinct manager_ssn
                                                                   from employees
                                                                   where ssn = " + tb_pass.Text + @"
                                                                   )", con);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataTable table = new DataTable();

            try
            {
                table.Load(cmd.ExecuteReader());
            }
            catch { }
            
            con.Close();

            //fill qname with name returned from query
            string[] qname = new string[3];

            //fill tbname with name from textbox
            string[] tbname = new string[2];
            tbname = tb_user.Text.Split();

            //if person logging in is manager returns true
            try
            {
                if (table.Rows[0][0] != null)
                {
                    qname[0] = table.Rows[0][0].ToString();
                    qname[1] = table.Rows[0][1].ToString();
                    qname[2] = table.Rows[0][2].ToString();

                    //check if login form matches database info
                    if (tbname[0] == qname[0] && tbname[1] == qname[1] && tb_pass.Text == qname[2])
                    {
                        Console.Write("welcome manager");
                        Program.loginType = "manager";
                        return true;
                    }
                }
            }
            catch { }
            //if person is not a manager search database for employees            
            con.Open();
            cmd = new NpgsqlCommand(@"select firstn, lastn, ssn 
                                                from employees 
                                                where ssn =" + tb_pass.Text, con);
            adapter = new NpgsqlDataAdapter(cmd);
            table = new DataTable();
            try
            {
                table.Load(cmd.ExecuteReader());
            }
            catch { }
            
            con.Close();

            //if login is a valid employee return true
            try
            {
                if (table.Rows[0][0] != null)
                {
                    qname[0] = table.Rows[0][0].ToString();
                    qname[1] = table.Rows[0][1].ToString();
                    qname[2] = table.Rows[0][2].ToString();

                    //check if login form matches database info
                    if (tbname[0] == qname[0] && tbname[1] == qname[1] && tb_pass.Text == qname[2])
                    {
                        Console.Write("welcome employee");
                        Program.loginType = "employee";
                        return true;
                    }
                }
            }
            catch { }
            MessageBox.Show("Invalid Login");
            return false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_user.Text) && !string.IsNullOrWhiteSpace(tb_pass.Text))
            {
                if (getLoginType() == true)
                {
                    this.DialogResult = DialogResult.OK;
                }
                
                //this.Hide();
            }
        }
    }
}
