namespace Sottoclassi_eCommerce
{
    public partial class Form1 : Form
    {
        private Prodotto prodotto;
        private Carrello carrello;
        int id = 111111;
        int n = 0;

        public Form1()
        {
            carrello = new Carrello("121345");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodottoSelezionato = comboBox1.SelectedItem.ToString();
            string[] split = prodottoSelezionato.Split("-");

            prodotto = new Prodotto(split[0], split[1], Convert.ToString(id + n), Convert.ToDouble(split[2]));
            n++;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodottoSelezionato = comboBox2.SelectedItem.ToString();
            string[] split = prodottoSelezionato.Split("-");

            prodotto = new ProdottoAlimentare(split[0], split[1], Convert.ToString(id + n), Convert.ToDouble(split[2]));
            n++;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodottoSelezionato = comboBox3.SelectedItem.ToString();
            string[] split = prodottoSelezionato.Split("-");

            prodotto = new ProdottoElettronico(split[0], split[1], Convert.ToString(id + n), Convert.ToDouble(split[2]));
            n++;
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            carrello.aggiungiProdotto(prodotto);
            Carrello.Items.Add(prodotto.Marca + " " + prodotto.Modello + " " + prodotto.PrezzoEffettivo+"€");
        }

        private void Svuota_Click(object sender, EventArgs e)
        {
            carrello.svuotaCarrello();
            Carrello.Items.Clear();
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            int indice = Carrello.SelectedIndex;
            carrello.rimuoviProdotto(carrello.Prodotti[indice]);
            Carrello.Items.Remove(Carrello.SelectedItem);
        }
    }
}
