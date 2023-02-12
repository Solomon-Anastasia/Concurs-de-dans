using System;
using System.Windows.Forms;

namespace Concurs_de_dans.Tasks
{
    public partial class InregistrareDansatorForm : Form
    {
        // Variabila ce duce evidenta despre nr. de erori aparute pe parcursul introducerii datelor
        int nrGreseli;

        public InregistrareDansatorForm()
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

        // Metoda ce reseteaza datele introduse
        private void reseteazaButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Metoda ce sterge valorile introduse
        private void Clear()
        {
            numeTextBox.Text = "";
            prenumeTextBox.Text = "";
            genComboBox.SelectedIndex = -1;
            experientaTextBox.Text = "";
            dataNasteriiDateTimePicker.Value = DateTime.Now;

            institutiaTextBox.Text = "";
            adresaInstitutieTextBox.Text = "";

            emailTextBox.Text = "";
            telefonTextBox.Text = "";
            adresaDansatorTextBox.Text = "";

            premiuBanescTextBox.Text = "";
            loculComboBox.SelectedIndex = -1;

            tipDansComboBox.SelectedIndex = -1;
            denumireConcursComboBox.SelectedIndex = -1;
            extensiaComboBox.SelectedIndex = -1;
        }

        // Metoda ce inregistreaza un dansator nou
        private void salveazaButton_Click(object sender, EventArgs e)
        {
            Verificare();

            if (nrGreseli == 0)
            {
                string gen;

                if (genComboBox.SelectedIndex == 0) {
                    gen = "F";
                } else gen = "M";

                // Introducerea datelor in baza de date
                DataAccess.InsertDancer(institutiaTextBox.Text, adresaInstitutieTextBox.Text, 
                                        tipDansComboBox.SelectedItem.ToString(), GenerareCodDansator(), 
                                        numeTextBox.Text, prenumeTextBox.Text, gen, dataNasteriiDateTimePicker.Value.Date.ToString("yyyy-M-dd"), 
                                        Convert.ToInt32(experientaTextBox.Text), denumireConcursComboBox.SelectedItem.ToString(),
                                        emailTextBox.Text + extensiaComboBox.SelectedItem.ToString(), 
                                        $"+373 {telefonTextBox.Text[0]}{telefonTextBox.Text[1]}{telefonTextBox.Text[2]} {telefonTextBox.Text[3]}{telefonTextBox.Text[4]} {telefonTextBox.Text[5]}{telefonTextBox.Text[6]}{telefonTextBox.Text[7]}", 
                                        adresaDansatorTextBox.Text);
                
                if (loculComboBox.SelectedIndex != -1) {
                    DataAccess.InsertPrize(loculComboBox.SelectedItem.ToString(), Convert.ToInt32(premiuBanescTextBox.Text), denumireConcursComboBox.SelectedItem.ToString());
                }

                Clear();
                MessageBox.Show("Dansatorul a fost introdus cu succes!", "Introducere cu succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Metoda ce verifica daca au fost introduse corect datele dansatorului
        private void Verificare()
        {
            string message = "";
            nrGreseli = 0;

            if (numeTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti numele!" + Environment.NewLine;
            }
            if (prenumeTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti prenumele!" + Environment.NewLine;
            }
            if (genComboBox.SelectedIndex == -1) {
                nrGreseli++;
                message += "Selectati genul!" + Environment.NewLine;
            }

            // Verificarea corectitudinii introducerii varstei si experientei
            var today = DateTime.Today;
            var age = today.Year - dataNasteriiDateTimePicker.Value.Year;
            if (dataNasteriiDateTimePicker.Value.Date > today.AddYears(-age))
                age--;

            if (age < 5) {
                nrGreseli++;
                message += "Varsta minima este de 5 ani!" + Environment.NewLine;
            } else if (age > 40) {
                nrGreseli++;
                message += "Varsta maxima este de 40 ani!" + Environment.NewLine;
            }
            if (experientaTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti experienta!" + Environment.NewLine;
            } else if (Convert.ToInt32(experientaTextBox.Text) >= age - 5) {
                nrGreseli++;
                message += "Experienta este mai mare decat varsta!" + Environment.NewLine;
            }

            if (institutiaTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti denumirea institutiei!" + Environment.NewLine;
            }
            if (adresaInstitutieTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti adresa institutiei!" + Environment.NewLine;
            }

            // Verificarea corectitudinii introducerii a email
            if (emailTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti email!" + Environment.NewLine;
            }
            if (emailTextBox.Text.Contains("@gmail.com") || emailTextBox.Text.Contains("@mail.com") || emailTextBox.Text.Contains("@yahoo.com")) {
                nrGreseli++;
                message += "Nu introduceti extensia! Selectati-o din lista de langa!" + Environment.NewLine;
            }
            if (extensiaComboBox.SelectedIndex == -1) {
                nrGreseli++;
                message += "Selectati extensia pentru email!" + Environment.NewLine;
            }

            // Verificarea corectitudinii introducerii nr. telefon
            bool isDigitOnly = true;
            foreach (char c in telefonTextBox.Text) {
                if (c < '0' || c > '9') {
                    isDigitOnly = false;
                    break;
                }
            }
            if (telefonTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti nr. de telefon!" + Environment.NewLine;
            } else if (!isDigitOnly) {
                nrGreseli++;
                message += "Nr. telefon contine caractere!" + Environment.NewLine;
            } else if (telefonTextBox.Text.Length != 8) {
                nrGreseli++;
                message += "Nr. telefon introdus gresit (ex: 69375842)!" + Environment.NewLine;
            }
            if (adresaDansatorTextBox.Text.Length == 0)  {
                nrGreseli++;
                message += "Introduceti adresa dansatorului!" + Environment.NewLine;
            }

            if (tipDansComboBox.SelectedIndex == -1) {
                nrGreseli++;
                message += "Selectati tipul de dans practicat de dansator!" + Environment.NewLine;
            }
            if (denumireConcursComboBox.SelectedIndex == -1) {
                nrGreseli++;
                message += "Selectati concursul la care participa dansatorul!" + Environment.NewLine;
            }

            // Daca dansatorul are un loc ocupat, verificam corectitudinea introducerii datelor
            bool isDigitOnlyForPrize = true;
            foreach (char c in premiuBanescTextBox.Text) {
                if (c < '0' || c > '9') {
                    isDigitOnlyForPrize = false;
                    break;
                }
            }

            if (loculComboBox.SelectedIndex != -1 && premiuBanescTextBox.Text.Length == 0) {
                nrGreseli++;
                message += "Introduceti si premiul banesc!" + Environment.NewLine;
            } else if (loculComboBox.SelectedIndex == -1 && premiuBanescTextBox.Text.Length != 0) {
                nrGreseli++;
                message += "Introduceti si locul ocupat!" + Environment.NewLine;
            } else if (!isDigitOnlyForPrize) {
                nrGreseli++;
                message += "Premiul banesc contine caractere!" + Environment.NewLine;
            }

            if (nrGreseli != 0)
            {
                MessageBox.Show(message, "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        // Metoda ce genereaza codul unui dansator
        private string GenerareCodDansator()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 99);
            string cod;

            cod = $"{numeTextBox.Text[0]}{prenumeTextBox.Text[0]}{telefonTextBox.Text[6]}{telefonTextBox.Text[7]}{randomNumber}";
            return cod; 
        }
    }
}
