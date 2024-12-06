using Sottoclassi_eCommerce;

namespace Sottoclassi_eCommerce
{
    class Carrello
    {
        private string identificativo;

        private List<Prodotto> prodotti;

        public List<Prodotto> Prodotti
        {
            get { return prodotti; }
        }
        public string Identificativo
        {
            get { return identificativo; }
        }
        public void aggiungiProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodotti.Add(prodotto);
        }
        public void rimuoviProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            prodotti.Remove(prodotto);
        }
        public void rimuoviProdottoVistaInClasse(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            int pos = prodotti.IndexOf(prodotto);
            if (pos != -1)
                prodotti.RemoveAt(pos);
        }
        public void svuotaCarrello()
        {
            prodotti.Clear();
        }

        public void rimuoviUltimo(int posizione)
        {
            prodotti.RemoveAt(posizione);
        }

        public Carrello(string identificativo)
        {
            this.identificativo = identificativo;
            prodotti = new List<Prodotto>();
        }
    }
}

