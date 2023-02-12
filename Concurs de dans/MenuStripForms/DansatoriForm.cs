using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans
{
    public partial class DansatoriForm : Form
    {
        // Variabile ce duc evidenta despre dansatori
        private int contor = 0;
        List<Dancer> dancers = DataAccess.GetDancers();

        public DansatoriForm()
        {
            InitializeComponent();

            // Afisarea datelor primului dansator
            AfisareDansator(contor);
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

        // Metoda ce afiseaza datele dansatorului precendent
        private void precedentButton_Click(object sender, EventArgs e)
        {
            if (contor > 0) {
                contor--;
                AfisareDansator(contor);
            }
        }

        // Metoda ce afiseaza datele dansatorului urmator
        private void urmatorulButton_Click(object sender, EventArgs e)
        {
            if (contor < dancers.Count - 1) {
                contor++;
                AfisareDansator(contor);
            }
        }

        // Metoda ce afiseaza datele unui dansator
        private void AfisareDansator(int i)
        {
            if (contor < dancers.Count && contor >= 0) 
            {
                codDansatorTextBox.Text = dancers[i].CodDansator;
                numeTextBox.Text = dancers[i].Nume;
                prenumeTextBox.Text = dancers[i].Prenume;
                genTextBox.Text = dancers[i].GetGen;
                varstaTextBox.Text = dancers[i].Varsta;
                experientaTextBox.Text = dancers[i].Experienta.ToString();
            }
        }
    }
}
