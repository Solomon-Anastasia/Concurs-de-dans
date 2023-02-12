
namespace Concurs_de_dans
{
    partial class PremiiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PremiiForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareButton = new System.Windows.Forms.Button();
            this.concursLabel = new System.Windows.Forms.Label();
            this.premiiConcursListBox = new System.Windows.Forms.ListBox();
            this.denumireConcursComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(493, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // afisareButton
            // 
            this.afisareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.afisareButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.afisareButton.FlatAppearance.BorderSize = 0;
            this.afisareButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(153)))), ((int)(((byte)(136)))));
            this.afisareButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(155)))));
            this.afisareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afisareButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afisareButton.ForeColor = System.Drawing.Color.White;
            this.afisareButton.Location = new System.Drawing.Point(46, 135);
            this.afisareButton.Name = "afisareButton";
            this.afisareButton.Size = new System.Drawing.Size(138, 26);
            this.afisareButton.TabIndex = 41;
            this.afisareButton.Text = "Afisare";
            this.afisareButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.afisareButton.UseVisualStyleBackColor = false;
            this.afisareButton.Click += new System.EventHandler(this.afisareButton_Click);
            // 
            // concursLabel
            // 
            this.concursLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.concursLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concursLabel.ForeColor = System.Drawing.Color.White;
            this.concursLabel.Location = new System.Drawing.Point(12, 45);
            this.concursLabel.Margin = new System.Windows.Forms.Padding(3);
            this.concursLabel.Name = "concursLabel";
            this.concursLabel.Size = new System.Drawing.Size(206, 26);
            this.concursLabel.TabIndex = 39;
            this.concursLabel.Text = "Selectati concursul";
            this.concursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // premiiConcursListBox
            // 
            this.premiiConcursListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.premiiConcursListBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiiConcursListBox.ForeColor = System.Drawing.Color.White;
            this.premiiConcursListBox.FormattingEnabled = true;
            this.premiiConcursListBox.ItemHeight = 16;
            this.premiiConcursListBox.Location = new System.Drawing.Point(236, 45);
            this.premiiConcursListBox.Name = "premiiConcursListBox";
            this.premiiConcursListBox.Size = new System.Drawing.Size(245, 116);
            this.premiiConcursListBox.TabIndex = 38;
            // 
            // denumireConcursComboBox
            // 
            this.denumireConcursComboBox.FormattingEnabled = true;
            this.denumireConcursComboBox.Items.AddRange(new object[] {
            "AllStyles Dance Competition",
            "Aplauze Talent",
            "Dincolo de Stele",
            "Fantezie si Talent",
            "Ghiocelul de Argint",
            "Jocuri Dinamice si Dans",
            "Marea Neagra",
            "Puterea Stelelor",
            "Sisteme de Fulgi",
            "Tinere Talente"});
            this.denumireConcursComboBox.Location = new System.Drawing.Point(12, 84);
            this.denumireConcursComboBox.Name = "denumireConcursComboBox";
            this.denumireConcursComboBox.Size = new System.Drawing.Size(206, 24);
            this.denumireConcursComboBox.TabIndex = 42;
            // 
            // PremiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 183);
            this.Controls.Add(this.denumireConcursComboBox);
            this.Controls.Add(this.afisareButton);
            this.Controls.Add(this.concursLabel);
            this.Controls.Add(this.premiiConcursListBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PremiiForm";
            this.Text = "Premii";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.Button afisareButton;
        private System.Windows.Forms.Label concursLabel;
        private System.Windows.Forms.ListBox premiiConcursListBox;
        private System.Windows.Forms.ComboBox denumireConcursComboBox;
    }
}