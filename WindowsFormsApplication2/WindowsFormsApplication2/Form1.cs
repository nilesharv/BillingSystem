using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.MdiParent = this;
            f.Show();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.MdiParent = this;
            f.Show();
        }

        private void saleItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer s = new XmlSerializer(typeof(List<Product>));
            TextReader text = new StreamReader(@"save.xml");
            GlobalData.list = (List<Product>) s.Deserialize(text);
            text.Close();
            
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            XmlSerializer s = new XmlSerializer(typeof(List<Product>));
            TextWriter text = new StreamWriter(@"save.xml");
            s.Serialize(text,GlobalData.list);
            text.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }


    }
}
