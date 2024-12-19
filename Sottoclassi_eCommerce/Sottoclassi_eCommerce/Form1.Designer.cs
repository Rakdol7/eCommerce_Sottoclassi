namespace Sottoclassi_eCommerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Carrello = new ListBox();
            label1 = new Label();
            Aggiungi = new Button();
            Svuota = new Button();
            Rimuovi = new Button();
            Salva = new Button();
            Carica = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Carrello
            // 
            Carrello.FormattingEnabled = true;
            Carrello.ItemHeight = 15;
            Carrello.Location = new Point(564, 130);
            Carrello.Name = "Carrello";
            Carrello.Size = new Size(163, 199);
            Carrello.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(564, 87);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(159, 40);
            label1.TabIndex = 1;
            label1.Text = "CARRELLO";
            // 
            // Aggiungi
            // 
            Aggiungi.BackColor = Color.Lime;
            Aggiungi.Location = new Point(130, 194);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(105, 52);
            Aggiungi.TabIndex = 2;
            Aggiungi.Text = "AGGIUNGI PRODOTTO";
            Aggiungi.UseVisualStyleBackColor = false;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // Svuota
            // 
            Svuota.BackColor = Color.Black;
            Svuota.ForeColor = Color.White;
            Svuota.Location = new Point(252, 194);
            Svuota.Name = "Svuota";
            Svuota.Size = new Size(105, 52);
            Svuota.TabIndex = 3;
            Svuota.Text = "SVUOTA";
            Svuota.UseVisualStyleBackColor = false;
            Svuota.Click += Svuota_Click;
            // 
            // Rimuovi
            // 
            Rimuovi.BackColor = Color.Red;
            Rimuovi.Location = new Point(375, 194);
            Rimuovi.Name = "Rimuovi";
            Rimuovi.Size = new Size(105, 52);
            Rimuovi.TabIndex = 4;
            Rimuovi.Text = "RIMUOVI PRODOTTO";
            Rimuovi.UseVisualStyleBackColor = false;
            Rimuovi.Click += Rimuovi_Click;
            // 
            // Salva
            // 
            Salva.BackColor = Color.Cyan;
            Salva.Location = new Point(188, 252);
            Salva.Name = "Salva";
            Salva.Size = new Size(105, 52);
            Salva.TabIndex = 5;
            Salva.Text = "SALVA CARRELLO";
            Salva.UseVisualStyleBackColor = false;
            // 
            // Carica
            // 
            Carica.BackColor = Color.Cyan;
            Carica.Location = new Point(323, 252);
            Carica.Name = "Carica";
            Carica.Size = new Size(105, 52);
            Carica.TabIndex = 6;
            Carica.Text = "CARICA CARRELLO";
            Carica.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(537, 358);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 7;
            label2.Text = "TOTALE PREZZO INTERO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(519, 387);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 8;
            label3.Text = "TOTALE PREZZO SCONTATO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(684, 358);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(684, 387);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EA-FC25-69", "Nike-Felpa-60", "Blasetti-Quaderno-10" });
            comboBox1.Location = new Point(53, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Melinda-Granny Smith-4", "Chiquita-Banana-4", "Barilla-Fusilli-2" });
            comboBox2.Location = new Point(209, 130);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 23);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Nvidia-RTX 3090-500", "Phillips-270v3-100", "Oppo-A58-300" });
            comboBox3.Location = new Point(368, 130);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(152, 23);
            comboBox3.TabIndex = 13;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 112);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 14;
            label6.Text = "PRODOTTI GENERICI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(209, 112);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 15;
            label7.Text = "PRODOTTI ALIMENTARI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(368, 112);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 16;
            label8.Text = "PRODOTTI ELETTRONICI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Carica);
            Controls.Add(Salva);
            Controls.Add(Rimuovi);
            Controls.Add(Svuota);
            Controls.Add(Aggiungi);
            Controls.Add(label1);
            Controls.Add(Carrello);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Carrello;
        private Label label1;
        private Button Aggiungi;
        private Button Svuota;
        private Button Rimuovi;
        private Button Salva;
        private Button Carica;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
