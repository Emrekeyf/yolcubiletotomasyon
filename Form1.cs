using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yolcubiletotomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seferno = 0;
        SqlConnection baglan = new SqlConnection("Data source=DESKTOP-8TO73FG\\SQLEXPRESS;Initial Catalog= yolcukayıt;Integrated security=true;");
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";





        }
        private void verilerigöster()
        {
            baglan.Open();
            listView1.Items.Clear();

            SqlCommand komut = new SqlCommand("Select * from yolcukayıt", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["seferno"].ToString();
                ekle.SubItems.Add(oku["tarih"].ToString());
                ekle.SubItems.Add(oku["saat"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["koltukno"].ToString());
                ekle.SubItems.Add(oku["ücret"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["biniş"].ToString());

                listView1.Items.Add(ekle);





            }
            baglan.Close();
        }
           



            
            
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("insert into yolcukayıt(seferno,tarih,saat,adsoyad,telefon,koltukno,ücret,cinsiyet,biniş) values('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
            temizle();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "1";
            button6.Enabled = false;
            button6.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text = "2";
            button7.Enabled = false;
            button7.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "3";
            button8.Enabled = false;
            button8.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.Text = "4";
            button9.Enabled = false;
            button9.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "5";
            button10.Enabled = false;
            button10.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox6.Text = "6";
            button11.Enabled = false;
            button11.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox6.Text = "7";
            button12.Enabled = false;
            button12.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand(" Delete From yolcukayıt where seferno=(" + seferno+ ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            seferno = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;

            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;

            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;

            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;

            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;

            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;

            comboBox1.Text = listView1.SelectedItems[0].SubItems[7].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[8].Text;





        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  yolcukayıt set seferno='" + textBox1.Text.ToString() + "',tarih= '" + textBox2.Text.ToString() + "',saat='" + textBox3.Text.ToString() + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',koltukno='" + textBox6.Text.ToString() + "',ücret='" + textBox7.Text.ToString() + "',cinsiyet='" + comboBox1.Text.ToString() + "',biniş='" + comboBox2.Text.ToString() + "' where seferno=" + seferno + "", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand(" Delete From yolcukayıt where adsoyad='" + textBox8.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
        }

    }
}
