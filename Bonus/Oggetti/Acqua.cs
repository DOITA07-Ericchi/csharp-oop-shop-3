using System;
using System.Runtime.CompilerServices;
using CSharpShop;
using CSharpShop3.Eccezioni;

namespace CSharpShop2 {
    public class Acqua : Prodotto {
        private double capienzaMassima = 1.5;
        public double CapienzaMassima { get => capienzaMassima; set => capienzaMassima = value; }
        private double litri;
        public double Litri { get => litri; set => litri = value; }
        private double? ph;
        private string? sorgente;

        public Acqua() {

        }

        public void SetPh(double ph) {
            if (this.ph == null) {
                if (this.ph < 0 || this.ph > 10) {
                    throw new ArgumentException("Bzz. Il PH non è valido.");
                }
                this.ph = ph;
            } else {
                throw new ArgumentException("Bzz. Il PH non può essere modificato.");
            }
        }

        public void SetSorgente(string sorgente) {
            if (this.sorgente == null) {
                this.sorgente = sorgente;
            }
            else {
                throw new ArgumentException("Bzz. Il PH non può essere modificato.");
            }
        }

        public double? GetPh(){
            return this.ph;
        }

        public string? GetSorgente(){
            return sorgente;
        }

        public Acqua(string codice, string nome, string descrizione, float prezzo, float iva, double capienzaMassima, double litri, double ph, string sorgente) : base(codice, nome, descrizione, prezzo, iva) {
            this.capienzaMassima = capienzaMassima;
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }

        public void Bevi(double litriDaBere) {
            if (litriDaBere <= this.litri) {
                this.litri -= litriDaBere;
                Console.WriteLine("Gluglu. Rimangono " + this.litri + " litri.");
            } else {
                throw new AcquaFinitaException("Non ci sono abbastanza litri.");
                this.litri = 0;
            }
        }

        public void Riempi(double litriDaRiempire) {
            if (litriDaRiempire <= (this.capienzaMassima - this.litri)) {
                this.litri += litriDaRiempire;
                Console.WriteLine("Glug. La bottiglia ora contiene " + this.litri + " litri.");
            } else {
                throw new AcquaFinitaException("Povera bottiglia, l'hai riempita troppo.");
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

        public static double convertiInGalloni(double litri) {
            const double galloni = 3.785;
            litri = litri * galloni;
            return litri;
        }
	}
}

