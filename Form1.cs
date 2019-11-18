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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mustari = new Form2();
            this.Hide();
            mustari.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 admin = new Form4();
            this.Hide();
            admin.Show();
            admin.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 calısan = new Form3();
            this.Hide();
            calısan.Show();
        }
    }
}
