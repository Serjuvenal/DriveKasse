using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveKasse
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int TestSchalter = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (TestSchalter == 0) Application.Run(new Anmeldung());
            else if (TestSchalter == 1) Application.Run(new Warenkorb());
            else if (TestSchalter == 2) Application.Run(new Kasse());
        }
    }
}
