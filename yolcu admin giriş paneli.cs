using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yolcubiletotomasyon
{
    public partial class yolcu_admin_giriş_paneli : Form
    {
        public yolcu_admin_giriş_paneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin"&&textBox2.Text=="12345")
            {
                Form1 yeni = new Form1();
                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz");  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Kullanıcı adı =admin Şifre=12345";
        }
    }
}
