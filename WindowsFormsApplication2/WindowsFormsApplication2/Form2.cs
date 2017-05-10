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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
                try
                {
                    int sl_no = int.Parse(textBox1.Text);

                    foreach (Product p in GlobalData.list)
                    {
                        if (p.sl_no == sl_no)
                        {

                            textBox2.Text = p.name;
                            textBox3.Text = " " + p.quantity;
                            textBox4.Text = " " + p.price;
                            break;
                        }
                    }
                }
                catch(Exception ex)
                {

                }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sl_no = int.Parse(textBox1.Text);
                foreach (Product p in GlobalData.list)
                {
                    if (p.sl_no == sl_no)
                    {
                        p.name = textBox2.Text;
                        p.quantity = int.Parse(textBox3.Text);
                        p.price = float.Parse(textBox4.Text);
                        break;
                        //this.Close();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please insert valid number");
            }
        }
    }
}
