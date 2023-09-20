
namespace ConvertisseurMonnaies
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMonnaie = new System.Windows.Forms.ComboBox();
            this.txtMonnaie = new System.Windows.Forms.TextBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonnaie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMonnaie
            // 
            this.cboMonnaie.FormattingEnabled = true;
            this.cboMonnaie.Location = new System.Drawing.Point(12, 29);
            this.cboMonnaie.Name = "cboMonnaie";
            this.cboMonnaie.Size = new System.Drawing.Size(157, 24);
            this.cboMonnaie.TabIndex = 0;
            this.cboMonnaie.SelectedIndexChanged += new System.EventHandler(this.cboMonnaie_SelectedIndexChanged);
            // 
            // txtMonnaie
            // 
            this.txtMonnaie.Enabled = false;
            this.txtMonnaie.Location = new System.Drawing.Point(12, 113);
            this.txtMonnaie.Name = "txtMonnaie";
            this.txtMonnaie.Size = new System.Drawing.Size(157, 22);
            this.txtMonnaie.TabIndex = 1;
            // 
            // txtValeur
            // 
            this.txtValeur.Enabled = false;
            this.txtValeur.Location = new System.Drawing.Point(199, 29);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(161, 22);
            this.txtValeur.TabIndex = 2;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(12, 69);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(157, 22);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monnaie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valeur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "€";
            // 
            // lblMonnaie
            // 
            this.lblMonnaie.AutoSize = true;
            this.lblMonnaie.Location = new System.Drawing.Point(139, 121);
            this.lblMonnaie.Name = "lblMonnaie";
            this.lblMonnaie.Size = new System.Drawing.Size(0, 17);
            this.lblMonnaie.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 149);
            this.Controls.Add(this.lblMonnaie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.txtMonnaie);
            this.Controls.Add(this.cboMonnaie);
            this.Name = "Form1";
            this.Text = "Convertisseur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMonnaie;
        private System.Windows.Forms.TextBox txtMonnaie;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonnaie;
    }
}

