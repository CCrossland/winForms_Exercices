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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Menu target = new Menu();
            target.Show();
            this.Hide();
        }

        CheckState check = (CheckState)1;
        CheckState uncheck = 0;

        private void checkedListBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int compteur = 0;

            for (int i = 0; i < checkedListBoxColor.Items.Count; i++)
            {
                if (checkedListBoxColor.GetItemCheckState(i) == check)
                {
                    compteur += 1;
                }
            }

            label1.Text = compteur.ToString();
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxColor.Items.Count; i++)
            {
                checkedListBoxColor.SetItemCheckState(i, check);
            }

            label1.Text = (checkedListBoxColor.CheckedItems.Count).ToString();
        }

        private void buttonUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxColor.Items.Count; i++)
            {
                checkedListBoxColor.SetItemCheckState(i, uncheck);
            }

            label1.Text = (checkedListBoxColor.CheckedItems.Count).ToString();
        }

        private void buttonInverseCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxColor.Items.Count; i++)
            {
                if (checkedListBoxColor.GetItemCheckState(i) == check)
                {
                    checkedListBoxColor.SetItemCheckState(i, uncheck);
                }
                else
                {
                    checkedListBoxColor.SetItemCheckState(i, check);
                }
            }

            label1.Text = (checkedListBoxColor.CheckedItems.Count).ToString();
        }
    }
}
