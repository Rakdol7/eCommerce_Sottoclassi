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
            label4.Text = Convert.ToString(0);
            label5.Text = Convert.ToString(0);
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
            label4.Text = Convert.ToString(prodotto.Prezzo + Convert.ToDouble(label4.Text));
            label5.Text = Convert.ToString(prodotto.PrezzoEffettivo + Convert.ToDouble(label5.Text));

        }

        private void Svuota_Click(object sender, EventArgs e)
        {
            carrello.svuotaCarrello();
            Carrello.Items.Clear();
            label4.Text = Convert.ToString(0);
            label5.Text = Convert.ToString(0);
        }

        private void Rimuovi_Click(object sender, EventArgs e)
        {
            int indice = Carrello.SelectedIndex;
            carrello.rimuoviProdotto(carrello.Prodotti[indice]);
            Carrello.Items.Remove(Carrello.SelectedItem);
            label4.Text = Convert.ToString(Convert.ToDouble(label4.Text) - prodotto.Prezzo);
            label5.Text = Convert.ToString(Convert.ToDouble(label5.Text) - prodotto.PrezzoEffettivo);
        }
    }
}
