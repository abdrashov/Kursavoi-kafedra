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
using System.Data.SqlClient;

namespace Kursavoi
{
    public partial class teacher : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zaman\source\repos\Kursavoi\Kursavoi\zzz.mdb");
       
        public teacher(string login, string name)
        {
            InitializeComponent();
            label24.Text = "Қош келдініз " + login + " ";
            label24.Text += name;
            label25.Text = login;
            label26.Text = name;
            }
        private async void teacher_Load(object sender, EventArgs e)
        {
            await con.OpenAsync();

            OleDbDataReader oledb = null;

            OleDbCommand com = new OleDbCommand("SELECT * FROM [Lesson]", con);
            oledb = com.ExecuteReader();
            while (await oledb.ReadAsync())
            {
                comboBox1.Items.Add(Convert.ToString(oledb["тоб"]));
            }

            OleDbDataReader oled = null;

            OleDbCommand co = new OleDbCommand("SELECT * FROM [Items] WHERE тегі='"+ label25.Text + "' AND аты='" + label26.Text + "'", con);
            oled = co.ExecuteReader();
            while (await oled.ReadAsync())
            {
                comboBox3.Items.Add(Convert.ToString(oled["атауы"]));
            }
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            int a8 = Convert.ToInt32(numericUpDown8.Value);
            int a9 = Convert.ToInt32(numericUpDown9.Value);
            int a10 = Convert.ToInt32(numericUpDown10.Value);
            int a11 = Convert.ToInt32(numericUpDown11.Value);
            int a12 = Convert.ToInt32(numericUpDown12.Value);
            int a13 = Convert.ToInt32(numericUpDown13.Value);
            int a14 = Convert.ToInt32(numericUpDown14.Value);

            int count = 0;

                if (a8 == 0 && a9 == 0 && a10 == 0 && a11 == 0 && a12 == 0 && a13 == 0 && a14 == 0)
                {
                    if (comboBox1.Text == "")
                    { label15.ForeColor = Color.Red; }
                    if (comboBox2.Text == "")
                    { label18.ForeColor = Color.Red; }
                    if (comboBox3.Text == "")
                    { label20.ForeColor = Color.Red; }
                    if (comboBox4.Text == "")
                    { label19.ForeColor = Color.Red; }
                    if (comboBox5.Text == "")
                    { label23.ForeColor = Color.Red; }
                }
                else
                {
                    if (comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && comboBox4.Text == "" && comboBox5.Text == "")
                    {
                        if (comboBox1.Text == "")
                        { label15.ForeColor = Color.Red; }
                        if (comboBox2.Text == "")
                        { label18.ForeColor = Color.Red; }
                        if (comboBox3.Text == "")
                        { label20.ForeColor = Color.Red; }
                        if (comboBox4.Text == "")
                        { label19.ForeColor = Color.Red; }
                        if (comboBox5.Text == "")
                        { label23.ForeColor = Color.Red; }
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmdd = con.CreateCommand();
                        cmdd.CommandType = CommandType.Text;
                        cmdd.CommandText = "SELECT * FROM Ball WHERE тегі='" + comboBox4.Text + "' AND есімі='" + comboBox5.Text + "' AND пән='" + comboBox3.Text + "' AND семестр='"+ comboBox2.Text + "'";
                        cmdd.ExecuteNonQuery();
                        DataTable id = new DataTable();
                        OleDbDataAdapter ia = new OleDbDataAdapter(cmdd);
                        ia.Fill(id);
                        count = Convert.ToInt32(id.Rows.Count.ToString());
                        con.Close();

                        if (count != 0)
                        { 
                            double c = (((a8 + a9 + a10 + a11 + a12 + a13 + a14) / 7) * 0.3);
                            int x = Convert.ToInt32(c);
                            label22.Text = "2 кезең орт. балл " + c;

                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE Ball SET  кезең_2='" + x + "' WHERE тегі='" + comboBox4.Text + "' AND есімі='" + comboBox5.Text + "' AND пән='" + comboBox3.Text + "' AND семестр='" + comboBox2.Text + "' ";
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Cәтті түрде қойылды");
                        }
                        else
                        {
                            MessageBox.Show("Студент 1 кезеннең табылмады");
                        }
                    }
        

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Black;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label20.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }



        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            int a1 = Convert.ToInt32(numericUpDown1.Value);
            int a2 = Convert.ToInt32(numericUpDown2.Value);
            int a3 = Convert.ToInt32(numericUpDown3.Value);
            int a4 = Convert.ToInt32(numericUpDown4.Value);
            int a5 = Convert.ToInt32(numericUpDown5.Value);
            int a6 = Convert.ToInt32(numericUpDown6.Value);
            int a7 = Convert.ToInt32(numericUpDown7.Value);


            if (a1 == 0 && a2 == 0 && a3 == 0 && a4 == 0 && a5 == 0 && a6 == 0 && a7 == 0)
            {
                if (comboBox1.Text == "")
                { label15.ForeColor = Color.Red; }
                if (comboBox2.Text == "")
                { label18.ForeColor = Color.Red; }
                if (comboBox3.Text == "")
                { label20.ForeColor = Color.Red; }
                if (comboBox4.Text == "")
                { label19.ForeColor = Color.Red; }
                if (comboBox5.Text == "")
                { label23.ForeColor = Color.Red; }
            }
            else
            {
                if (comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && comboBox4.Text == "" && comboBox5.Text == "")
                {
                    if (comboBox1.Text == "")
                    { label15.ForeColor = Color.Red; }
                    if (comboBox2.Text == "")
                    { label18.ForeColor = Color.Red; }
                    if (comboBox3.Text == "")
                    { label20.ForeColor = Color.Red; }
                    if (comboBox4.Text == "")
                    { label19.ForeColor = Color.Red; }
                    if (comboBox5.Text == "")
                    { label23.ForeColor = Color.Red; }
                }
                else
                {
                    con.Open();
                    OleDbCommand cmdd = con.CreateCommand();
                    cmdd.CommandType = CommandType.Text;
                    cmdd.CommandText = "SELECT * FROM Ball WHERE тегі='" + comboBox4.Text + "' AND есімі='" + comboBox5.Text + "' AND пән='" + comboBox3.Text + "' AND семестр='" + comboBox2.Text + "'";
                    cmdd.ExecuteNonQuery();
                    DataTable id = new DataTable();
                    OleDbDataAdapter ia = new OleDbDataAdapter(cmdd);
                    ia.Fill(id);
                    count = Convert.ToInt32(id.Rows.Count.ToString());
                    con.Close();

                    if (count == 0)
                    {

                        double c = (((a1 + a2 + a3 + a4 + a5 + a6 + a7) / 7) * 0.3);
                        int x = Convert.ToInt32(c);
                        label21.Text = "1 кезең орт. балл " + c;
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = (@"INSERT INTO Ball (тегі, есімі, пән, кезең_1, семестр, сессия) VALUES('" + comboBox4.Text + "', '" + comboBox5.Text + "', '" + comboBox3.Text + "', '" + x + "', '" + comboBox2.Text + "', '" + (10+x) + "')");
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Cәтті түрде қойылды");
                    }
                    else
                    {
                        MessageBox.Show(comboBox4.Text + " " + comboBox5.Text + " студентіні баға қойылып қойған");
                    }

                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void comboBox4_Enter(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Black;
            if (comboBox1.Text != "")
            {
                await con.OpenAsync();
                comboBox4.Items.Clear();
                OleDbDataReader oledbs = null;

                OleDbCommand comm = new OleDbCommand("SELECT * FROM [Student] WHERE тобы = '" + comboBox1.Text + "'", con);
                oledbs = comm.ExecuteReader();
                while (await oledbs.ReadAsync())
                {
                    comboBox4.Items.Add(Convert.ToString(oledbs["тегі"]));
                }
                con.Close();
            }
        }

        private async void comboBox5_Enter(object sender, EventArgs e)
        {
            label23.ForeColor = Color.Black;
            if (comboBox4.Text != "")
            {
                await con.OpenAsync();
                comboBox5.Items.Clear();
                OleDbDataReader oledbs = null;

                OleDbCommand comm = new OleDbCommand("SELECT * FROM [Student] WHERE тегі = '" + comboBox4.Text + "'", con);
                oledbs = comm.ExecuteReader();
                while (await oledbs.ReadAsync())
                {
                    comboBox5.Items.Add(Convert.ToString(oledbs["аты"]));
                }
                con.Close();
            }
        }

        private void itemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_Enter(object sender, EventArgs e)
        {
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
