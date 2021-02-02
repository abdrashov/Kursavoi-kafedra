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
    public partial class studentOOO : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Zaman\source\repos\Kursavoi\Kursavoi\zzz.mdb");
        public studentOOO(string login, string name)
        {
            InitializeComponent();
            label2.Text += " " + login + " " + name;
            label1.Text = login;
            label6.Text = name;
        }

        private async void studentOOO_Load(object sender, EventArgs e)
        {
            await con.OpenAsync();
            int a = 0, k = 0, aa = 0, kk = 0, aaa = 0, kkk = 0, aaaa = 0, kkkk = 0, aaaaa = 0, kkkkk = 0, aaaaaa = 0, kkkkkk = 0;
            OleDbDataReader oledb = null;
            OleDbCommand com = new OleDbCommand("SELECT * FROM [Ball] WHERE тегі='" + label1.Text + "' AND есімі='" + label6.Text + "' ORDER BY [семестр] ASC", con);
            oledb = com.ExecuteReader();
            while (await oledb.ReadAsync())
            {
                if ( Convert.ToString(oledb["семестр"]) == "1")
                {
                    k++;
                    a += Convert.ToInt32(oledb["кезең_1"]) + Convert.ToInt32(oledb["кезең_2"]) + Convert.ToInt32(oledb["сессия"]);
                }
                if (Convert.ToString(oledb["семестр"]) == "2")
                {
                    kk++;
                    aa += Convert.ToInt32(oledb["кезең_1"]) + Convert.ToInt32(oledb["кезең_2"]) + Convert.ToInt32(oledb["сессия"]);
                }
                if (Convert.ToString(oledb["семестр"]) == "3")
                {
                    kkk++;
                    aaa += Convert.ToInt32(oledb["кезең_1"]) + Convert.ToInt32(oledb["кезең_2"]) + Convert.ToInt32(oledb["сессия"]);
                }
                if (Convert.ToString(oledb["семестр"]) == "4")
                {
                    kkkk++;
                    aaaa += Convert.ToInt32(oledb["кезең_1"]) + Convert.ToInt32(oledb["кезең_2"]) + Convert.ToInt32(oledb["сессия"]);
                }
                if (Convert.ToString(oledb["семестр"]) == "5")
                {
                    kkkkk++;
                    aaaaa += Convert.ToInt32(oledb["кезең_1"]) + Convert.ToInt32(oledb["кезең_2"]) + Convert.ToInt32(oledb["сессия"]);
                }
                if (Convert.ToString(oledb["семестр"]) == "6")
                {
                    kkkkkk++;
                    aaaaaa += Convert.ToInt32(oledb["кезең_1"]) + Convert.ToInt32(oledb["кезең_2"]) + Convert.ToInt32(oledb["сессия"]);
                }
            }

            if (k > 0)
            {
                listBox1.Items.Add("1 семестр");
                listBox2.Items.Add(a / k);
                int g = Convert.ToInt32(a / k);
                if (g >= 95 && g <= 100)
                {
                    string gpa = "4", agp = "A";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 90 && g <= 94)
                {
                    string gpa = "3,67", agp = "A-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 85 && g <= 89)
                {
                    string gpa = "3,33", agp = "B+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 80 && g <= 84)
                {
                    string gpa = "3,0", agp = "B";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 75 && g <= 79)
                {
                    string gpa = "2,67", agp = "B-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 70 && g <= 74)
                {
                    string gpa = "2,33", agp = "C+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 65 && g <= 69)
                {
                    string gpa = "2,0", agp = "C";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 60 && g <= 64)
                {
                    string gpa = "1,67", agp = "C-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 55 && g <= 59)
                {
                    string gpa = "1,33", agp = "D+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 50 && g <= 54)
                {
                    string gpa = "1,0", agp = "D";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 0 && g <= 49)
                {
                    string gpa = "0", agp = "F";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
            }

            if (kk > 0)
            {
                listBox1.Items.Add("2 семестр");
                listBox2.Items.Add(aa / kk);
                int g = Convert.ToInt32(aa / kk);
                if (g >= 95 && g <= 100)
                {
                    string gpa = "4", agp = "A";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 90 && g <= 94)
                {
                    string gpa = "3,67", agp = "A-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 85 && g <= 89)
                {
                    string gpa = "3,33", agp = "B+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 80 && g <= 84)
                {
                    string gpa = "3,0", agp = "B";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 75 && g <= 79)
                {
                    string gpa = "2,67", agp = "B-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 70 && g <= 74)
                {
                    string gpa = "2,33", agp = "C+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 65 && g <= 69)
                {
                    string gpa = "2,0", agp = "C";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 60 && g <= 64)
                {
                    string gpa = "1,67", agp = "C-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 55 && g <= 59)
                {
                    string gpa = "1,33", agp = "D+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 50 && g <= 54)
                {
                    string gpa = "1,0", agp = "D";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 0 && g <= 49)
                {
                    string gpa = "0", agp = "F";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
            }
            if (kkk > 0)
            {
                listBox1.Items.Add("3 семестр");
                listBox2.Items.Add(aaa / kkk);
                int g = Convert.ToInt32(aaa / kkk);
                if (g >= 95 && g <= 100)
                {
                    string gpa = "4", agp = "A";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 90 && g <= 94)
                {
                    string gpa = "3,67", agp = "A-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 85 && g <= 89)
                {
                    string gpa = "3,33", agp = "B+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 80 && g <= 84)
                {
                    string gpa = "3,0", agp = "B";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 75 && g <= 79)
                {
                    string gpa = "2,67", agp = "B-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 70 && g <= 74)
                {
                    string gpa = "2,33", agp = "C+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 65 && g <= 69)
                {
                    string gpa = "2,0", agp = "C";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 60 && g <= 64)
                {
                    string gpa = "1,67", agp = "C-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 55 && g <= 59)
                {
                    string gpa = "1,33", agp = "D+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 50 && g <= 54)
                {
                    string gpa = "1,0", agp = "D";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 0 && g <= 49)
                {
                    string gpa = "0", agp = "F";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
            }
            if (kkkk > 0)
            {
                listBox1.Items.Add("4 семестр");
                listBox2.Items.Add(aaaa / kkkk);
                int g = Convert.ToInt32(aaaa / kkkk);
                if (g >= 95 && g <= 100)
                {
                    string gpa = "4", agp = "A";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 90 && g <= 94)
                {
                    string gpa = "3,67", agp = "A-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 85 && g <= 89)
                {
                    string gpa = "3,33", agp = "B+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 80 && g <= 84)
                {
                    string gpa = "3,0", agp = "B";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 75 && g <= 79)
                {
                    string gpa = "2,67", agp = "B-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 70 && g <= 74)
                {
                    string gpa = "2,33", agp = "C+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 65 && g <= 69)
                {
                    string gpa = "2,0", agp = "C";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 60 && g <= 64)
                {
                    string gpa = "1,67", agp = "C-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 55 && g <= 59)
                {
                    string gpa = "1,33", agp = "D+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 50 && g <= 54)
                {
                    string gpa = "1,0", agp = "D";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 0 && g <= 49)
                {
                    string gpa = "0", agp = "F";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
            }
            if (kkkkk > 0)
            {
                listBox1.Items.Add("5 семестр");
                listBox2.Items.Add(aaaaa / kkkkk);
                int g = Convert.ToInt32(aaaaa / kkkkk);
                if (g >= 95 && g <= 100)
                {
                    string gpa = "4", agp = "A";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 90 && g <= 94)
                {
                    string gpa = "3,67", agp = "A-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 85 && g <= 89)
                {
                    string gpa = "3,33", agp = "B+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 80 && g <= 84)
                {
                    string gpa = "3,0", agp = "B";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 75 && g <= 79)
                {
                    string gpa = "2,67", agp = "B-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 70 && g <= 74)
                {
                    string gpa = "2,33", agp = "C+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 65 && g <= 69)
                {
                    string gpa = "2,0", agp = "C";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 60 && g <= 64)
                {
                    string gpa = "1,67", agp = "C-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 55 && g <= 59)
                {
                    string gpa = "1,33", agp = "D+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 50 && g <= 54)
                {
                    string gpa = "1,0", agp = "D";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 0 && g <= 49)
                {
                    string gpa = "0", agp = "F";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
            }
            if (kkkkkk > 0)
            {
                listBox1.Items.Add("6 семестр");
                listBox2.Items.Add(aaaaaa / kkkkkk);
                int g = Convert.ToInt32(aaaaaa / kkkkkk);
                if (g >= 95 && g <= 100)
                {
                    string gpa = "4", agp = "A";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 90 && g <= 94)
                {
                    string gpa = "3,67", agp = "A-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 85 && g <= 89)
                {
                    string gpa = "3,33", agp = "B+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 80 && g <= 84)
                {
                    string gpa = "3,0", agp = "B";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 75 && g <= 79)
                {
                    string gpa = "2,67", agp = "B-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 70 && g <= 74)
                {
                    string gpa = "2,33", agp = "C+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 65 && g <= 69)
                {
                    string gpa = "2,0", agp = "C";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 60 && g <= 64)
                {
                    string gpa = "1,67", agp = "C-";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 55 && g <= 59)
                {
                    string gpa = "1,33", agp = "D+";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 50 && g <= 54)
                {
                    string gpa = "1,0", agp = "D";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
                if (g >= 0 && g <= 49)
                {
                    string gpa = "0", agp = "F";
                    Convert.ToInt32(listBox3.Items.Add(gpa));
                    Convert.ToDouble(listBox4.Items.Add(agp));
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student student = new student(label1.Text, label6.Text);
            student.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
