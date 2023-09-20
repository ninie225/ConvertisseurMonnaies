using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertisseurMonnaies
{
    public partial class Form1 : Form
    {
        struct sMonnaie
        {
            public string nom;
            public float valeur;
            public string signe;
        }

        private sMonnaie[] tMonnaie = new sMonnaie[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialisation du tableau de structure contenant les monnaies
            //Dollar américain
            tMonnaie[0].nom = "Dollar américain";
            tMonnaie[0].valeur = 0.85f;
            tMonnaie[0].signe = "$";

            //Livre sterling
            tMonnaie[1].nom = "Livre sterling";
            tMonnaie[1].valeur = 1.17f;

            //Yen japonais
            tMonnaie[2].nom = "Yen japonais";
            tMonnaie[2].valeur = 0.0073f;
            tMonnaie[2].signe = "¥";

            //Dollar canadien
            tMonnaie[3].nom = "Dollar canadien";
            tMonnaie[3].valeur = 0.67f;
            tMonnaie[3].signe = "$";

            //Franc suisse
            tMonnaie[4].nom = "Franc suisse";
            tMonnaie[4].valeur = 0.92f;
            tMonnaie[4].signe = "CHF";

            //Dinar tunisien
            tMonnaie[5].nom = "Dinar tunisien";
            tMonnaie[5].valeur = 0.3f;
            tMonnaie[5].signe = "د.ت";

            //Dirham marocain
            tMonnaie[5].nom = "Dirham marocain";
            tMonnaie[5].valeur = 0.089f;
            tMonnaie[5].signe = "د.م";

            //remplissage du combo cboMonnaie avec les monnaies
            for (int i=0; i<tMonnaie.Length; i++)
            {
                cboMonnaie.Items.Add(tMonnaie[i].nom);
            }

            //Sélection première monnaie
            cboMonnaie.SelectedIndex = 0;

            //Initialisation à 1 euro
            txtEuro.Text = "1";
        }

        private void txtEuro_TextChanged(object sender, EventArgs e)
        {
            //On essaye de récupérer la saisie en Euro si elle est dans un format correct
            try
            {
                lblMonnaie.Text = tMonnaie[cboMonnaie.SelectedIndex].signe;
                float val= tMonnaie[cboMonnaie.SelectedIndex].valeur;
                txtMonnaie.Text = (float.Parse(txtEuro.Text) * val).ToString();
                txtValeur.Text = val.ToString();
            }
            catch(Exception ex)
            {
                txtMonnaie.Text = "";
            }
        }

        private void cboMonnaie_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEuro_TextChanged(null, null);
        }
    }
}
