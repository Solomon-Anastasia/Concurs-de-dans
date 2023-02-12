using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Concurs_de_dans.MenuStripForms
{
    public partial class CategoriiForm : Form
    {
        public CategoriiForm()
        {
            InitializeComponent();

            // Afisarea denumirilor categoriilor
            List<string> categories = DataAccess.GetCategoryName();
            categoriiListBox.DataSource = categories;
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
