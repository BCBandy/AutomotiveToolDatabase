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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            con.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("delete from products where sku = @sku", con);

                cmd.Parameters.AddWithValue("@sku", tb_sku.Text);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Item deleted");
                con.Close();
                this.Close();
            }
            catch { MessageBox.Show("Item not found"); }
            
        }
    }
}
