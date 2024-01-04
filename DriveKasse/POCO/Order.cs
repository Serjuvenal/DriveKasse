using System.Collections.Generic;

namespace DriveKasse
{
    public class Order
    {
        private int _orderid;
        private string _abholtort;
        private string _essenplatz;
        private double _betrag;
        private string _uhrzeit;
        private List<Artikel> _bestellung;
        private string _status;

        public int OrderID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        public string Abholort
        {
            get { return _abholtort; }
            set { _abholtort = value; }
        }
        public string Essenplatz
        {
            get { return _essenplatz; }
            set { _essenplatz = value; }
        }
        public double Betrag
        {
            get { return _betrag; }
            set { _betrag = value; }
        }
        
        public string Uhrzeit
        {
            get { return _uhrzeit; }
            set { _uhrzeit = value; }
        }
        public List<Artikel> Bestellung
        {
            get { return _bestellung; }
            set { _bestellung = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
