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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void tb_run_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            //con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO products VALUES (@sku, @sale_price, @vendor_price, @category, @availability)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@sku", tb_sku.Text);
            cmd.Parameters.AddWithValue("@sale_price", tb_sale.Text);
            cmd.Parameters.AddWithValue("@vendor_price", tb_vendor.Text);
            cmd.Parameters.AddWithValue("@category", tb_cat.Text);
            cmd.Parameters.AddWithValue("@availability", tb_avail.Text);

            try
            {

                con.Open();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                // cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(tb_sku.Text + " added");
                con.Close();
                this.Close();
            }
            catch 
            { 
                MessageBox.Show("Invalid entry");
                con.Close();
            }
        }
    }
}
