using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPP_Opdrachtenreeks_Groen
{
    public partial class Taxikosten_1 : Form
    {
        public Taxikosten_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Naam_applicatie.Text = "Taxibedrijf ITVitae";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dag_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Bereken_ritprijs_Click(object sender, EventArgs e)
        {
            string dag = this.Dag.Text.ToLower();
            bool geldige_dag = dag == "maandag" || dag == "dinsdag" || dag == "woensdag" || dag == "donderdag" || dag == "vrijdag" || dag == "zaterdag" || dag == "zondag";

            string kilometer_tekst = this.Aantal_gereden_kilometers.Text;
            bool km_digitsOnly = kilometer_tekst.All(char.IsDigit);
            int aantal_kilometers = 0;

            string begintijd_uren_tekst = this.Begintijd_uren.Text;
            bool begintijd_uren_digitsOnly = begintijd_uren_tekst.All(char.IsDigit);
            int begintijd_uren = 0;

            string begintijd_minuten_tekst = this.Begintijd_minuten.Text;
            bool begintijd_minuten_digitsOnly = begintijd_minuten_tekst.All(char.IsDigit);
            int begintijd_minuten = 0;

            string eindtijd_uren_tekst = this.Eindtijd_uren.Text;
            bool eindtijd_uren_digitsOnly = eindtijd_uren_tekst.All(char.IsDigit);
            int eindtijd_uren = 0;

            string eindtijd_minuten_tekst = this.Eindtijd_minuten.Text;
            bool eindtijd_minuten_digitsOnly = eindtijd_uren_tekst.All(char.IsDigit);
            int eindtijd_minuten = 0;

            if (dag == "" || geldige_dag == false)
            {
                MessageBox.Show("Er is geen geldige dag ingevuld. Vul een geldige dag in.");
            }

            if (km_digitsOnly == false)
            {
                MessageBox.Show("Er zijn geen geheel aantal kilometers ingevuld. Probeer het opnieuw.");
            }

            if (km_digitsOnly == true && kilometer_tekst.Length > 0)
            {
                aantal_kilometers = Convert.ToInt32(kilometer_tekst);
            }

            if (begintijd_uren_digitsOnly == false)
            {
                MessageBox.Show("Er zijn geen geheel aantal beginuren ingevuld. Probeer het opnieuw.");
            }

            if (begintijd_uren_digitsOnly == true && begintijd_uren_tekst.Length > 0)
            {
                begintijd_uren = Convert.ToInt32(begintijd_uren_tekst);
            }

            if (begintijd_minuten_digitsOnly == false)
            {
                MessageBox.Show("Er zijn geen geheel aantal beginminuten ingevuld. Probeer het opnieuw.");
            }

            if (begintijd_minuten_digitsOnly == true && begintijd_minuten_tekst.Length > 0)
            {
                begintijd_minuten = Convert.ToInt32(begintijd_minuten_tekst);
                /*
                if(begintijd_minuten == 0)
                {
                    begintijd_minuten = 60;
                }
                */
            }

            if (eindtijd_uren_digitsOnly == false)
            {
                MessageBox.Show("Er zijn geen geheel aantal einduren ingevuld. Probeer het opnieuw.");
            }

            if (eindtijd_uren_digitsOnly == true && eindtijd_uren_tekst.Length > 0)
            {
                eindtijd_uren = Convert.ToInt32(eindtijd_uren_tekst);
            }

            if (eindtijd_minuten_digitsOnly == false)
            {
                MessageBox.Show("Er zijn geen geheel aantal eindminuten ingevuld. Probeer het opnieuw.");
            }

            if (eindtijd_minuten_digitsOnly == true && eindtijd_minuten_tekst.Length > 0)
            {
                eindtijd_minuten = Convert.ToInt32(eindtijd_minuten_tekst);
                /*
                if(eindtijd_minuten == 0)
                {
                    eindtijd_minuten = 60;
                }
                */
            }

            if (begintijd_uren > eindtijd_uren)
            {
                MessageBox.Show("Het aantal beginuren is hoger dan het aantal einduren. Vul nieuwe waarden in.");
            }

            if ((0 <= begintijd_uren && begintijd_uren <= 23) == false)
            {
                MessageBox.Show("Het aantal beginuren moet tussen de 0 en 23 liggen. Probeer het opnieuw.");
            }

            if ((0 <= eindtijd_uren && eindtijd_uren <= 23) == false)
            {
                MessageBox.Show("Het aantal einduren moet tussen de 0 en 23 liggen. Probeer het opnieuw.");
            }

            if ((0 <= begintijd_minuten && begintijd_minuten <= 59) == false)
            {
                MessageBox.Show("Het aantal beginminuten moet tussen de 0 en 59 liggen. Probeer het opnieuw.");
            }

            if ((0 <= eindtijd_minuten && eindtijd_minuten <= 59) == false)
            {
                MessageBox.Show("Het aantal eindminuten moet tussen de 0 en 59 liggen. Probeer het opnieuw.");
            }

            else
            {
                MessageBox.Show("Begintijd uren = " + begintijd_uren.ToString());
                double ritprijs = 0;
                if(dag == "vrijdag" || dag == "zaterdag" || dag == "zondag" || dag == "maandag")
                {

                }
                //MessageBox.Show("Huidige ritprijs = " + kilometer_prijs + " euro");
                // Message
            }
        }
    }
}
