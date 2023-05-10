using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace final_university_application
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\final university application\final university application\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            panelmain1.Visible = false;

        }

        private void btnform_Click(object sender, EventArgs e)
        {
            panelmain1.Visible = true;
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

        private void pictureBoxmain_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = txtfname.Text + " " + txtlname.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into studends_info " +
                "values('" + textBox1.Text + "' , '" + cboxgender.Text + "' , '" + txtdatebirth.Text + "' , " + txtphone.Text + " , '" + txtemail.Text + "' , '" + txtaddress.Text + "' , '" + cboxcity.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtfname.Text = "";
            txtlname.Text = "";
            txtemail.Text = "";
            txtdatebirth.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";
            cboxcity.Text = "";

            MessageBox.Show("Welcom to KFR University " +textBox1.Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from studends_info", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from studends_info where name = '" + txtnamesearch.Text + "' ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            /*
            SqlDataAdapter da = new SqlDataAdapter("select * from studends_info where phone_number = " + txtemailsearch.Text + "  ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close(); ;
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}