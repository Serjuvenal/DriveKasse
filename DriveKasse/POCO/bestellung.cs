using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveKasse
{
    public class bestellung
    {
		private List<string> _id;
		private List<int> _ianzahl;
		private string _zeitstempel;
		private string _essenplatz;
		private string _abholort;
		private int _bestellnummer;
		private string _preis;
		private string _status;

		public List<string> id
		{
			get { return _id; }
			set { _id = value; }
		}
        public List<int> ianzahl
        {
            get { return _ianzahl; }
            set { _ianzahl = value; }
        }
        public string zeitstempel
        {
            get { return _zeitstempel; }
            set { _zeitstempel = value; }
        }
        public string essenplatz
        {
            get { return _essenplatz; }
            set { _essenplatz = value; }
        }
        public string abholort
        {
            get { return _abholort; }
            set { _abholort = value; }
        }
        public int bestellnummer
        {
            get { return _bestellnummer; }
            set { _bestellnummer = value; }
        }
        public string preis
        {
            get { return _preis; }
            set { _preis = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
