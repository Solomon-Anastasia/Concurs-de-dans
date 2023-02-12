
namespace Concurs_de_dans.Tasks
{
    partial class VarstaMedieABarbatilorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarstaMedieABarbatilorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareButton = new System.Windows.Forms.Button();
            this.denumireCategorieComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.aniLabel = new System.Windows.Forms.Label();
            this.varstaMedieLabel = new System.Windows.Forms.Label();
            this.varstaMedieCircularProgressBar = new CircularProgressBar.CircularProgressBar();
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
            this.menuStrip1.Size = new System.Drawing.Size(386, 26);
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
            this.afisareButton.Location = new System.Drawing.Point(28, 176);
            this.afisareButton.Name = "afisareButton";
            this.afisareButton.Size = new System.Drawing.Size(138, 26);
            this.afisareButton.TabIndex = 40;
            this.afisareButton.Text = "Afisare";
            this.afisareButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.afisareButton.UseVisualStyleBackColor = false;
            this.afisareButton.Click += new System.EventHandler(this.afisareButton_Click);
            // 
            // denumireCategorieComboBox
            // 
            this.denumireCategorieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumireCategorieComboBox.FormattingEnabled = true;
            this.denumireCategorieComboBox.Items.AddRange(new object[] {
            "Africane si afro-americane",
            "Alte",
            "Dans ceremonial",
            "Dans de leagan",
            "Dans de strada",
            "Dans gratuit si improvizat",
            "Dans istoric",
            "Dans social",
            "Dansuri de noutate si moft",
            "Discoteca / Dans electronic",
            "Hanpurian",
            "Latina / Ritm"});
            this.denumireCategorieComboBox.Location = new System.Drawing.Point(12, 92);
            this.denumireCategorieComboBox.Name = "denumireCategorieComboBox";
            this.denumireCategorieComboBox.Size = new System.Drawing.Size(172, 24);
            this.denumireCategorieComboBox.TabIndex = 39;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.categoriaLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.ForeColor = System.Drawing.Color.White;
            this.categoriaLabel.Location = new System.Drawing.Point(12, 43);
            this.categoriaLabel.Margin = new System.Windows.Forms.Padding(3);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(172, 26);
            this.categoriaLabel.TabIndex = 38;
            this.categoriaLabel.Text = "Selectati categoria";
            this.categoriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aniLabel
            // 
            this.aniLabel.AutoSize = true;
            this.aniLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aniLabel.ForeColor = System.Drawing.Color.Black;
            this.aniLabel.Location = new System.Drawing.Point(258, 141);
            this.aniLabel.Name = "aniLabel";
            this.aniLabel.Size = new System.Drawing.Size(59, 18);
            this.aniLabel.TabIndex = 51;
            this.aniLabel.Text = "00 ani";
            // 
            // varstaMedieLabel
            // 
            this.varstaMedieLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.varstaMedieLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varstaMedieLabel.ForeColor = System.Drawing.Color.White;
            this.varstaMedieLabel.Location = new System.Drawing.Point(208, 43);
            this.varstaMedieLabel.Margin = new System.Windows.Forms.Padding(3);
            this.varstaMedieLabel.Name = "varstaMedieLabel";
            this.varstaMedieLabel.Size = new System.Drawing.Size(159, 26);
            this.varstaMedieLabel.TabIndex = 52;
            this.varstaMedieLabel.Text = "Varsta medie";
            this.varstaMedieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varstaMedieCircularProgressBar
            // 
            this.varstaMedieCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.varstaMedieCircularProgressBar.AnimationSpeed = 500;
            this.varstaMedieCircularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.varstaMedieCircularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.varstaMedieCircularProgressBar.ForeColor = System.Drawing.Color.White;
            this.varstaMedieCircularProgressBar.InnerColor = System.Drawing.Color.White;
            this.varstaMedieCircularProgressBar.InnerMargin = 2;
            this.varstaMedieCircularProgressBar.InnerWidth = -1;
            this.varstaMedieCircularProgressBar.Location = new System.Drawing.Point(212, 75);
            this.varstaMedieCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.varstaMedieCircularProgressBar.Name = "varstaMedieCircularProgressBar";
            this.varstaMedieCircularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(153)))), ((int)(((byte)(136)))));
            this.varstaMedieCircularProgressBar.OuterMargin = -29;
            this.varstaMedieCircularProgressBar.OuterWidth = 26;
            this.varstaMedieCircularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(170)))));
            this.varstaMedieCircularProgressBar.ProgressWidth = 10;
            this.varstaMedieCircularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.varstaMedieCircularProgressBar.Size = new System.Drawing.Size(150, 150);
            this.varstaMedieCircularProgressBar.StartAngle = 270;
            this.varstaMedieCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.varstaMedieCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.varstaMedieCircularProgressBar.SubscriptText = ".23";
            this.varstaMedieCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.varstaMedieCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.varstaMedieCircularProgressBar.SuperscriptText = "°C";
            this.varstaMedieCircularProgressBar.TabIndex = 54;
            this.varstaMedieCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.varstaMedieCircularProgressBar.Value = 68;
            // 
            // VarstaMedieABarbatilorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 236);
            this.Controls.Add(this.aniLabel);
            this.Controls.Add(this.varstaMedieCircularProgressBar);
            this.Controls.Add(this.varstaMedieLabel);
            this.Controls.Add(this.afisareButton);
            this.Controls.Add(this.denumireCategorieComboBox);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VarstaMedieABarbatilorForm";
            this.Text = "Varsta Medie A Barbatilor Dupa Categorie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.Button afisareButton;
        private System.Windows.Forms.ComboBox denumireCategorieComboBox;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.Label aniLabel;
        private System.Windows.Forms.Label varstaMedieLabel;
        private CircularProgressBar.CircularProgressBar varstaMedieCircularProgressBar;
    }
}