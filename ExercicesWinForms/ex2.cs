using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicesWinForms
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Menu target = new Menu();
            target.Show();
            this.Hide();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            string q1, q2;

            if (radioButtonQ1A1.Checked)
            {
                q1 = radioButtonQ1A1.Text;
            }
            else if (radioButtonQ1A2.Checked)
            {
                q1 = radioButtonQ1A2.Text;
            }
            else if (radioButtonQ1A3.Checked)
            {
                q1 = radioButtonQ1A3.Text;
            }
            else
            {
                q1 = "error";
            }

            if (radioButtonQ2A3.Checked)
            {
                q2 = radioButtonQ2A3.Text;
            }
            else if (radioButtonQ2A2.Checked)
            {
                q2 = radioButtonQ2A2.Text;
            }
            else if (radioButtonQ2A1.Checked)
            {
                q2 = radioButtonQ2A1.Text;
            }
            else if (radioButtonQ2A4.Checked)
            {
                q2 = radioButtonQ2A4.Text;
            }
            else
            {
                q2 = "error";
            }

            if (q1 != "error" && q2 != "error")
            {
                MessageBox.Show("Votre sport favori est le " + q1 + " et votre saison favorite est " + q2);
            }
            else
            {
                MessageBox.Show("Veuillez répondre aux deux questions");
            }
        }
    }
}
