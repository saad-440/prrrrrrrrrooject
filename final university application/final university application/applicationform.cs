using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_university_application
{
    public partial class applicationform : Form
    {
        public applicationform()
        {
            InitializeComponent();
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            if (txtphone.Text == "(000) 000-000")
            {
                txtphone.Text = "";
                txtphone.ForeColor = Color.Black;
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Text = "(000) 000-000";
                txtphone.ForeColor = Color.Silver;
            }
        }

        private void txtdatebirth_Enter(object sender, EventArgs e)
        {
            if (txtdatebirth.Text == "MM-DD-YYYY")
            {
                txtdatebirth.Text = "";
                txtdatebirth.ForeColor = Color.Black;
            }
        }

        private void txtdatebirth_Leave(object sender, EventArgs e)
        {
            if (txtdatebirth.Text == "")
            {
                txtdatebirth.Text = "MM-DD-YYYY";
                txtdatebirth.ForeColor = Color.Silver;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "@gmail.com")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "@gmail.com";
                txtemail.ForeColor = Color.Silver;
            }
        }

    }
}
