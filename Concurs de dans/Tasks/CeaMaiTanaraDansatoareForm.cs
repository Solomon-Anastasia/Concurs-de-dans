using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class CeaMaiTanaraDansatoareForm : Form
    {
        List<Dancer> youngestFemaleDancer = DataAccess.GetYoungestFemaleDancer();

        public CeaMaiTanaraDansatoareForm()
        {
            InitializeComponent();

            // Afisarea datelor celei mai tinere dansatoare
            codTextBox.Text = youngestFemaleDancer[0].CodDansator;
            numeTextBox.Text = youngestFemaleDancer[0].Nume;
            prenumeTextBox.Text = youngestFemaleDancer[0].Prenume;
            varstaTextBox.Text = youngestFemaleDancer[0].Varsta;
            genTextBox.Text = youngestFemaleDancer[0].GetGen;
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
    }
}
