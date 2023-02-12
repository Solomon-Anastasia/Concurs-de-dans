using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class VarstaMedieABarbatilorForm : Form
    {
        public VarstaMedieABarbatilorForm()
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

        // Metoda ce afiseaza varsta medie a barbatilor dintr-o categorie aselectata
        private void afisareButton_Click(object sender, EventArgs e)
        {
            double varstaMedie = 0;
            varstaMedieCircularProgressBar.Maximum = 40;

            if (denumireCategorieComboBox.SelectedIndex == -1) {
                MessageBox.Show("Selectati categoria!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                List<Dancer> maleDancers = DataAccess.GetMaleDancersByCategory(denumireCategorieComboBox.SelectedItem.ToString());
                
                foreach(Dancer i in maleDancers) {
                    varstaMedie += Convert.ToDouble(i.Varsta);
                }

                varstaMedie /= maleDancers.Count;
                if (varstaMedie > 0) {
                    aniLabel.Text = Math.Round(varstaMedie, 0).ToString() + " ani";
                    varstaMedieCircularProgressBar.Value = Convert.ToInt32(varstaMedie);
                } else {
                    aniLabel.Text = "0 ani";
                    varstaMedieCircularProgressBar.Value = Convert.ToInt32(0);
                }
            }
        }
    }
}
