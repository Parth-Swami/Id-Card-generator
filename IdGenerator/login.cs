using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IdGenerator
{
    public partial class Form1 : Form
    {
        String user = "admin";
        String pass = "admin";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(25, Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user == textBox1.Text && pass == textBox2.Text)
            {
                MainMenu m = new MainMenu();
                m.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
