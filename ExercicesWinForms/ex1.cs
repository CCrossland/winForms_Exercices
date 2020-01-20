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
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Menu target = new Menu();
            target.Show();
            this.Hide();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (Masculin.Checked == true)
            {
                MessageBox.Show("Bienvenue Monsieur");
            }
            else if (Féminin.Checked == true)
            {
                MessageBox.Show("Bienvenue Madame");
            }
            else
            {
                MessageBox.Show("Veuillez choisir un genre.");
            }
        }
    }
}
