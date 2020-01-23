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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            
            
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            

        }

       
    }
}
