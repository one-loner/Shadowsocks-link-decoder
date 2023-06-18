using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shadowsocks_link_Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            a = a + "#";
            try
            {
                a = a.Replace("ss://", "");

                string[] a1 = a.Split('#');
                string a2 = a1[0];

                string[] a3 = a2.Split('@');
                byte[] bytes = Convert.FromBase64String(a3[0]);
                string decodedString = System.Text.Encoding.UTF8.GetString(bytes);
                string[] crypt = decodedString.Split(':');
                string alg = crypt[0];
                string passw = crypt[1];
                string a4 = a3[1];
                string[] addressport = a4.Split(':');
                string addr = addressport[0];
                string port = addressport[1];
                textBox2.Text = alg;
                textBox3.Text = passw;
                textBox4.Text = addr;
                textBox5.Text = port;
            }
            catch
            {
                MessageBox.Show("Incorrect shadowsocks link.");
            }




        }

   

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This programm decode shadowsocks links. \nGithub repository: github.com/one-loner");
        }

    }
}