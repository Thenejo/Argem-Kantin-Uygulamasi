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
namespace Kantin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string ad;
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string parola = textBox3.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ULUSAL\Documents\Müşteriler.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Musteri Where kullanıcıadi ='" + ad +"' and parola='"+parola+"'",con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows[0][0].ToString() == "1")
            {
                müsteriekran ekran = new müsteriekran();
                this.Hide();
                ekran.Show();
            }
            else
            {
                MessageBox.Show("Hesabınıza giriş yapılamamaktadır.");
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            this.Hide();
            yeni.Show();
        }
    }
}
