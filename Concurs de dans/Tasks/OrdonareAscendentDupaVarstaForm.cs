using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class OrdonareAscendentDupaVarstaForm : Form
    {
        public OrdonareAscendentDupaVarstaForm()
        {
            InitializeComponent();
        }

        // Metoda ce intoarce la formularul principal
        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new ConcursDeDansForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza datele dansatorilor, sortati ascendent dupa varsta,
        // in functie de concurs
        private void afisareButton_Click(object sender, EventArgs e)
        {
            List<Dancer> sortedDancers;

            if (denumireConcursComboBox.SelectedIndex == -1) {
                MessageBox.Show("Selectati concursul dupa care se vor sorta dansatorii!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (denumireConcursComboBox.SelectedIndex == 0) {
                    sortedDancers = DataAccess.GetSortedAscDancersByDate();
                    dansatoriASCListBox.DataSource = sortedDancers;
                } else {
                    sortedDancers = DataAccess.GetSortedDancersAscFromOneCompetitionByDate(denumireConcursComboBox.SelectedItem.ToString());
                    dansatoriASCListBox.DataSource = sortedDancers;
                }
                dansatoriASCListBox.DisplayMember = "GetNameSurnameAndAge";
            }
        }
    }
}
