
namespace Concurs_de_dans.MenuStripForms
{
    partial class TipuriDeDansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipuriDeDansForm));
            this.tipuriDeDansLabel = new System.Windows.Forms.Label();
            this.tipuriDeDansListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipuriDeDansLabel
            // 
            this.tipuriDeDansLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(155)))));
            this.tipuriDeDansLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipuriDeDansLabel.ForeColor = System.Drawing.Color.White;
            this.tipuriDeDansLabel.Location = new System.Drawing.Point(7, 35);
            this.tipuriDeDansLabel.Margin = new System.Windows.Forms.Padding(3);
            this.tipuriDeDansLabel.Name = "tipuriDeDansLabel";
            this.tipuriDeDansLabel.Size = new System.Drawing.Size(264, 26);
            this.tipuriDeDansLabel.TabIndex = 22;
            this.tipuriDeDansLabel.Text = "Tipuri de dansuri";
            this.tipuriDeDansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipuriDeDansListBox
            // 
            this.tipuriDeDansListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(155)))));
            this.tipuriDeDansListBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipuriDeDansListBox.ForeColor = System.Drawing.Color.White;
            this.tipuriDeDansListBox.FormattingEnabled = true;
            this.tipuriDeDansListBox.ItemHeight = 16;
            this.tipuriDeDansListBox.Location = new System.Drawing.Point(7, 67);
            this.tipuriDeDansListBox.Name = "tipuriDeDansListBox";
            this.tipuriDeDansListBox.Size = new System.Drawing.Size(264, 212);
            this.tipuriDeDansListBox.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(155)))));
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(283, 26);
            this.menuStrip1.TabIndex = 20;
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
            // TipuriDeDansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 287);
            this.Controls.Add(this.tipuriDeDansLabel);
            this.Controls.Add(this.tipuriDeDansListBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TipuriDeDansForm";
            this.Text = "Tipuri De Dans";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipuriDeDansLabel;
        private System.Windows.Forms.ListBox tipuriDeDansListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
    }
}