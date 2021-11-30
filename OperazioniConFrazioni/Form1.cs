using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperazioniConFrazioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<TextBox> boxes; //creo una lista di tutte le textbox sulla base della classe TextBox
        int num1,num2,den1, den2;

       private void Form1_Load(object sender, EventArgs e)
        {
            boxes = new List<TextBox>() { tNum1, tNum2, tNum3, tDen1, tDen2, tDen3 }; //inserisco le textbox nella lista
        }

        private void tNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (e.KeyChar == '-' && t.Text.Length == 0) return;
            if (char.IsDigit(e.KeyChar) || e.KeyChar==8) return;
            e.KeyChar = (char)0;
        }
        
      

     

        private void Operazione(object sender, EventArgs e)
        {   //istanzio un oggetto B (bottone pulsante) sulla classe Button; quindi B assume le proprietà della classe Button
            Button B = (Button)sender;//con sender gestisco contemporaneamente tutti i button
            if (B.Name == "bOff") this.Close();// se ho premuto  il button con proprietà Name bOff...
            if (B.Name == "bReset")
            {
                foreach (TextBox t in boxes)//cancella tutte le textbox, senza scrivere textbox1.text="", textbox2.text=""....
                {
                    t.Clear();
                }

                lRisultato.Text = "Risultato";
                boxes[0].Focus();//il cursore si posiziona sulla prima textbox (con indice 0)
                return;
                }

            if (!Controlla())
                {   
                    tNum1.Focus(); 
                    return; 
                }
            Frazioni fraz1 = new Frazioni(num1, den1);
            Frazioni fraz2 = new Frazioni(num2, den2);
            if (B.Name == "bSomma")
            {  
                Frazioni somma = fraz1 + fraz2;
                tNum3.Text = somma.GetNumeratore();
                tDen3.Text = somma.GetDenominatore();
                lRisultato.Text = "Somma";
                return;
            }

            if (B.Name == "bDifferenza")
            {
                Frazioni differenza = fraz1 - fraz2;
                tNum3.Text = differenza.GetNumeratore();
                tDen3.Text = differenza.GetDenominatore();
                lRisultato.Text = "Differenza";
                return;
            }
            if (B.Name == "bProdotto")
            {
                Frazioni prodotto = fraz1 * fraz2;
                tNum3.Text = prodotto.GetNumeratore();
                tDen3.Text = prodotto.GetDenominatore();
                lRisultato.Text = "Prodotto";
                return;
            }
            if (B.Name == "bRapporto")
            {
                Frazioni rapporto = fraz1 / fraz2;
                tNum3.Text = rapporto.GetNumeratore();
                tDen3.Text = rapporto.GetDenominatore();
                lRisultato.Text = "Rapporto";
            }

        
        }

        private bool Controlla()
        {
            if (tNum1.Text == "" || tNum2.Text == "")
            {
                MessageBox.Show("Numeri non inseriti", this.Text);
                return false;
            }
            if (tDen1.Text == "") tDen1.Text = "1";
            if (tDen2.Text == "") tDen2.Text = "1";
            den1 = Convert.ToInt32(tDen1.Text);
            den2 = Convert.ToInt32(tDen2.Text);
            if (den1 * den2 == 0)
            {
                MessageBox.Show("il denominatore non può essere uguale a 0", this.Text);
                return false;
            }
            num1 = Convert.ToInt32(tNum1.Text);
            num2 = Convert.ToInt32(tNum2.Text);
            return true;
        }

    }
}
