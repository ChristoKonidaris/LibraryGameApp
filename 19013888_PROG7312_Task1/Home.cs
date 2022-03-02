using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19013888_PROG7312_Task1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Replacing_Books rb = new Replacing_Books(); // Instantiate a rb object.
            rb.ShowDialog(); // Show replacing books 
            this.Close(); // closes this instance.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Identifying_Areas ia = new Identifying_Areas(); // Instantiate a ia object.
            ia.ShowDialog(); // Show identifying areas 
            this.Close(); // closes this instance.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindingCallNumbers fcn = new FindingCallNumbers(); // Instantiate a fcn object.
            fcn.ShowDialog(); // Show Finding call numbers
            this.Close(); // closes this instance.
        }
    }
}
