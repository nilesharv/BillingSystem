using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        DataTable table = new DataTable();
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            table.Columns.Add("Sl no", typeof(int));
            table.Columns.Add("product name", typeof(string));
            table.Columns.Add("price", typeof(double));
            table.Columns.Add("quantity", typeof(int));
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow r in table.Rows)
                {
                    string str = r["Sl no"].ToString() + " " + r["product name"].ToString() + " " + r["price"].ToString() + " " + r["quantity"].ToString();

                    GlobalData.list.Add(new Product(int.Parse(r["Sl no"].ToString()), r["product name"].ToString(), int.Parse(r["quantity"].ToString()), float.Parse(r["price"].ToString())));
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("pls insert valid data");
            }
        }
    }
}
