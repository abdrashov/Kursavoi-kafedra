using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursavoi
{
    public partial class login : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zaman\source\repos\Kursavoi\Kursavoi\zzz.mdb");
        public login()
        {
            InitializeComponent();


            textBox1.Text = "Тегінізді жазыныз";
            textBox2.Text = "Есімінізді жазыныз";
            textBox3.Text = "12345678";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin" && textBox3.Text == "admin")
                {
                    this.Hide();
                    admin admin = new admin();
                    admin.ShowDialog();
                }
                else
                {
                    int count = 0;
                    con.Open();
                    OleDbCommand cmdd = con.CreateCommand();
                    cmdd.CommandType = CommandType.Text;
                    cmdd.CommandText = "SELECT * FROM Teacher WHERE тегі='" + textBox1.Text + "' AND аты='" + textBox2.Text + "' AND мұғалімдік_нөмері='" + textBox3.Text + "' ";
                    cmdd.ExecuteNonQuery();
                    DataTable dtt = new DataTable();
                    OleDbDataAdapter daa = new OleDbDataAdapter(cmdd);
                    daa.Fill(dtt);
                    count = Convert.ToInt32(dtt.Rows.Count.ToString());
                    con.Close();

                    if (count != 0)
                    {
                        this.Hide();
                        teacher teacher = new teacher(textBox1.Text, textBox2.Text);
                        teacher.ShowDialog();
                    }
                    else
                    {
                        int countt = 0;
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM Student WHERE тегі='" + textBox1.Text + "' AND аты='" + textBox2.Text + "' AND билет_нөмері='" + textBox3.Text + "' ";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(dt);
                        countt = Convert.ToInt32(dt.Rows.Count.ToString());
                        con.Close();
                        if (countt != 0)
                        {
                            this.Hide();
                            student student = new student(textBox1.Text, textBox2.Text);
                            student.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("ДҚ табылмады");
                            label1.ForeColor = Color.Red;
                            label2.ForeColor = Color.Red;
                            label3.ForeColor = Color.Red;
                           
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Барлық поляны толтырыныз");
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Тегінізді жазыныз")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Тегінізді жазыныз";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Есімінізді жазыныз")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Есімінізді жазыныз";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "12345678")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "12345678";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
