using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sottoclassi_eCommerce
{
    class Prodotto : IEquatable<Prodotto>
    {
        private string marca;
        private string modello;
        private double prezzo;
        private string identificativo;
        private double prezzoEffettivo;

        public string Marca
        {
            get { return marca; }
        }
        public string Modello
        {
            get { return modello; }
        }
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }
        public string Identificativo
        {
            get { return identificativo; }
        }

        public double PrezzoEffettivo
        {
            get { return prezzoEffettivo; }
            set { prezzoEffettivo = value; }
        }

        public Prodotto(string marca, string modello, string identificativo, double prezzo)
        {
            this.marca = marca;
            this.modello = modello;
            this.identificativo = identificativo;
            this.prezzo = prezzo;
            prezzoEffettivo = CalcolaPrezzoEffettivo();
        }

        virtual public double CalcolaPrezzoEffettivo()
        {
            return prezzo;
        }

        public bool Equals(Prodotto other)
        {
            if (other == null)
                return false;

            if (this == other)
                return true;

            return Identificativo.Equals(other.Identificativo);
        }

    }

}
