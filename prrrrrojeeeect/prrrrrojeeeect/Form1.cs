using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prrrrrojeeeect
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\prrrrrojeeeect\prrrrrojeeeect\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Happy to see you again " + txtemail.Text);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SingUPpanel.Visible = true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void BtLogInLocSIngUP_Click(object sender, EventArgs e)
        {
            SingUPpanel.Visible = false;
            dataGridView1.Visible = false;
            GridviewPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingUPpanel.Visible = false;
            dataGridView1.Visible = true;
            GridviewPanel.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            SingUPpanel.Visible = true;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            SingUPpanel.Visible = false;
            dataGridView1.Visible = false;
            GridviewPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingUPpanel.Visible = false;
            dataGridView1.Visible = true;
            GridviewPanel.Visible = true;
        }

        private void SingUPpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SingUPpanel.Visible = false;
            dataGridView1.Visible = true;
            GridviewPanel.Visible = true;
        }

        private void BtSingupLocSingUP_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into SingUp " +
                " values ('" + txtUsernameSIngUp.Text + "' ,  '" + txtEmailSingUp.Text + "' , '" + txtPasswordSingUp.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("welcome " + txtUsernameSIngUp.Text);
        }

        private void BtShowData_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from SingUp ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}