using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class DateDeContactInTabelaForm : Form
    {
        // Variabile ce duc evidenta despre dansatori
        private int contor = 0;
        List<Dancer> dancers = DataAccess.GetViewContactData();

        public DateDeContactInTabelaForm()
        {
            InitializeComponent();

            DataAccess.CreateTableContactData();

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

        // Metoda ce afiseaza datele de contact a dansatorului precendent
        private void precedentButton_Click(object sender, EventArgs e)
        {
            if (contor > 0)
            {
                contor--;
                AfisareDansator(contor);
            }
        }

        // Metoda ce afiseaza datele de contact dansatorului urmator
        private void urmatorulButton_Click(object sender, EventArgs e)
        {
            if (contor < dancers.Count - 1)
            {
                contor++;
                AfisareDansator(contor);
            }
        }

        // Metoda ce afiseaza datele unui dansator
        private void AfisareDansator(int i)
        {
            if (contor < dancers.Count && contor >= 0)
            {
                string telefonData = "";
                string email = "";

                codTextBox.Text = dancers[i].CodDansator;
                numeTextBox.Text = dancers[i].Nume;
                prenumeTextBox.Text = dancers[i].Prenume;
                // Securizam datele prin ascunderea unor caractere din datele de contact
                for (int j = 0; j < dancers[i].Telefon.Length; j++) {
                    if (j >= 5 && j <= 12) {
                        telefonData += "*";
                    } else {
                        telefonData += $"{dancers[i].Telefon[j]}";
                    }
                }

                for (int j = 0; j < dancers[i].Email.Length; j++)
                {
                    if (j < 3) {
                        email += $"{dancers[i].Email[j]}";
                    } else if (dancers[i].Email[j].Equals('@')) {
                        for (int k = j; k < dancers[i].Email.Length; k++) {
                            email += $"{dancers[i].Email[k]}";
                        }
                        break;
                    } else {
                        email += "*";
                    }
                }

                telefonTextBox.Text = telefonData;
                emailTextBox.Text = email;
                adresaTextBox.Text = dancers[i].Adresa;
            }
        }
    }
}
