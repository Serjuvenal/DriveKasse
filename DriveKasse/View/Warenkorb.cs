using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DriveKasse
{
    public partial class Warenkorb : Form
    {
        private IMqttClient _mqttClient1;

        #region Properties
        Kasse formularkasse;
        Anmeldung formularanmeldung;

        private string _bediener;
        public string Bediener
        {
            get { return _bediener; }
            set { _bediener = value; }
        }
        private double _wksumme;

        public double WKSumme
        {
            get { return _wksumme; }
            set { _wksumme = value; }
        }

        private int _orderid_b;

        public int OrderID_WK
        {
            get { return _orderid_b; }
            set { _orderid_b = value; }
        }

        #endregion

        #region Statische Variabeln
        //Leeres Warenkorb existiert - Menge
        static int[] warenkorb = new int[14];

        //2 Dimensionelles Array (Tabelle) die Produkten
        static string[] produktid = new string[14] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14" };
        static string[] bezeichnung = new string[14] { "Hamburger", "Cheeseburger", "Chickenburger", "Vegan Burger", "Low Carb Burger", "Pommes Frites", "Kartoffelspalten", "Wasser still", "Wassel Sprudel", "Cola", "Limo", "Apfelschorle", "Ketchup", "Majo" };
        static double[] preis = new double[14] { 5.0, 5.5, 5.5, 7.0, 7.5, 2.5, 3.0, 1.5, 1.5, 2.0, 2.0, 2.0, 0.5, 0.5 };

        //Liste von Artikel die gerade in Warenkorb sind
        static List<Artikel> itemList = new List<Artikel>();

        //Status für das Ein/-Ausblenden die Ware. Ruf MB beim Abmeldung wahrend die Aufnahme einer Bestellung
        static bool inBestellung = false;
        #endregion

        public Warenkorb()
        {
            InitializeComponent();
            WarenkorbLeeren();
            VerfuegbarkeitPruefen();

            DateTime jetzt = DateTime.Now;
            lbl_wk_now.Text = jetzt.ToLongDateString();
            inBestellung = false;
        }

        private List<Artikel> BestellungsListeErzeugen()
        {
            List<Artikel> _list = new List<Artikel>();
            for (int j = 0; j < warenkorb.Length; j++)
            {
                if (warenkorb[j] > 0)
                {
                    Artikel producto = new Artikel();

                    producto.ArtikelID = produktid[j];
                    producto.ArtikelBezeichnung = bezeichnung[j];
                    producto.Menge = warenkorb[j];
                    producto.ArtikelPreis = preis[j];
                    producto.Total = producto.Menge * producto.ArtikelPreis;
                    _list.Add(producto);
                }
            }
            return _list;
        }

        private void SummeAnzeigen()
        {
            WKSumme = 0;
            for (int k = 0; k < itemList.Count; k++)
            {
                WKSumme += itemList[k].Total;
                lbl_wk_summe2.Text = WKSumme.ToString();
            }
        }

        private void GridAktualisieren()
        {
            dataGridView1.DataSource = itemList;
            SummeAnzeigen();
        }

        private void btn_wk_bestellen_Click(object sender, EventArgs e)
        {
            // Anfrage Verfügbarkeit (aktualisieren)
            if (inBestellung == true)
            {
                MessageBox.Show("Sie haben eine Bestellung noch am laufen", "Die aktuelle Bestellung abschliessen!", MessageBoxButtons.OK);
            }
            else
            {
                flp_wk_artikeln.Visible = true;
                inBestellung = true;
            }
        }

        private void btn_wk_abmelden_Click(object sender, EventArgs e)
        {
            if (inBestellung == false)
            {
                this.Hide();
                formularanmeldung = new Anmeldung();
                formularanmeldung.OrderID_A = OrderID_WK;
                formularanmeldung.Show();
            }
            else
            {
                MessageBox.Show("Sie haben eine Bestellung noch am laufen.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btn_wk_zurkasse_Click(object sender, EventArgs e)
        {
            if (WKSumme == 0)
            {
                MessageBox.Show("Es wurde noch kein Produkt ausgewählt!", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                formularkasse = new Kasse();
                formularkasse.KasseSumme = WKSumme;
                formularkasse.OrderID_KS = OrderID_WK;
                formularkasse.Preorder = itemList;
                inBestellung = false;
                formularkasse.ShowDialog();
            }
        }

        private void Warenkorb_Load(object sender, EventArgs e)
        {
            lbl_wk_mitarbeiter.Text = Bediener;
            wk_timer.Start();
            lbl_wk_verfuerbarkeit.Text = ":)";
        }

        #region artikelhinzufuegung
        private void btn_artikel01_Click(object sender, EventArgs e)
        {
            warenkorb[0]++;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel02_Click(object sender, EventArgs e)
        {
            warenkorb[1] = warenkorb[1] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel03_Click(object sender, EventArgs e)
        {
            warenkorb[2] = warenkorb[2] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artilkel04_Click(object sender, EventArgs e)
        {
            warenkorb[3] = warenkorb[3] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel05_Click(object sender, EventArgs e)
        {
            warenkorb[4] = warenkorb[4] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel06_Click(object sender, EventArgs e)
        {
            warenkorb[5] = warenkorb[5] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel07_Click(object sender, EventArgs e)
        {
            warenkorb[6] = warenkorb[6] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel08_Click(object sender, EventArgs e)
        {
            warenkorb[7] = warenkorb[7] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel09_Click(object sender, EventArgs e)
        {
            warenkorb[8] = warenkorb[8] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel10_Click(object sender, EventArgs e)
        {
            warenkorb[9] = warenkorb[9] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel11_Click(object sender, EventArgs e)
        {
            warenkorb[10] = warenkorb[10] + 1;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel12_Click(object sender, EventArgs e)
        {
            warenkorb[11]++;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel13_Click(object sender, EventArgs e)
        {
            warenkorb[12]++;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }

        private void btn_artikel14_Click(object sender, EventArgs e)
        {
            warenkorb[13]++;
            itemList = BestellungsListeErzeugen();
            GridAktualisieren();
        }
        #endregion

        private void WarenkorbLeeren()
        {
            for (int i = 0; i < warenkorb.Length; i++)
            {
                warenkorb[i] = 0;
            }
            itemList.Clear();
            WKSumme = 0;
            lbl_wk_summe2.Text = WKSumme.ToString();
        }

        private void btn_wk_loeschen_Click(object sender, EventArgs e)
        {
            WarenkorbLeeren();
            SummeAnzeigen();
            inBestellung = false;
            List<Artikel> leereListe = new List<Artikel>();
            dataGridView1.DataSource = leereListe;
        }

        private void wk_timer_Tick(object sender, EventArgs e)
        {
            lbl_wk_uhrzeit.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private async void VerfuegbarkeitPruefen()
        {
            using (var _mqttClient1 = new MqttFactory().CreateMqttClient())
            {
                var _mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer("10.42.0.31", 1883)
                    .Build();

                await _mqttClient1.ConnectAsync(_mqttClientOptions, CancellationToken.None);

                _mqttClient1.UseConnectedHandler(async _ =>
                {
                    await _mqttClient1.SubscribeAsync("wawi/bestand");
                    _mqttClient1.UseApplicationMessageReceivedHandler(e =>
                    {
                        var payload = e.ApplicationMessage.Payload;
                        var jsonMessage = Encoding.UTF8.GetString(payload);
                        lbl_wk_verfuerbarkeit.Text = jsonMessage;
                    });
                });
            }
        }
    }
}

