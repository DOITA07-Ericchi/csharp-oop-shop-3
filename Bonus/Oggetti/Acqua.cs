using System;
using System.Runtime.CompilerServices;
using CSharpShop;

namespace CSharpShop2 {
    public class Acqua : Prodotto{
        private double capienzaMassima = 1.5;
        private double litri;
        private double ph;
        private string sorgente;

        public Acqua(double capienzaMassima, double litri, double ph, string sorgente, string codice, string nome, string descrizione, string prezzo, float iva) : base(codice) {
            
        }

        public void Bevi(double litriDaBere) {
            if (litriDaBere <= this.litri){
                this.litri -= litriDaBere;
                Console.WriteLine("Gluglu. Rimangono " + this.litri + " litri.");
            } else {
                Console.WriteLine("Non ci sono abbastanza litri. Ne berrò solo " + this.litri + ".");
                this.litri = 0;
            }
        }
    }
}

