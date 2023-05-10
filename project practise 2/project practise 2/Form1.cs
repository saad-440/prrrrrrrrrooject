using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project_practise_2
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\project practise 2\project practise 2\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btshow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from StdLogin ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into StdLogin " +
                "values (" + textID.Text + ", '" + textname.Text + "' , " + textdegree.Text + " )", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("update StdLogin set Name = '" + textname.Text + "' , Degree = " + textdegree.Text + "  where ID = " + textID.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM StdLogin WHERE ID = " + textID.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}