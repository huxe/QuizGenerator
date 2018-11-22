using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGenerator
{
    public partial class selectQuiz : Form
    {
        public selectQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Math m = new Math();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pakistanstudies p = new pakistanstudies();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            english eng = new english();
            eng.Show();
        }
    }
}
