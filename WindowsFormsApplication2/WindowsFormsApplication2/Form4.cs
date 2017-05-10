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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sl no", typeof(int));
            table.Columns.Add("product name", typeof(string));
            table.Columns.Add("price", typeof(double));
            table.Columns.Add("quantity", typeof(int));
            foreach (Product a in GlobalData.list)
            {
                table.Rows.Add(a.sl_no,a.name,a.price,a.quantity);
            }
                dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
    }
}
