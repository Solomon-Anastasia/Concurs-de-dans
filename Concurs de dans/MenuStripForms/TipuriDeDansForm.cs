using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.MenuStripForms
{
    public partial class TipuriDeDansForm : Form
    {
        public TipuriDeDansForm()
        {
            InitializeComponent();

            // Afisarea denumirilor tipurilor de dans
            List<string> danceTypes = DataAccess.GetDanceType();
            tipuriDeDansListBox.DataSource = danceTypes;
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
