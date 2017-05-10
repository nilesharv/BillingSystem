using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        DataTable table = new DataTable();
        float total = 0.0f;
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Sl no", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("price", typeof(float));
            table.Columns.Add("quantity", typeof(int));
            table.Columns.Add("cost", typeof(int));
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow lastRow = table.Rows[table.Rows.Count];
            foreach (Product p in GlobalData.list)
            {
                if (p.sl_no == int.Parse(lastRow["Sl no"].ToString()))
                {
                    table.Rows[table.Rows.Count - 1][1] = p.name;
                    table.Rows[table.Rows.Count - 1][2] = p.price;
                    table.Rows[table.Rows.Count - 1][3] = p.quantity;
                    table.Rows[table.Rows.Count - 1][4] = p.quantity*p.price;
                    
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int slno=int.Parse(textBox3.Text);
            int q = int.Parse(textBox4.Text);
            foreach (Product p in GlobalData.list)
            {

                if (slno == p.sl_no)
                {
                    if (p.quantity >= q)
                    {
                        table.Rows.Add(p.sl_no, p.name, p.price, q, p.price * q);
                        total += p.price * q;
                        p.quantity -= q;
                    }
                    else
                    {
                        MessageBox.Show("Avilable Quantity is " + p.quantity);
                        textBox4.Text = " " + p.quantity;
                    }
                    break;
                }
            }
            label6.Text = " " + total;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerBill cb=new CustomerBill();
            cb.name=textBox1.Text;
            cb.phone=textBox2.Text;
            cb.list= new List<Object[]>();
            foreach (DataRow r in table.Rows)
            {
                cb.list.Add(r.ItemArray);
            }
            cb.total=total;
            XmlSerializer s = new XmlSerializer(typeof(CustomerBill));
            TextWriter text = new StreamWriter(cb.phone + ".xml");
            s.Serialize(text,cb);
            this.Close();
        }
    }

    public class CustomerBill
    {
        public List<Object[]> list;
        public string name;
        public string phone;
        public float total;
    }
}
