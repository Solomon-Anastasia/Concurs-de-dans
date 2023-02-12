using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Concurs_de_dans.Tasks
{
    public partial class ExportaDansatoareAniForm : Form
    {
        public ExportaDansatoareAniForm()
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

        private void exportaButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = true;
            bool isDigitOnly = true;
            foreach (char c in aniTextBox.Text) {
                if (c < '0' || c > '9') {
                    isDigitOnly = false;
                    break;
                }
            }

            if (aniTextBox.Text.Length == 0) {
                MessageBox.Show("Introduceti varsta!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isCorrect = false;
            } else if (!isDigitOnly) {
                aniTextBox.Text = "";
                MessageBox.Show("Varsta contine caractere!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isCorrect = false;
            } else if (Convert.ToInt32(aniTextBox.Text) > 40 || Convert.ToInt32(aniTextBox.Text) < 5) {
                aniTextBox.Text = "";
                MessageBox.Show("Varsta introdusa depaseste limitile!", "Eroare de introducere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isCorrect = false;
            }

            if (isCorrect) {
                int an = DateTime.Today.Year - Convert.ToInt32(aniTextBox.Text);
                List<Dancer> dancers = DataAccess.GetFemaleDancersUnderIntroducedYears($"{an}-01-01");
                string path = Path.GetFullPath(@"..\..\") + "Dansatoare.csv";

                // Introducem datele obtinute intr-un fisier .csv
                using (StreamWriter sw = new StreamWriter(path, false))  {
                    string data;
                    data = "Cod dansator,Nume,Prenume,Experienta,Varsta,,,,," + Environment.NewLine;

                    for (int i = 0; i < dancers.Count - 1; i++) {
                        data += $"{dancers[i].CodDansator},{dancers[i].Nume},{dancers[i].Prenume},{dancers[i].Experienta},{dancers[i].Varsta},,,,," + Environment.NewLine;
                    }
                    data += $"{dancers[dancers.Count - 1].CodDansator},{dancers[dancers.Count - 1].Nume},{dancers[dancers.Count - 1].Prenume},{dancers[dancers.Count - 1].Experienta},{dancers[dancers.Count - 1].Varsta},,,,,";
                    
                    // Scrierea datelor in .csv fisier
                    sw.Write(data);
                }

                using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx"}) {
                    if (sfd.ShowDialog() == DialogResult.OK) {
                        try {
                            // Preluam datele din fisierul .csv intr-un fisier .xlsx
                            Excel.Application xl = new Excel.Application();
                            Excel.Workbook wb = xl.Workbooks.Open(path);

                            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
                            // Selectam UsedRange
                            Excel.Range used = ws.UsedRange;
                            // Setarea coloanelor, pentru a corespunde cu dimensiunea textului
                            used.EntireColumn.AutoFit();
                            // Salvam fisirul ca .xlsx
                            wb.SaveAs(sfd.FileName, 51);
                            // Inchderea Workbook-ului
                            wb.Close();
                            // Iesirea din Excel Application
                            xl.Quit();

                            aniTextBox.Text = "";
                            // Afisarea unui mesaj sugestiv
                            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch (Exception ex) { // In cazul unei erori, se afiseaza un mesaj sugestiv
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
