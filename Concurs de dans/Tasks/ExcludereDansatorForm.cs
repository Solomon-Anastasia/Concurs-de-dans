using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class ExcludereDansatorForm : Form
    {
        public ExcludereDansatorForm()
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

        // Metoda ce afiseaza datele dansatorului care va fi exclus
        private void verficaButton_Click(object sender, EventArgs e)
        {
            List<Dancer> dancers = DataAccess.GetDancersByCode(codTextBox.Text);

            // Verificarea introducerii codului
            if (codTextBox.Text.Length == 0) {
                Clear();
                MessageBox.Show("Introduceti codul!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else { // Daca codul a fost introdus, se verifica corectitudinea acestuia
                if (dancers.Count == 1)  {
                    codTextBox.Text = "";
                    codDansatorTextBox.Text = dancers[0].CodDansator;
                    numeTextBox.Text = dancers[0].Nume;
                    prenumeTextBox.Text = dancers[0].Prenume;

                    if (dancers[0].Sex.Equals("F")) {
                        genTextBox.Text = "Femenin";
                    } else {
                        genTextBox.Text = "Masculin";
                    }
                    varstaTextBox.Text = dancers[0].Varsta;
                    experientaTextBox.Text = dancers[0].Experienta.ToString();
                } else { // Daca nu s-a gasit dansator cu asa cod, se afiseaza un mesaj sugestiv
                    Clear();
                    MessageBox.Show("Nu s-a gasit dansator cu asa cod!", "Eroare de cautare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Metoda ce exclude un dansator, conform codului introdus
        private void excludeButton_Click(object sender, EventArgs e)
        {
            List<Dancer> dancers;

            if (codTextBox.Text.Length != 0) {
                dancers = DataAccess.GetDancersByCode(codTextBox.Text);
            } else {
                dancers = DataAccess.GetDancersByCode(codDansatorTextBox.Text);
            }

            // Verificarea introducerii codului
            if (codTextBox.Text.Length == 0 && codDansatorTextBox.Text.Length == 0) {
                Clear();
                MessageBox.Show("Introduceti codul!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else { // daca codul a fost introdus, se verifica corectitudinea acestuia
                if (dancers.Count == 1) {
                    if (codTextBox.Text.Length != 0) {
                        DataAccess.DeleteDancer(codTextBox.Text);
                    } else {
                        DataAccess.DeleteDancer(codDansatorTextBox.Text);
                    }
                    Clear();
                    MessageBox.Show("Dansatorul a fost exclus cu succes!", "Excludere cu succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else { // Daca nu s-a gasit dansator cu asa cod, se afiseaza un mesaj sugestiv
                    Clear();
                    MessageBox.Show("Nu s-a gasit dansator cu asa cod!", "Eroare de cautare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Metoda ce sterge valorile afisate
        private void Clear()
        {
            codTextBox.Text = "";
            codDansatorTextBox.Text = "";
            numeTextBox.Text = "";
            prenumeTextBox.Text = "";
            genTextBox.Text = "";
            varstaTextBox.Text = "";
            experientaTextBox.Text = "";
        }
    }
}
