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

namespace QuizGenerator
{
    public partial class english : Form
    {
        public english()
        {
            InitializeComponent();
            Random();
            quizGenerate();
        }

        private void english_Load(object sender, EventArgs e)
        {

        }



        int[] numbers = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        public void Random()
        {
            var counter = 0;

            do
            {
                Random random = new Random();
                var randomNumber = random.Next(1, 30);
                if (Array.IndexOf(numbers, randomNumber) == -1)
                {
                    numbers[counter] = randomNumber;
                    counter++;
                }
            } while (counter < 8);

            for (var i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + ",");
            }


        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\quiz\QuizGenerator.accdb");
        public void quizGenerate()
        {

            for (int i = 0; i < 8; i++)
            {
                string query = "select * from english where ID=" + numbers[i].ToString() + " ";
                OleDbCommand cmd = new OleDbCommand(query, con);

                DataTable dt = new DataTable();
                con.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    switch (i)
                    {
                        case 0: Question1.Text = rdr[1].ToString(); Q1C1.Text = rdr[2].ToString(); Q1C2.Text = rdr[3].ToString(); Q1C3.Text = rdr[4].ToString(); Q1C4.Text = rdr[5].ToString(); break;
                        case 1: Question2.Text = rdr[1].ToString(); Q2C1.Text = rdr[2].ToString(); Q2C2.Text = rdr[3].ToString(); Q2C3.Text = rdr[4].ToString(); Q2C4.Text = rdr[5].ToString(); break;
                        case 2: Question3.Text = rdr[1].ToString(); Q3C1.Text = rdr[2].ToString(); Q3C2.Text = rdr[3].ToString(); Q3C3.Text = rdr[4].ToString(); Q3C4.Text = rdr[5].ToString(); break;
                        case 3: Question4.Text = rdr[1].ToString(); Q4C1.Text = rdr[2].ToString(); Q4C2.Text = rdr[3].ToString(); Q4C3.Text = rdr[4].ToString(); Q4C4.Text = rdr[5].ToString(); break;
                        case 4: Question5.Text = rdr[1].ToString(); Q5C1.Text = rdr[2].ToString(); Q5C2.Text = rdr[3].ToString(); Q5C3.Text = rdr[4].ToString(); Q5C4.Text = rdr[5].ToString(); break;
                        case 5: Question6.Text = rdr[1].ToString(); Q6C1.Text = rdr[2].ToString(); Q6C2.Text = rdr[3].ToString(); Q6C3.Text = rdr[4].ToString(); Q6C4.Text = rdr[5].ToString(); break;
                        case 6: Question7.Text = rdr[1].ToString(); Q7C1.Text = rdr[2].ToString(); Q7C2.Text = rdr[3].ToString(); Q7C3.Text = rdr[4].ToString(); Q7C4.Text = rdr[5].ToString(); break;
                        case 7: Question8.Text = rdr[1].ToString(); Q8C1.Text = rdr[2].ToString(); Q8C2.Text = rdr[3].ToString(); Q8C3.Text = rdr[4].ToString(); Q8C4.Text = rdr[5].ToString(); break;
                    }



                }
                con.Close();
                rdr.Close();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            int correct = 0;
            for (int i = 0; i < 8; i++)
            {
                string query = "select * from english where ID=" + numbers[i].ToString() + " ";
                OleDbCommand cmd = new OleDbCommand(query, con);

                DataTable dt = new DataTable();
                con.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (i == 0)
                    {
                        Q1Correct.Text = rdr[6].ToString(); Q1Correct.Visible = true;
                        if (Q1C1.Checked == true && Q1C1.Text == rdr[6].ToString())
                        {
                            Q1C1.ForeColor = Color.Green;
                            correct++;
                        }
                        else if (Q1C1.Checked == true && Q1C1.Text != rdr[6].ToString())
                        {
                            Q1C1.ForeColor = Color.Red;
                        }

                        else if (Q1C2.Checked == true && Q1C2.Text == rdr[6].ToString())
                        {
                            Q1C2.ForeColor = Color.Green;
                            correct++;
                        }
                        else if (Q1C2.Checked == true && Q1C2.Text != rdr[6].ToString())
                        {
                            Q1C2.ForeColor = Color.Red;
                        }

                        else if (Q1C3.Checked == true && Q1C3.Text == rdr[6].ToString())
                        {
                            Q1C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q1C3.Checked == true && Q1C3.Text != rdr[6].ToString())
                        {
                            Q1C3.ForeColor = Color.Red;
                        }

                        else if (Q1C4.Checked == true && Q1C4.Text == rdr[6].ToString())
                        {
                            Q1C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q1C4.Checked == true && Q1C4.Text != rdr[6].ToString())
                        {
                            Q1C4.ForeColor = Color.Red;
                        }
                    }


                    if (i == 1)
                    {

                        Q2Correct.Text = rdr[6].ToString(); Q2Correct.Visible = true;

                        if (Q2C1.Checked == true && Q2C1.Text == rdr[6].ToString())
                        {
                            Q2C1.ForeColor = Color.Green; correct++;
                        }
                        else if (Q2C1.Checked == true && Q2C1.Text != rdr[6].ToString())
                        {
                            Q2C1.ForeColor = Color.Red;
                        }

                        else if (Q2C2.Checked == true && Q2C2.Text == rdr[6].ToString())
                        {
                            Q2C2.ForeColor = Color.Green; correct++;
                        }
                        else if (Q2C2.Checked == true && Q2C2.Text != rdr[6].ToString())
                        {
                            Q2C2.ForeColor = Color.Red;
                        }

                        else if (Q2C3.Checked == true && Q2C3.Text == rdr[6].ToString())
                        {
                            Q2C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q2C3.Checked == true && Q2C3.Text != rdr[6].ToString())
                        {
                            Q2C3.ForeColor = Color.Red;
                        }

                        else if (Q2C4.Checked == true && Q2C4.Text == rdr[6].ToString())
                        {
                            Q2C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q2C4.Checked == true && Q2C4.Text != rdr[6].ToString())
                        {
                            Q2C4.ForeColor = Color.Red;
                        }

                    }


                    if (i == 2)
                    {

                        Q3Correct.Text = rdr[6].ToString(); Q3Correct.Visible = true;

                        if (Q3C1.Checked == true && Q3C1.Text == rdr[6].ToString())
                        {
                            Q3C1.ForeColor = Color.Green; correct++;
                        }
                        else if (Q3C1.Checked == true && Q3C1.Text != rdr[6].ToString())
                        {
                            Q3C1.ForeColor = Color.Red;
                        }

                        else if (Q3C2.Checked == true && Q3C2.Text == rdr[6].ToString())
                        {
                            Q3C2.ForeColor = Color.Green; correct++;
                        }
                        else if (Q3C2.Checked == true && Q3C2.Text != rdr[6].ToString())
                        {
                            Q3C2.ForeColor = Color.Red;
                        }

                        else if (Q3C3.Checked == true && Q3C3.Text == rdr[6].ToString())
                        {
                            Q3C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q3C3.Checked == true && Q3C3.Text != rdr[6].ToString())
                        {
                            Q3C3.ForeColor = Color.Red;
                        }

                        else if (Q3C4.Checked == true && Q3C4.Text == rdr[6].ToString())
                        {
                            Q3C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q3C4.Checked == true && Q3C4.Text != rdr[6].ToString())
                        {
                            Q3C4.ForeColor = Color.Red;
                        }


                    }

                    if (i == 3)
                    {

                        Q4Correct.Text = rdr[6].ToString(); Q4Correct.Visible = true;

                        if (Q4C1.Checked == true && Q4C1.Text == rdr[6].ToString())
                        {
                            Q4C1.ForeColor = Color.Green; correct++;
                        }
                        else if (Q4C1.Checked == true && Q4C1.Text != rdr[6].ToString())
                        {
                            Q4C1.ForeColor = Color.Red;
                        }

                        else if (Q4C2.Checked == true && Q4C2.Text == rdr[6].ToString())
                        {
                            Q4C2.ForeColor = Color.Green; correct++;
                        }
                        else if (Q4C2.Checked == true && Q4C2.Text != rdr[6].ToString())
                        {
                            Q4C2.ForeColor = Color.Red;
                        }

                        else if (Q4C3.Checked == true && Q4C3.Text == rdr[6].ToString())
                        {
                            Q4C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q4C3.Checked == true && Q4C3.Text != rdr[6].ToString())
                        {
                            Q4C3.ForeColor = Color.Red;
                        }

                        else if (Q4C4.Checked == true && Q4C4.Text == rdr[6].ToString())
                        {
                            Q4C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q4C4.Checked == true && Q4C4.Text != rdr[6].ToString())
                        {
                            Q4C4.ForeColor = Color.Red;
                        }


                    }

                    if (i == 4)
                    {

                        Q5Correct.Text = rdr[6].ToString(); Q5Correct.Visible = true;

                        if (Q5C1.Checked == true && Q5C1.Text == rdr[6].ToString())
                        {
                            Q5C1.ForeColor = Color.Green; correct++;
                        }
                        else if (Q5C1.Checked == true && Q5C1.Text != rdr[6].ToString())
                        {
                            Q5C1.ForeColor = Color.Red;
                        }

                        else if (Q5C2.Checked == true && Q5C2.Text == rdr[6].ToString())
                        {
                            Q5C2.ForeColor = Color.Green; correct++;
                        }
                        else if (Q5C2.Checked == true && Q5C2.Text != rdr[6].ToString())
                        {
                            Q5C2.ForeColor = Color.Red;
                        }

                        else if (Q5C3.Checked == true && Q5C3.Text == rdr[6].ToString())
                        {
                            Q5C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q5C3.Checked == true && Q5C3.Text != rdr[6].ToString())
                        {
                            Q5C3.ForeColor = Color.Red;
                        }

                        else if (Q5C4.Checked == true && Q5C4.Text == rdr[6].ToString())
                        {
                            Q5C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q5C4.Checked == true && Q5C4.Text != rdr[6].ToString())
                        {
                            Q5C4.ForeColor = Color.Red;
                        }

                    }

                    if (i == 5)
                    {


                        Q6Correct.Text = rdr[6].ToString(); Q6Correct.Visible = true;

                        if (Q6C1.Checked == true && Q6C1.Text == rdr[6].ToString())
                        {
                            Q6C1.ForeColor = Color.Green; correct++;
                        }
                        else if (Q6C1.Checked == true && Q6C1.Text != rdr[6].ToString())
                        {
                            Q6C1.ForeColor = Color.Red;
                        }

                        else if (Q6C2.Checked == true && Q6C2.Text == rdr[6].ToString())
                        {
                            Q6C2.ForeColor = Color.Green; correct++;
                        }
                        else if (Q6C2.Checked == true && Q6C2.Text != rdr[6].ToString())
                        {
                            Q6C2.ForeColor = Color.Red;
                        }

                        else if (Q6C3.Checked == true && Q6C3.Text == rdr[6].ToString())
                        {
                            Q6C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q6C3.Checked == true && Q6C3.Text != rdr[6].ToString())
                        {
                            Q6C3.ForeColor = Color.Red;
                        }

                        else if (Q6C4.Checked == true && Q6C4.Text == rdr[6].ToString())
                        {
                            Q5C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q6C4.Checked == true && Q6C4.Text != rdr[6].ToString())
                        {
                            Q6C4.ForeColor = Color.Red;
                        }


                    }


                    if (i == 7)
                    {



                        Q7Correct.Text = rdr[6].ToString(); Q7Correct.Visible = true;

                        if (Q7C1.Checked == true && Q7C1.Text == rdr[6].ToString())
                        {
                            Q7C1.ForeColor = Color.Green; correct++;
                        }
                        else if (Q7C1.Checked == true && Q7C1.Text != rdr[6].ToString())
                        {
                            Q7C1.ForeColor = Color.Red;
                        }

                        else if (Q7C2.Checked == true && Q7C2.Text == rdr[6].ToString())
                        {
                            Q7C2.ForeColor = Color.Green; correct++;
                        }
                        else if (Q7C2.Checked == true && Q7C2.Text != rdr[6].ToString())
                        {
                            Q7C2.ForeColor = Color.Red;
                        }

                        else if (Q7C3.Checked == true && Q7C3.Text == rdr[6].ToString())
                        {
                            Q7C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q7C3.Checked == true && Q7C3.Text != rdr[6].ToString())
                        {
                            Q7C3.ForeColor = Color.Red;
                        }

                        else if (Q7C4.Checked == true && Q7C4.Text == rdr[6].ToString())
                        {
                            Q7C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q7C4.Checked == true && Q7C4.Text != rdr[6].ToString())
                        {
                            Q7C4.ForeColor = Color.Red;
                        }


                    }



                    if (i == 8)
                    {



                        Q8Correct.Text = rdr[6].ToString(); Q7Correct.Visible = true;

                        if (Q8C1.Checked == true && Q8C1.Text == rdr[6].ToString())
                        {
                            Q8C1.ForeColor = Color.Green; correct++;
                        }
                        else if (Q8C1.Checked == true && Q8C1.Text != rdr[6].ToString())
                        {
                            Q8C1.ForeColor = Color.Red;
                        }

                        else if (Q8C2.Checked == true && Q8C2.Text == rdr[6].ToString())
                        {
                            Q8C2.ForeColor = Color.Green; correct++;
                        }
                        else if (Q8C2.Checked == true && Q8C2.Text != rdr[6].ToString())
                        {
                            Q8C2.ForeColor = Color.Red;
                        }

                        else if (Q8C3.Checked == true && Q8C3.Text == rdr[6].ToString())
                        {
                            Q8C3.ForeColor = Color.Green; correct++;
                        }
                        else if (Q8C3.Checked == true && Q8C3.Text != rdr[6].ToString())
                        {
                            Q8C3.ForeColor = Color.Red;
                        }

                        else if (Q8C4.Checked == true && Q8C4.Text == rdr[6].ToString())
                        {
                            Q8C4.ForeColor = Color.Green; correct++;
                        }
                        else if (Q8C4.Checked == true && Q8C4.Text != rdr[6].ToString())
                        {
                            Q8C4.ForeColor = Color.Red;
                        }


                    }
                    txtcorrect.Visible = true;
                    txtcorrect.Text = "correct" + correct;
                }
                con.Close();
                rdr.Close();
            }
        }

       
    }
}
