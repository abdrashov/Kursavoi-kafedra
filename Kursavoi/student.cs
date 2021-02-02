using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Kursavoi
{
    public partial class student : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zaman\source\repos\Kursavoi\Kursavoi\zzz.mdb");
        public student(string login, string name)
        {
            InitializeComponent();
            label8.Text += " " + login + " " + name;
            label9.Text = login;
            label10.Text = name;
        }
        private async void student_Load(object sender, EventArgs e)
        {
            await con.OpenAsync();

            OleDbDataReader oledb = null;
            OleDbCommand com = new OleDbCommand("SELECT * FROM [Ball] WHERE тегі='" + label9.Text + "' AND есімі='" + label10.Text + "' ORDER BY [семестр] ASC", con);
            oledb = com.ExecuteReader();
            while (await oledb.ReadAsync())
            {
                listBox7.Items.Add(Convert.ToInt32(oledb["семестр"]) + " семестр");
                listBox1.Items.Add(Convert.ToInt32(oledb["кезең_1"]));
                listBox2.Items.Add(Convert.ToInt32(oledb["кезең_2"]));
                listBox3.Items.Add(Convert.ToString(oledb["сессия"]));
                listBox5.Items.Add(Convert.ToString(oledb["пән"]));
                listBox4.Items.Add(Convert.ToInt32(oledb["кезең_1"]) + Convert.ToInt32(oledb["кезең_2"]) + Convert.ToInt32(oledb["сессия"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            studentOOO studentOO = new studentOOO(label9.Text, label10.Text);
            studentOO.ShowDialog();
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
