using Concurs_de_dans.LogIn;
using Concurs_de_dans.MenuStripForms;
using Concurs_de_dans.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans
{
    public partial class ConcursDeDansForm : Form
    {
        // Variabila ce determina cine a s-a logat
        List<string> whoEntered = DataAccess.ViewLogin();

        public ConcursDeDansForm()
        {
            InitializeComponent();
        }

        // Metoda ce intoarce la meniul de logare
        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new LogInForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu dansatori
        private void dansatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new DansatoriForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu categorii
        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new CategoriiForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu tipuri de dans
        private void tipDeDansuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new TipuriDeDansForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu inregistrare
        private void inregistreazaButton_Click(object sender, EventArgs e)
        {
            if (whoEntered[0].Equals("False")) {
                MessageBox.Show("Nu aveti destule drepturi pentru a insera un dansator nou!", "Oaspete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                this.Hide(); // Ascundem formularul curent

                // Cream o variabila de tip form
                var Form = new InregistrareDansatorForm();

                // Inchidem formularul curent, deschizand formularul de salutare
                Form.Closed += (s, args) => this.Close();
                Form.Show();
            }
        }

        // Metoda ce afiseaza formularul cu excludere
        private void excludeButton_Click(object sender, EventArgs e)
        {
            if (whoEntered[0].Equals("False")) {
                MessageBox.Show("Nu aveti destule drepturi pentru a exclude un dansator!", "Oaspete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                this.Hide(); // Ascundem formularul curent

                // Cream o variabila de tip form
                var Form = new ExcludereDansatorForm();

                // Inchidem formularul curent, deschizand formularul de salutare
                Form.Closed += (s, args) => this.Close();
                Form.Show();
            }
        }

        // Metoda ce afiseaza formularul cu dansatorul cl mai tanar / in varsta, 
        // si ce tip de dans practica
        private void selecteazaCelMaiInVarstaTanarButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new DansatorTanarBatranForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul dansatori ordonati ascendenti dupa varsta
        private void ordonareDupaVarsaButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new OrdonareAscendentDupaVarstaForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu cea mai tanara dansatoare
        private void ceaMaiTanaraFemeieButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new CeaMaiTanaraDansatoareForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu dansatori, in functie de categoria selectata
        private void dansatoriDupaCategorieButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new DansatoriDupaCategoriiForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu varsta medie a barbatilor
        private void varstamediaBarbatiCategorieButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new VarstaMedieABarbatilorForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul care exporta dansatoarele sub un anumit nr de ani
        private void exportaButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new ExportaDansatoareAniForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul care creeaza o vedere,
        // ce contine date de contact a dansatorilor
        private void dateDeContactButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new DateDeContactInTabelaForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu dansatorii si institutia unde isi fac studiile
        private void participantiStudiileButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new DansatoriCuInstitutiaForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu premii
        private void afisarepremiiButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new PremiiForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }

        // Metoda ce afiseaza formularul cu concursuri si dansatorii ce participa la acesta
        private void ConcursuriParticipantiButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var Form = new ListaConcursurilorCuDansatoriForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            Form.Closed += (s, args) => this.Close();
            Form.Show();
        }
    }
}
