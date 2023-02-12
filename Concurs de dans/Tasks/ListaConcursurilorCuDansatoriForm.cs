using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class ListaConcursurilorCuDansatoriForm : Form
    {
        public ListaConcursurilorCuDansatoriForm()
        {
            InitializeComponent();

            // Controlerul ce preia denumirile concursurilor
            concursuriListBox.DataSource = DataAccess.GetCompetitionName();
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

        // Butonul ce afiseaza participatnii, in functie de concursul ales
        private void afiseazaParticipantiButton_Click(object sender, EventArgs e)
        {
            List<Dancer> dancers = DataAccess.GetDancersByCompetition(concursuriListBox.SelectedItem.ToString());

            participantiListBox.DataSource = dancers;
            participantiListBox.DisplayMember = "GetNameSurname";
        }
    }
}
