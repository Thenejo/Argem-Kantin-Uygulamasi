using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace Kantin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Admin siteS
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public static bool n = false;
        private void button5_Click(object sender, EventArgs e)
        {
           if(textBox4.Text=="Nejat" && textBox3.Text == "Nu123456")
            {
                Form7 yeni = new Form7();
                yeni.Show();
                this.Hide();
            }
                
           
            else
            {
                MessageBox.Show("Hesabınıza giriş yapılamamaktadır.");
            }
            
        
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
