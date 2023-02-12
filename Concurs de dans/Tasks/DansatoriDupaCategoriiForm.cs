using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class DansatoriDupaCategoriiForm : Form
    {
        public DansatoriDupaCategoriiForm()
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

        // Butonul ce afiseaza numele, prenumele dansatorilor in functie de categoria selectata
        private void afisareButton_Click(object sender, EventArgs e)
        {
            if (denumireCategorieComboBox.SelectedIndex == -1) {
                MessageBox.Show("Selectati categoria!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                List<Dancer> dancersByCategory = DataAccess.GetDancersByCategory(denumireCategorieComboBox.SelectedItem.ToString());
                
                dansatoriDupaCategorieListBox.DataSource = dancersByCategory;
                dansatoriDupaCategorieListBox.DisplayMember = "GetNameSurname";
            }
        }
    }
}
