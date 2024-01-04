using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveKasse
{
    public class Artikel
    {
		private double _artikelPreis;
        private string _artikelId;
		private string _bezeichnung;
		private int _menge;
        private double _total;

        
        public string ArtikelID
        {
            get { return _artikelId; }
            set { _artikelId = value; }
        }

        public int Menge
        {
            get { return _menge; }
            set { _menge = value; }
        }
        public string ArtikelBezeichnung
        {
            get { return _bezeichnung; }
            set { _bezeichnung = value; }
        }

        public double ArtikelPreis
        {
            get { return _artikelPreis; }
            set { _artikelPreis = value; }
        }
        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
