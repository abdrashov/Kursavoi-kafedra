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
    public partial class admin : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zaman\source\repos\Kursavoi\Kursavoi\zzz.mdb");
        int count = 0;
        public admin()
        {   
            InitializeComponent();

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            OleDbCommand tee = con.CreateCommand();
            tee.CommandType = CommandType.Text;
            tee.CommandText = "SELECT * FROM Teacher";
            tee.ExecuteNonQuery();
            DataTable td = new DataTable();
            OleDbDataAdapter ta = new OleDbDataAdapter(tee);
            ta.Fill(td);
            dataGridView2.DataSource = td;

            OleDbCommand itt = con.CreateCommand();
            itt.CommandType = CommandType.Text;
            itt.CommandText = "SELECT * FROM Items";
            itt.ExecuteNonQuery();
            DataTable id = new DataTable();
            OleDbDataAdapter ia = new OleDbDataAdapter(itt);
            ia.Fill(id);
            dataGridView3.DataSource = id;

            OleDbCommand ball = con.CreateCommand();
            ball.CommandType = CommandType.Text;
            ball.CommandText = "SELECT * FROM Ball";
            ball.ExecuteNonQuery();
            DataTable bd = new DataTable();
            OleDbDataAdapter ba = new OleDbDataAdapter(ball);
            ba.Fill(bd);
            dataGridView4.DataSource = bd;

            con.Close();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zzzDataSet.Student". При необходимости она может быть перемещена или удалена.


  

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Student WHERE билет_нөмері='" + textBox4.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                con.Close();

                if (count == 0)
                {
                    con.Open();
                    OleDbCommand cmds = con.CreateCommand();
                    cmds.CommandType = CommandType.Text;
                    cmds.CommandText = "INSERT INTO Student VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";
                    cmds.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(textBox3.Text + " " + textBox2.Text + " ДҚ сәтті түрде еңгізілді");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    MessageBox.Show(textBox4.Text + " Студенттік билет нөмері қате");
                }
            }
            else
            {
                if (textBox1.Text == "")
                {
                    label1.ForeColor = Color.Red;
                }
                if (textBox2.Text == "")
                {
                    label2.ForeColor = Color.Red;
                }
                if (textBox3.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                if (textBox4.Text == "")
                {
                    label4.ForeColor = Color.Red;
                }
                if (textBox5.Text == "")
                {
                    label5.ForeColor = Color.Red;
                }
                if (textBox6.Text == "")
                {
                    label6.ForeColor = Color.Red;
                }
                if (textBox7.Text == "")
                {
                    label7.ForeColor = Color.Red;
                }
                MessageBox.Show("Еңгізген мәліметтер қате");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ( textBox8.Text == "" || textBox9.Text == "" || textBox14.Text == "" )
            {
                MessageBox.Show("Мәліметтерді дұрыс еңгізбедініз");
                if (textBox8.Text == "")
                { 
                    label8.ForeColor = Color.Red;
                }
                if (textBox9.Text == "")
                {
                    label9.ForeColor = Color.Red;
                }
                if (textBox14.Text == "")
                {
                    label14.ForeColor = Color.Red;
                }
            }
            else
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Student WHERE тегі='" + textBox8.Text + "' AND аты='" + textBox9.Text + "' AND билет_нөмері='" + textBox14.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                con.Close();

                if (count != 0)
                {
                    con.Open();
                    OleDbCommand cmds = con.CreateCommand();
                    cmds.CommandType = CommandType.Text;
                    cmds.CommandText = "DELETE FROM Student WHERE билет_нөмері='" + textBox14.Text + "'";
                    cmds.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Студент сәтті түрде өшірілді");
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox14.Text = "";
                }
                else
                {
                    MessageBox.Show("Студент табылған жок");
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black;
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Student WHERE тегі='" + textBox10.Text + "' OR аты='" + textBox11.Text + "' OR билет_нөмері='" + textBox13.Text + "' OR жсн='" + textBox12.Text + "' OR тобы='" + textBox15.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            con.Close();

            if (count == 0)
            {
                MessageBox.Show("Студент табылған жок");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "" && textBox21.Text != "" && textBox20.Text != "" && textBox22.Text != "" && textBox31.Text != "" && textBox32.Text != "")
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Teacher WHERE мұғалімдік_нөмері='" + textBox18.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                OleDbDataAdapter ta = new OleDbDataAdapter(cmd);
                ta.Fill(td);
                count = Convert.ToInt32(td.Rows.Count.ToString());
                con.Close();

                if (count == 0)
                {
                    con.Open();
                    OleDbCommand cmds = con.CreateCommand();
                    cmds.CommandType = CommandType.Text;
                    cmds.CommandText = "INSERT INTO Teacher VALUES('" + textBox16.Text + "', '" + textBox17.Text + "', '" + textBox18.Text + "', '" + textBox19.Text + "', '" + textBox21.Text + "', '" + textBox20.Text + "', '" + textBox22.Text + "', '" + textBox31.Text + "', '" + textBox32.Text + "')";
                    cmds.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(textBox3.Text + " " + textBox2.Text + " ДҚ сәтті түрде еңгізілді");
                    textBox16.Text = "";
                    textBox17.Text = "";
                    textBox18.Text = "";
                    textBox19.Text = "";
                    textBox21.Text = "";
                    textBox20.Text = "";
                    textBox22.Text = "";
                    textBox31.Text = "";
                    textBox32.Text = "";
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    MessageBox.Show(textBox18.Text + " Мұғалімдік билет нөмері қате");
                }
            }
            else
            {
                if (textBox16.Text == "")
                {
                    label16.ForeColor = Color.Red;
                }
                if (textBox17.Text == "")
                {
                    label17.ForeColor = Color.Red;
                }
                if (textBox18.Text == "")
                {
                    label19.ForeColor = Color.Red;
                }
                if (textBox19.Text == "")
                {
                    label21.ForeColor = Color.Red;
                }
                if (textBox21.Text == "")
                {
                    label22.ForeColor = Color.Red;
                }
                if (textBox20.Text == "")
                {
                    label20.ForeColor = Color.Red;
                }
                if (textBox22.Text == "")
                {
                    label18.ForeColor = Color.Red;
                }
                if (textBox31.Text == "")
                {
                    label32.ForeColor = Color.Red;
                }
                if (textBox32.Text == "")
                {
                    label31.ForeColor = Color.Red;
                }
                MessageBox.Show("Еңгізген мәліметтер қате");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand tee = con.CreateCommand();
            tee.CommandType = CommandType.Text;
            tee.CommandText = "SELECT * FROM Teacher";
            tee.ExecuteNonQuery();
            DataTable td = new DataTable();
            OleDbDataAdapter ta = new OleDbDataAdapter(tee);
            ta.Fill(td);
            dataGridView2.DataSource = td;
            con.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Black;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Black;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Black;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            label21.ForeColor = Color.Black;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            label22.ForeColor = Color.Black;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            label20.ForeColor = Color.Black;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Black;
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            label32.ForeColor = Color.Black;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            label31.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox23.Text == "" || textBox24.Text == "" || textBox25.Text == "")
            {
                MessageBox.Show("Мәліметтерді дұрыс еңгізбедініз");
                if (textBox23.Text == "")
                {
                    label23.ForeColor = Color.Red;
                }
                if (textBox24.Text == "")
                {
                    label24.ForeColor = Color.Red;
                }
                if (textBox25.Text == "")
                {
                    label25.ForeColor = Color.Red;
                }
            }
            else
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Teacher WHERE тегі='" + textBox23.Text + "' AND аты='" + textBox24.Text + "' AND мұғалімдік_нөмері='" + textBox25.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                OleDbDataAdapter ta = new OleDbDataAdapter(cmd);
                ta.Fill(td);
                count = Convert.ToInt32(td.Rows.Count.ToString());
                con.Close();

                if (count != 0)
                {
                    con.Open();
                    OleDbCommand cmds = con.CreateCommand();
                    cmds.CommandType = CommandType.Text;
                    cmds.CommandText = "DELETE FROM Teacher WHERE мұғалімдік_нөмері='" + textBox25.Text + "'";
                    cmds.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Мұғалім сәтті түрде өшірілді");
                    textBox23.Text = "";
                    textBox24.Text = "";
                    textBox25.Text = "";
                }
                else
                {
                    MessageBox.Show("Мұғалім табылған жок");
                }
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            label24.ForeColor = Color.Black;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            label23.ForeColor = Color.Black;
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            label25.ForeColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Teacher WHERE тегі='" + textBox28.Text + "' OR аты='" + textBox29.Text + "' OR мұғалімдік_нөмері='" + textBox30.Text + "' OR қызметі='" + textBox27.Text + "' OR стаж='" + textBox26.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable td = new DataTable();
            OleDbDataAdapter ta = new OleDbDataAdapter(cmd);
            ta.Fill(td);
            count = Convert.ToInt32(td.Rows.Count.ToString());
            dataGridView2.DataSource = td;
           

            if (count == 0)
            {
                MessageBox.Show("Мұғалім табылған жок");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox35.Text != "" && textBox36.Text != "" && textBox37.Text != "" && textBox38.Text != "" && textBox40.Text != "" && textBox43.Text != "")
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Items WHERE пан_коды='" + textBox35.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable id = new DataTable();
                OleDbDataAdapter ia = new OleDbDataAdapter(cmd);
                ia.Fill(id);
                count = Convert.ToInt32(id.Rows.Count.ToString());
                con.Close();

                if (count == 0)
                {
                    con.Open();
                    OleDbCommand cmds = con.CreateCommand();
                    cmds.CommandType = CommandType.Text;
                    cmds.CommandText = "INSERT INTO Items VALUES('" + textBox35.Text + "', '" + textBox36.Text + "', '" + textBox37.Text + "', '" + textBox38.Text + "', '" + textBox40.Text + "', '" + textBox43.Text + "' )";
                    cmds.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(textBox35.Text + " " + textBox36.Text + " ДҚ сәтті түрде еңгізілді");
                    textBox35.Text = "";
                    textBox36.Text = "";
                    textBox37.Text = "";
                    textBox38.Text = "";
                    textBox40.Text = "";
                }
                else
                {
                    label35.ForeColor = Color.Red;
                    MessageBox.Show(textBox35.Text + " пән коды дұрыс енгізілмеді");
                }
            }
            else
            {
                if (textBox35.Text == "")
                {
                    label35.ForeColor = Color.Red;
                }
                if (textBox36.Text == "")
                {
                    label36.ForeColor = Color.Red;
                }
                if (textBox37.Text == "")
                {
                    label38.ForeColor = Color.Red;
                }
                if (textBox38.Text == "")
                {
                    label40.ForeColor = Color.Red;
                }
                if (textBox40.Text == "")
                {
                    label41.ForeColor = Color.Red;
                }
               
                MessageBox.Show("Еңгізген мәліметтер қате");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand itt = con.CreateCommand();
            itt.CommandType = CommandType.Text;
            itt.CommandText = "SELECT * FROM Items";
            itt.ExecuteNonQuery();
            DataTable id = new DataTable();
            OleDbDataAdapter ia = new OleDbDataAdapter(itt);
            ia.Fill(id);
            dataGridView3.DataSource = id;
            con.Close();
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            label35.ForeColor = Color.Black;
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            label36.ForeColor = Color.Black;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            label38.ForeColor = Color.Black;
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            label40.ForeColor = Color.Black;
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            label41.ForeColor = Color.Black;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            OleDbCommand cmds = con.CreateCommand();
            cmds.CommandType = CommandType.Text;
            cmds.CommandText = "SELECT * FROM Items WHERE пан_коды='" + textBox39.Text + "' OR пан_коды='" + textBox34.Text + "' OR пан_коды='" + textBox46.Text + "'";
            cmds.ExecuteNonQuery();
            DataTable id = new DataTable();
            OleDbDataAdapter ia = new OleDbDataAdapter(cmds);
            ia.Fill(id);
            count = Convert.ToInt32(id.Rows.Count.ToString());
            con.Close();

            if (count != 0)
            { 
                if ( textBox39.Text != "" && textBox33.Text != "")
                { 
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Items SET кредит_санны='" + textBox33.Text + "' WHERE пан_коды = '" + textBox39.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Кредит саны " + textBox33.Text + " өзгертілді");
                    textBox33.Text = "";
                    textBox39.Text = "";
                }
                if (textBox34.Text != "" && textBox41.Text != "")
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Items SET тестлеу_түрі='" + textBox41.Text + "' WHERE пан_коды='" + textBox34.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Тестілеу түрі " + textBox41.Text + " өзгертілді");
                    textBox41.Text = "";
                    textBox34.Text = "";
                }
                if (textBox46.Text != "" && textBox45.Text != "" && textBox44.Text != "")
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Items SET тегі='" + textBox45.Text + "', аты='" + textBox44.Text + "' WHERE пан_коды='" + textBox46.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Меңгеруші " + textBox45.Text + " " + textBox44.Text + " өзгертілді");
                    textBox44.Text = "";
                    textBox45.Text = "";
                    textBox46.Text = "";
                }
                else
                {
                    MessageBox.Show("Еңгізілген мәліметтер қате");
                }
            }
            else
            {
                MessageBox.Show("Еңгізілген мәліметтер қате");
            }

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox42.Text == "")
            {
                MessageBox.Show("Мәліметтерді дұрыс еңгізбедініз");
                label42.ForeColor = Color.Red;
            }
            else
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Items WHERE пан_коды='" + textBox42.Text + "'  ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                con.Close();

                if (count != 0)
                {
                    con.Open();
                    OleDbCommand cmds = con.CreateCommand();
                    cmds.CommandType = CommandType.Text;
                    cmds.CommandText = "DELETE FROM Items WHERE пан_коды='" + textBox42.Text + "'";
                    cmds.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Пән сәтті түрде өшірілді");
                    label42.ForeColor = Color.Black;
                    textBox42.Text = "";
                }
                else
                {
                    MessageBox.Show("Пән табылған жок");
                    label42.ForeColor = Color.Red;
                }
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            label42.ForeColor = Color.Black;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand ball = con.CreateCommand();
            ball.CommandType = CommandType.Text;
            ball.CommandText = "SELECT * FROM Ball";
            ball.ExecuteNonQuery();
            DataTable bd = new DataTable();
            OleDbDataAdapter ba = new OleDbDataAdapter(ball);
            ba.Fill(bd);
            dataGridView4.DataSource = bd;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
