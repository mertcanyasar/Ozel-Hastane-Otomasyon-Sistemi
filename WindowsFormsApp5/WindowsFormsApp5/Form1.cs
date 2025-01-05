using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()

        {

            InitializeComponent();

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici Adini Veya Sifreyi Yanlis Girdiniz");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
      

        private void move(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Substring(1) + textBox3.Text.Substring(0, 1);

        }

        private void time(object sender, EventArgs e)
        {
            saatLabel.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();

            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
            

        }

       
    }
}
