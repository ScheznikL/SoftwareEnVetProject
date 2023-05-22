using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEnVetProject
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sign_up_owner form1 = new sign_up_owner();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sign_up_doctor form1 = new sign_up_doctor();
            form1.Show();
        }
    }
}
