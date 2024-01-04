using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DriveKasse
{
    public partial class Anmeldung : Form
    {
        internal List<Mitarbeiter> _pliste;
        private int _orderid_a;

        public int OrderID_A
        {
            get { return _orderid_a; }
            set { _orderid_a = value; }
        }


        public Anmeldung()
        {
            InitializeComponent();
            _pliste = LadeListe();
            tb_anm_benutzer.Text = "";
            tb_anm_kennwort.Text = "";
            tb_anm_kennwort.PasswordChar = '*';
            tb_anm_benutzer.MaxLength = 4;
            tb_anm_kennwort.MaxLength = 4;
        }

        internal List<Mitarbeiter> LadeListe()
        {
            Mitarbeiter mitarbeiter1 = new Mitarbeiter("Admin", "1379", "1379");
            Mitarbeiter mitarbeiter2 = new Mitarbeiter("Marco", "1234", "1234");
            Mitarbeiter mitarbeiter3 = new Mitarbeiter("Oliver", "4321", "4321");
            Mitarbeiter mitarbeiter4 = new Mitarbeiter("Sergio", "9731", "9731");

            List<Mitarbeiter> personalList = new List<Mitarbeiter>()

            { mitarbeiter1, mitarbeiter2, mitarbeiter3, mitarbeiter4};
            return personalList;
        }

        

        private static new Control ActiveControl = new Control();
        private void btn_anm_eins_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void tb_anm_benutzer_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void tb_anm_kennwort_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void btn_anmelden_Click(object sender, EventArgs e)
        {
            foreach (var mitarbeiter in _pliste)
            {
                if (tb_anm_benutzer.Text == mitarbeiter.PersonalID && tb_anm_kennwort.Text == mitarbeiter.PersonalKW)
                {
                    this.Hide();
                    using (Warenkorb wk = new Warenkorb())
                    {
                        TextBoxLeeren();
                        wk.Bediener = mitarbeiter.Name;
                        wk.OrderID_WK = OrderID_A;
                        wk.ShowDialog();
                    }
                }
            }
            TextBoxLeeren();
        }
        private void btn_beenden_Click(object sender, EventArgs e)
        {
            if (tb_anm_benutzer.Text == _pliste[0].PersonalID && tb_anm_kennwort.Text == _pliste[0].PersonalKW)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie ihren Administrator ID und Kennwort ein.", "ERROR", MessageBoxButtons.OK);
                TextBoxLeeren();
            }
        }
        // Loeschen und Clear noch bearbeiten
        private void btn_anm_clear_Click(object sender, EventArgs e)
        {
            TextBoxLeeren();
        }

        private void Anmeldung_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxLeeren()
        {
            tb_anm_benutzer.Text = "";
            tb_anm_kennwort.Text = "";
        }

    }
}
