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
    public partial class RemoveEmp : Form
    {
        public RemoveEmp()
        {
            InitializeComponent();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from employees where ssn = @ssn", con);
           
            cmd.Parameters.AddWithValue("@ssn", tb_ssn.Text);
            cmd.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Person deleted");
            con.Close();
            this.Close();
        }

        private void RemoveEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
