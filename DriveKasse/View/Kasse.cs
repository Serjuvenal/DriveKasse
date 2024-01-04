using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveKasse
{
    public partial class Kasse : Form
    {
        public Order fertig = new Order();
        public double KasseSumme;
        private List<Artikel> _preorder;
        public int _orderid_ks;
        private string _zeitstempel;
        private bool bezahlt = false;
        public string Zeitstempel
        {
            get { return _zeitstempel; }
            set { _zeitstempel = value; }
        }
        public int OrderID_KS
        {
            get { return _orderid_ks; }
            set { _orderid_ks = value; }
        }

        public List<Artikel> Preorder
        {
            get { return _preorder; }
            set { _preorder = value; }
        }
        public Kasse()
        {
            InitializeComponent();
        }
        private static async Task Publish_Application_Message(string _jsonMessage)
        {
            using (var _mqttClient2 = new MqttFactory().CreateMqttClient())
            {
                var _mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer("10.42.0.31", 1883)
                    .Build();

                await _mqttClient2.ConnectAsync(_mqttClientOptions, CancellationToken.None);

                var applicationMessage = new MqttApplicationMessageBuilder()
                    .WithTopic("kasse/drive") // produktion/fertig  kasse/drive
                    .WithPayload(_jsonMessage)
                    .Build();

                await _mqttClient2.PublishAsync(applicationMessage, CancellationToken.None);

                await _mqttClient2.DisconnectAsync();
            }
        }

        private static Control ActiveControl2 = new Control();
        private void btn_ks_null_Click(object sender, EventArgs e)
        {
            Speichern();
            Button btn = (Button)sender;
            ActiveControl2.Focus();
            SendKeys.Send(btn.Text);
            Speichern();
        }
        private void Speichern()
        {
            if (tb_kasse_gegeben.Text == "0")
            {
                tb_kasse_gegeben.Text = null;
            }
        }
        private void BarRueckgeldRechnen()
        {
            double summe = Convert.ToDouble(tb_kasse_summe.Text);
            double gegeben = Convert.ToDouble(tb_kasse_gegeben.Text);
            if (gegeben < summe)
            {
                MessageBox.Show("Differenz!", "ERROR", MessageBoxButtons.OK);
                tb_kasse_gegeben.Text = "0";
                bezahlt = false;
            }
            else if (gegeben >= summe)
            {
                double rueckgeld = gegeben - summe;
                tb_kasse_rueckgeld.Text = rueckgeld.ToString();
                MessageBox.Show("Ruckgeld: " + rueckgeld.ToString(), "Zahlung erfolgreich", MessageBoxButtons.OK);
                bezahlt = true;
            }
            KasseSumme = summe;
        }
        private void tb_kasse_gegeben_Enter(object sender, EventArgs e)
        {
            ActiveControl2 = (Control)sender;
        }
        private void btn_ks_clear_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = "";
        }
        private void btn_ks_barzahlung_Click(object sender, EventArgs e)
        {
            BarRueckgeldRechnen();
            if (bezahlt == true)
            {
                EndBestellung();
                //Zurück in WK
                using (Warenkorb wk = new Warenkorb())
                {
                    OrderID_KS++;
                    wk.OrderID_WK = OrderID_KS;
                    wk.ShowDialog();
                    
                }
            }
        }
        private void btn_ks_eczahlung_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = tb_kasse_summe.Text;
            KasseSumme = Convert.ToDouble(tb_kasse_summe.Text);
            EndBestellung();
            using (Warenkorb wk = new Warenkorb())
            {
                OrderID_KS++;
                wk.OrderID_WK = OrderID_KS;
                wk.ShowDialog();
            }
        }
        private string ZeitstempelHinzufuegen()
        {
            Zeitstempel = DateTime.Now.ToString("HH:mm:ss");
            return Zeitstempel;
        }
        private void Kasse_Load(object sender, EventArgs e)
        {
            tb_kasse_summe.Text = KasseSumme.ToString();
        }
        public bestellung OrderGenerieren()
        {
            bestellung _bestellung = new bestellung();
            List<string> ids = new List<string>();
            List<int> menge = new List<int>();
            for (int i = 0; i < Preorder.Count; i++)
            {
                ids.Add(Preorder[i].ArtikelID);
                menge.Add(Preorder[i].Menge);
            }
            _bestellung.id = ids;
            _bestellung.ianzahl = menge;
            _bestellung.zeitstempel = ZeitstempelHinzufuegen();
            _bestellung.essenplatz = "DriveIn";
            _bestellung.abholort = "DriveIn";
            if (OrderID_KS == 0)
            {
                OrderID_KS = 200;
            }
            _bestellung.bestellnummer = OrderID_KS;
            _bestellung.preis = KasseSumme.ToString();
            _bestellung.status = "in Bearbeitung"; // "Fertig" "in Bearbeitung"
            return _bestellung;
        }
        private string OrderToJString(bestellung _order)
        {
            string _jsonorder = JsonConvert.SerializeObject(_order);
            return _jsonorder;
        }
        private void btn_ks_fuenfeuro_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = "5";
            BarRueckgeldRechnen();
            if (bezahlt == true)
            {
                EndBestellung();
                using (Warenkorb wk = new Warenkorb())
                {
                    OrderID_KS++;
                    wk.OrderID_WK = OrderID_KS;
                    wk.ShowDialog();
                    
                }
            }
        }
        private void btn_ks_zehneuro_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = "10";
            BarRueckgeldRechnen();
            if (bezahlt == true)
            {
                EndBestellung();
                using (Warenkorb wk = new Warenkorb())
                {
                    OrderID_KS++;
                    wk.OrderID_WK = OrderID_KS;
                    wk.ShowDialog();
                }
            }
        }
        private void btn_ks_zwanzigeuro_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = "20";
            BarRueckgeldRechnen();
            if (bezahlt == true)
            {
                EndBestellung();
                using (Warenkorb wk = new Warenkorb())
                {
                    OrderID_KS++;
                    wk.OrderID_WK = OrderID_KS;
                    wk.ShowDialog();
                }
            }
        }
        private void btn_ks_fuenfzigeuro_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = "50";
            BarRueckgeldRechnen();
            if (bezahlt == true)
            {
                EndBestellung();
                using (Warenkorb wk = new Warenkorb())
                {
                    OrderID_KS++;
                    wk.OrderID_WK = OrderID_KS;
                    wk.ShowDialog();
                }
            }
        }
        private void btn_ks_hunderteuro_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = "100";
            BarRueckgeldRechnen();
            if (bezahlt == true)
            {
                EndBestellung();
                using (Warenkorb wk = new Warenkorb())
                {
                    OrderID_KS++;
                    wk.OrderID_WK = OrderID_KS;
                    wk.ShowDialog();
                }
            }
        }
        private void btn_ks_zweihunderteuro_Click(object sender, EventArgs e)
        {
            tb_kasse_gegeben.Text = "200";
            BarRueckgeldRechnen();
            if (bezahlt == true)
            {
                EndBestellung();
                using (Warenkorb wk = new Warenkorb())
                {
                    OrderID_KS++;
                    wk.OrderID_WK = OrderID_KS;
                    wk.ShowDialog();
                }
            }
        }
        private void EndBestellung()
        {
            bestellung _order = OrderGenerieren();
            string _bestellt = OrderToJString(_order);
            Publish_Application_Message(_bestellt);
            MessageBox.Show("Bestellungsnummer: " + (OrderID_KS) ,"Bestellung abgeschlossen!", MessageBoxButtons.OK);
            this.Hide();
        }
    }
}
