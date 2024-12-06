using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sottoclassi_eCommerce
{
    internal class ProdottoAlimentare : Prodotto
    {
        private int sconto;

        public int Sconto
        {
            get { return sconto; }
        }
        
        public ProdottoAlimentare(string marca, string modello, string identificativo, double prezzo, int sconto) : base(marca, modello, identificativo, prezzo)
        {
            this.sconto = sconto;
        }
    }
}
