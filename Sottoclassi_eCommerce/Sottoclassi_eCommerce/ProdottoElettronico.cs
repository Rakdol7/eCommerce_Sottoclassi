using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sottoclassi_eCommerce
{
    internal class ProdottoElettronico: Prodotto
    {
        private double sconto;

        public double Sconto
        {
            get { return sconto; }
        }

        public ProdottoElettronico(string marca, string modello, string identificativo, double prezzo) : base(marca, modello, identificativo, prezzo)
        {
            sconto = 0.9;
            PrezzoEffettivo = CalcolaPrezzoEffettivo();
        }

        override public double CalcolaPrezzoEffettivo()
        {
            return Prezzo * sconto;
        }
    }
}
