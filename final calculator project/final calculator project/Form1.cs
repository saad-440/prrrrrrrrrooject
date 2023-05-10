using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace final_calculator_project
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\final calculator project\final calculator project\Database1.mdf"";Integrated Security=True");
        int value1;
        int value2;
        double result = 0;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "-";
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(TextBox1.Text);
            label2.Text = TextBox1.Text;
            textBox2.Text = label1.Text + label2.Text;
            if (sign == "+")
            {
                result = value1 + value2;
                TextBox1.Text = Convert.ToString(result);
                txtresult.Text = Convert.ToString(result);
                textBox3.Text = Convert.ToString(result);
            }
            else if (sign == "-")
            {
                result = value1 - value2;
                TextBox1.Text = Convert.ToString(result);
                txtresult.Text = Convert.ToString(result);
                textBox3.Text = Convert.ToString(result);
            }
            else if (sign == "÷")
            {
                result = value1 / value2;
                TextBox1.Text = Convert.ToString(result);
                txtresult.Text = Convert.ToString(result);
                textBox3.Text = Convert.ToString(result);
            }
            else if (sign == "×")
            {
                result = value1 * value2;
                TextBox1.Text = Convert.ToString(result);
                txtresult.Text = Convert.ToString(result);
                textBox3.Text = Convert.ToString(result);

            }
            else if (sign == "%")
            {
                result = value1 % value2;
                TextBox1.Text = Convert.ToString(result);
                txtresult.Text = Convert.ToString(result);
                textBox3.Text = Convert.ToString(result);
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into RecentTable " +
                "values ('" + textBox3.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TextBox1.Text);
            sign = "+";
            label1.Text = TextBox1.Text + sign;
            TextBox1.Text = "";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TextBox1.Text);
            sign = "-";
            label1.Text = TextBox1.Text + sign;
            TextBox1.Text = "";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TextBox1.Text);
            sign = "×";
            label1.Text = TextBox1.Text + sign;
            TextBox1.Text = "";
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TextBox1.Text);
            sign = "÷";
            label1.Text = TextBox1.Text + sign;
            TextBox1.Text = "";
        }

        private void BtC_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        private void BtCE_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            textBox2.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(TextBox1.Text);
            sign = "%";
            label1.Text = TextBox1.Text + sign;
            TextBox1.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from RecentTable ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}