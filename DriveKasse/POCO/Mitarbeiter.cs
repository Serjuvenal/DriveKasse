using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DriveKasse
{
    public class Mitarbeiter
    {
        public string Name { get; private set; }

        public string PersonalID { get; private set; }

        public string PersonalKW { get; private set; }

        public Mitarbeiter(string name, string personalId, string personalKw)
        {
            Name = name;
            PersonalID = personalId;
            PersonalKW = personalKw;
        }



    }
}
