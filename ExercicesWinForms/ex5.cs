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
    public partial class ex5 : Form
    {
        public ex5()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Menu target = new Menu();
            target.Show();
            this.Hide();
        }

        int compteurID = 0;

        private void btnCreateRow_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification de la validité de la date
                DateTime testDate = Convert.ToDateTime(textBoxBirthday.Text);
                string dateConvert = testDate.ToString("dd MM yyyy");

                Personne personne = new Personne(compteurID, textBoxLastname.Text, textBoxFirstname.Text, dateConvert);

                dataGridViewPersonnes.Rows.Add(personne.id, personne.nom, personne.prenom, personne.datenaissance);

                textBoxLastname.Clear();
                textBoxFirstname.Clear();
                textBoxBirthday.Clear();

                labelCount.Text = (dataGridViewPersonnes.Rows.Count - 1).ToString();

                compteurID++;
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez entrer une date valide.");
            }

        }

        private void dataGridViewPersonnes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                DataGridViewRow selectedRow = dataGridViewPersonnes.Rows[index];

                textBoxLastnameRead.Text = selectedRow.Cells[1].Value.ToString();
                textBoxFirstnameRead.Text = selectedRow.Cells[2].Value.ToString();
                textBoxBirthdateRead.Text = selectedRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Some error occured" + ex.Message + " ; " + ex.Source);
            }
        }
    }
}
