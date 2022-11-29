using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop {
    internal class Prodotto {
        CultureInfo japan = CultureInfo.GetCultureInfo("ja-JP"); // Per impostare gli yen come valuta

        private uint codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private float iva;

        public Prodotto() {
            var rand = new Random();
            ushort dimensioneCodice = 8;
            string codice = "";
            ushort[] arrayCodice = new ushort[dimensioneCodice - 1];
            for (int i = 0; i <= dimensioneCodice - 1; i++) {
                codice += rand.Next(10);
            }
            this.codice = UInt32.Parse(codice);
        }

        public uint GetCodice() {
            return codice;
        }
        public string GetNome() {
            return nome;
        }
        public string GetDescrizione() {
            return descrizione;
        }
        public float GetPrezzo() {
            return prezzo;
        }
        public float GetIva() {
            return iva;
        }

        public void SetCodice(uint codice) {
            throw new ArgumentException("Bzz. Il codice prodotto non può essere modificato.");
        }
        public void SetNome(string nome) {
            this.nome = nome;
        }
        public void SetDescrizione(string descrizione) {
            this.descrizione = descrizione;
        }
        public void SetPrezzo(float prezzo) {
            this.prezzo = prezzo;
        }
        public void SetIva(float iva) {
            this.iva = iva;
        }

        public float StampaPrezzoBase() {
            Console.WriteLine("Il prezzo base del prodotto è: " + string.Format(japan, "{0:C}", this.prezzo)); // 0 sta per 0 cifre decimali. C sta per Currency.
            return this.prezzo;
        }

        public float StampaPrezzoIvato() {
            float prezzoIvato = this.prezzo + (this.prezzo / 100 * iva);
            Console.WriteLine("Il prezzo del prodotto con IVA è: " + string.Format(japan, "{0:C}", prezzoIvato)); // 0 sta per 0 cifre decimali. C sta per Currency.
            return prezzoIvato;
        }

        public void StampaNomeEsteso() {
            Console.WriteLine(this.codice + this.nome);
        }
    }
}
