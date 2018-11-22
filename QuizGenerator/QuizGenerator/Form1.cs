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
    public partial class frmHome : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\quiz\QuizGenerator.accdb");
        public frmHome()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckRequirements();
        }
        
        public void InsertData()
        {
            con.Open();
            string query = "insert into UserInfo (name,[password],[conformPassword],email,phone) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtConformPassord.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been inserted");
            this.Refresh();
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConformPassord.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

        }

        public void CheckRequirements()
        {

            string[] information = { txtUserName.Text, txtPassword.Text, txtConformPassord.Text, txtEmail.Text, txtPhone.Text };
            for (int i = 0; i < information.Length; i++)
            {
                if (information[i] == "")
                {
                    MessageBox.Show("FIll all the feilds");
                    break;
                }
                else if (i == 4)
                {
                    if (information[1] != information[2])
                    {
                        MessageBox.Show("password does not match");
                        break;
                    }

                    else if (information[i] != "" && information[1] == information[1])

                    {
                        InsertData();
                        break;
                    }
                    
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogIn();
        }


        public void LogIn()
        {

            string query = "select name,[password] from UserInfo";
            OleDbCommand cmd = new OleDbCommand(query, con);
            bool check = true;
            DataTable dt = new DataTable();
            con.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if ((rdr[0].ToString() == txtName.Text) && (rdr[1].ToString() == txtPass.Text))
                {
                    selectQuiz frm = new selectQuiz();
                    frm.Show();
                    check = false;
                }
                
            }

            if (check)
            {
                MessageBox.Show("Incorrect User Name or password"); 
            }
            con.Close();

        }
    }
}
        
