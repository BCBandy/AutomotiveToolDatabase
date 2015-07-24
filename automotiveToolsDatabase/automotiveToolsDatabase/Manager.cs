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
using System.Web;


namespace automotiveToolsDatabase
{
    public partial class Manager : Form
    {
        public static string num = "", high = "", low = "", cat = "";
        NpgsqlCommand cmd;
        NpgsqlConnection con;
        Dictionary<string, string[]> []databaseDic = new Dictionary<string,string[]>[]
        {
            new Dictionary<string, string[]>(), 
            new Dictionary<string, string[]>(),
            new Dictionary<string, string[]>()
        };

        public Manager()
        {
            InitializeComponent();
            databaseDic[0].Add("employees", new string[] { "firstn", "lastn", "ssn", "wage", "manager" });
            databaseDic[1].Add("products", new string[] { "sku", "description", "price", "vendor price", "category" });
            databaseDic[2].Add("sales", new string[] { "firstn", "lastn", "sku", "order_number", "total", "employee_ssn", "date_of_purchase" });

        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            Form addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void btn_remove_emp_Click(object sender, EventArgs e)
        {
            Form removeEmp = new RemoveEmp();
            removeEmp.Show();
        }

        private void cb_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            
            DataTable table = new DataTable();
            con.Open();

            if (dl_tables.SelectedItem.ToString() == "Employees")
            {
                cmd = new NpgsqlCommand("select * from employees", con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                con.Close();
            }

            if (dl_tables.SelectedItem.ToString() == "Sales")
            {
                cmd = new NpgsqlCommand("select * from sales", con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                con.Close();
            }

            if (dl_tables.SelectedItem.ToString() == "Products")
            {
                cmd = new NpgsqlCommand("select * from Products", con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                con.Close();
            }

            if (dl_tables.SelectedItem.ToString() == "Out of stock")
            {
                cmd = new NpgsqlCommand(@"select *
                                            from products
                                            where availability = 0
                                            order by availability, sale_price desc", con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                con.Close();
            }

            if (dl_tables.SelectedItem.ToString() == "Top x sales")
            {
                
                Form HowMany = new HowMany();
                HowMany.ShowDialog();

                cmd = new NpgsqlCommand(@"  select emp.firstn,emp.lastn,t1.total_sales as top_sales
                                            from employees emp,(select employee_ssn,sum(total) as total_sales
                                                                from sales
                                                                group by employee_ssn
                                                                order by total_sales desc
                                                                limit "+ num +@") as t1
                                            where emp.ssn = cast(t1.employee_ssn as numeric)
                                            order by top_sales desc", con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                con.Close();
            }

            if (dl_tables.SelectedItem.ToString() == "Category and range")
            {
                Form CatPrice = new CatPrice();
                CatPrice.ShowDialog();

                cmd = new NpgsqlCommand(@"  select sku,sale_price,vendor_price,category,availability
                                            from products
                                            group by category,sku,sale_price,vendor_price,availability
                                            having category = '"+cat+@"' AND sale_price <= "+high+@" and sale_price >= "+low+@"
                                            order by sale_price desc", con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                con.Close();
            }

            if (dl_tables.SelectedItem.ToString() == "Add product")
            {
                con.Close();
                Form AddProduct = new AddProduct();
                AddProduct.ShowDialog();                
            }

            if (dl_tables.SelectedItem.ToString() == "Delete product")
            {
                con.Close();
                Form DeleteProduct = new DeleteProduct();
                DeleteProduct.ShowDialog();
            }

            if (dl_tables.SelectedItem.ToString() == "New return")
            {
                con.Close();
                Form NewReturn = new NewReturn();
               NewReturn.ShowDialog();
            }

            if (dl_tables.SelectedItem.ToString() == "Returns")
            {
                cmd = new NpgsqlCommand("select * from returns", con);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                con.Close();
            }

            if (dl_tables.SelectedItem.ToString() == "Monthly sales")
            {
                con.Close();
                Form MonthlySales = new MonthlySales();
                MonthlySales.ShowDialog();
            }

            if (dl_tables.SelectedItem.ToString() == "Add sale")
            {
                con.Close();
                Form AddSale = new AddSale();
                AddSale.ShowDialog();
            }

            if (dl_tables.SelectedItem.ToString() == "Delete sale")
            {
                con.Close();
                Form DeleteSale = new DeleteSale();
                DeleteSale.ShowDialog();
            }
            //dl_tables.SelectedIndex = 0;
        }

        private void tb_custom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_custom_query_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string customQuery = tb_custom.Text.ToString();
            //Console.WriteLine(customQuery);
            con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=blakerocks;Database=AutomotiveTools");
            //cmd = new SqlCommand(tb_custom.Text.ToString(), con);
            con.Open();
            cmd = new NpgsqlCommand(customQuery, con);

            try
            {
                table.Load(cmd.ExecuteReader());
                gv_result.ReadOnly = true;
                gv_result.DataSource = table;
                cmd.ExecuteNonQuery();
                
            }
            catch { MessageBox.Show("Syntax error"); }
            con.Close();
        }

        private void gv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int count = 0;
            DataTable table = new DataTable();
            DataTable headers = new DataTable();
            string[] colHeaders = new string[gv_result.Rows[0].Cells.Count];
            DataTable dv = (DataTable)gv_result.DataSource;
            
            
            foreach (DataColumn col in dv.Columns)
            {
                colHeaders[count] = col.ColumnName;
                count++;
            }

            for (int i = 0; i < gv_result.Rows[0].Cells.Count; i++)
            {

            }
                //initilize datatable length
                foreach (DataGridViewColumn col in gv_result.Columns)
                {
                    table.Columns.Add();
                }

            //set new table headers = current gridview headers
            /*
            for (int i = 0; i < gv_result.Columns.Count; i++ )
            {
                table.Columns[0]
            }
             /* */
                //If the data in the textbox exists in a row, that row is returned to gv_result
                foreach (DataGridViewRow row in gv_result.Rows)
                {
                    for (int i = 0; i < gv_result.Columns.Count; i++)
                    {                        
                        if (row.Cells[i].Value.ToString().Contains(tb_search.Text) && tb_search.Text != "")
                        {
                            DataRow dr;
                            dr = table.NewRow();

                            for (int j = 0; j < row.Cells.Count; j++)
                            {
                                dr[j] = row.Cells[j].Value.ToString();
                                Console.WriteLine(dr[j] + " " + row.Cells[j]);
                            }
                            if (dr != null)
                            {
                                table.Rows.Add(dr);
                            }
                        }                        

                        
                    }
                    /*
                    */
                }
                try
                {
                    if (table.Rows[0] != null)
                    { 
                        count = 0;
                        foreach (DataGridViewColumn col in gv_result.Columns)
                        {
                            table.Columns[count].ColumnName = colHeaders[count];
                            count++;
                        }
                        gv_result.DataSource = table;                                              
                    }
                    
                }
                catch { MessageBox.Show("Not found"); }
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
