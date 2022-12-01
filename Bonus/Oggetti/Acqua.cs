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
            if (litriDaBere <= this.litri) {
                this.litri -= litriDaBere;
                Console.WriteLine("Gluglu. Rimangono " + this.litri + " litri.");
            } else {
                Console.WriteLine("Non ci sono abbastanza litri. Ne berrò solo " + this.litri + ".");
                this.litri = 0;
            }
        }

        public void Riempi(double litriDaRiempire) {
            if (litriDaRiempire <= (this.capienzaMassima - this.litri)) {
                this.litri += litriDaRiempire;
                Console.WriteLine("Glug. La bottiglia ora contiene " + this.litri + " litri.");
            }
            else {
                Console.WriteLine("Glug. La bottiglia ora contiene " + this.capienzaMassima + ",\nma " + (this.litri - this.capienzaMassima) + " litri sono straripati e ora allagano il pavimento!");
                this.litri = capienzaMassima;
            }
        }

        public void Svuota() {
            this.litri = 0;
            Console.WriteLine("Splash. La bottiglia ora è vuota.");
        }

        public override void StampaProdotto() {
            base.StampaProdotto();
            Console.Write("Contenuto in litri: ");
            Console.WriteLine(this.litri);
            Console.Write("PH: ");
            Console.WriteLine(this.ph);
            Console.Write("Sorgente: ");
            Console.WriteLine(this.sorgente);
        }
    }
}

