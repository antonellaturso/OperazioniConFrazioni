using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperazioniConFrazioni
{
    class Frazioni
    {
        int Numeratore=0, Denominatore=1;
        public Frazioni() // se istanzio la classe senza parametri numeratore=0 e denominatore=1
        {}
        public Frazioni(int par_numeratore, int par_denominatore)
        {
            Numeratore = par_numeratore;
            Denominatore = par_denominatore;
            semplifica();
        }
        static public Frazioni operator +(Frazioni F1, Frazioni F2)
        {
            int DenomSomma = F1.Denominatore * F2.Denominatore;
            int NumSomma = (DenomSomma / F1.Denominatore) * F1.Numeratore + (DenomSomma / F2.Denominatore) * F2.Numeratore;
            return new Frazioni(NumSomma, DenomSomma);
        }

        static public Frazioni operator -(Frazioni F1, Frazioni F2)
        {
            int DenomSomma = F1.Denominatore * F2.Denominatore;
            int NumSomma = (DenomSomma / F1.Denominatore) * F1.Numeratore - (DenomSomma / F2.Denominatore) * F2.Numeratore;
            return new Frazioni(NumSomma, DenomSomma);
        }

        static public Frazioni operator *(Frazioni F1, Frazioni F2)
        {
            int DenomProdotto = F1.Denominatore * F2.Denominatore;
            int NumProdotto = F1.Numeratore*F2.Numeratore;
            return new Frazioni(NumProdotto, DenomProdotto);

        }
        static public Frazioni operator /(Frazioni F1, Frazioni F2)
        {
            int DenomProdotto = F1.Denominatore * F2.Numeratore;
            int NumProdotto = F1.Numeratore * F2.Denominatore;
            return new Frazioni(NumProdotto, DenomProdotto);
        }

        public string GetNumeratore()
        {
            return Numeratore.ToString();
        }
        public string GetDenominatore()
        {
           if (Denominatore == 1 || Numeratore==0)
            {
                return "";
            }
            else
            { return Denominatore.ToString();
            }
            
        }

       
      void semplifica()
        {   
            int maxDivisore;
            if (Numeratore > Denominatore)
            { 
                maxDivisore = maxcomdiv(Numeratore, Denominatore);
            }
            else
            { 
                maxDivisore = maxcomdiv(Denominatore, Numeratore);
            }
            Numeratore /= maxDivisore;
            Denominatore /= maxDivisore;
        }
      int maxcomdiv(int max, int min)
         {
          //Massimo Comune Divisore: presi 2 numeri a e b, (a>b) rappresenta il valore massimo per cui
          // entrambi i numeri sono esattamente divisibili
          //ciclo brutale da 1 al più piccolo dei due parametri 
          //int value=1;
          //for (int i = 1; i <= (n1 < n2 ? n1 : n2); i++)
          //{
          //    if (n1 % i == 0 && n2 % i == 0) value = i;
          //}
          //return value;
             int resto;
             if (min == 0) return max;
             do
             {
                 resto = max % min;
                 max = min;
                 min = resto;
             } while (resto != 0);

             return max;
         }
    }
}
