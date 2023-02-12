using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class DansatorTanarBatranForm : Form
    {
        List<Dancer> youngestDancer = DataAccess.GetYoungestDancer();
        List<Dancer> oldestDancer = DataAccess.GetOldestDancer();

        public DansatorTanarBatranForm()
        {
            InitializeComponent();

            // Afisarea datelor celui mai tanar dansator
            cod1TextBox.Text = youngestDancer[0].CodDansator;
            nume1TextBox.Text = youngestDancer[0].Nume;
            prenume1TextBox.Text = youngestDancer[0].Prenume;
            tipDans1TextBox.Text = youngestDancer[0].DenumireTipDans;
            varsta1TextBox.Text = youngestDancer[0].Varsta;
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

        // Metoda ce afiseaza datele celui mai in varsta dansator
        private void celMaiTanarBatranDansatorTabControl_Click(object sender, EventArgs e)
        {
            cod2TextBox.Text = oldestDancer[0].CodDansator;
            nume2TextBox.Text = oldestDancer[0].Nume;
            prenume2TextBox.Text = oldestDancer[0].Prenume;
            tipDans2TextBox.Text = oldestDancer[0].DenumireTipDans;
            varsta2TextBox.Text = oldestDancer[0].Varsta;
        }
    }
}
