using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantin
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label5.Text = Form2.ad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            müsteriekran yeni = new müsteriekran();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
