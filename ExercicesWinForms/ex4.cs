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
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Menu target = new Menu();
            target.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCar.Text != "")
            {

                if (comboBoxCars.Items.Count < 4)
                {
                    MarqueVoiture addedcar = new MarqueVoiture((comboBoxCars.Items.Count + 1), textBoxCar.Text);
                    comboBoxCars.Items.Add(addedcar);

                    labelCount.Text = (comboBoxCars.Items.Count).ToString();
                    textBoxCar.Clear();
                    textBoxCar.Focus();
                }
                else
                {
                    MarqueVoiture addedcar = new MarqueVoiture((comboBoxCars.Items.Count + 1), textBoxCar.Text);
                    comboBoxCars.Items.Add(addedcar);

                    textBoxCar.Hide();
                    labelAdded.Hide();
                    labelAdd.Hide();
                    labelCount.Hide();
                    buttonAdd.Hide();

                    comboBoxCars.Visible = true;
                    buttonSelect.Visible = true;
                    labelSelect.Visible = true;
                    comboBoxCars.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veuillez rentrer une marque de voiture");
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            MarqueVoiture selectedCar = (MarqueVoiture)comboBoxCars.SelectedItem;

            MessageBox.Show("La voiture sélectionnée est une " + selectedCar.label + " et son ID est: " + selectedCar.id.ToString());
        }
    }
}
