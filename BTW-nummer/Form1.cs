using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace BTW_nummer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*=======Analyse Stap 1======

*1. Invoer: Welke invoer mag je verwachten voor jouw functie? Geef zowel een naam/beschrijving als een datatype.
        een BTW nummer - string
*
*2a. Bewerking: Hoe ga je bepalen of de invoer correct is qua vorm? Welke reguliere expressie ga je hiervoor gebruiken?
        ^BE[0-9]{4}\.[0-9]{3}\.[0-9]{3}$
*

*2b. Hoe ga je bepalen of de invoer correct is qua inhoud? Hoe bepaal je de eerste 8 cijfers en de laatste 2? Welke stappen ga je hiervoor doorlopen?
        als 97 - (restdeling van eerste 8 cijfers door 97) = de laatste 2 cijfers
*

*3. Uitvoer: Welke uitvoer zal de functie geven? Geef zowel een naam/beschrijving als een datatype.
        true or false
*

*4.  Naamgeving: Welke naam ga je je eigen functie geven?
        ControleVorm en ControleInhoud
*
*==========Testdata=========

*5. Testdata: Verzin en noteer (of zoek op internet) testgegevens voor alle mogelijke gevallen. Zo weet je of je oefening klopt.
        BE0400.378.485 - true
        BE0461.325.268 - true
        BE0400.378.486 - false
        BE0400.378.4 - false
        NL040037848 - false
*

*===========================*/
        private void button1_Click(object sender, EventArgs e)
        {
            string BtwNummer = Convert.ToString(BtwNummerTextBox.Text);
            if (ControleVorm(BtwNummer))
            {
                if (ControleInhoud(BtwNummer))
                {
                    JuistOfFoutLabel.Text = "Juist";
                    JuistOfFoutLabel.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    JuistOfFoutLabel.Text = "Fout";
                    JuistOfFoutLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                JuistOfFoutLabel.Text = "Fout";
                JuistOfFoutLabel.ForeColor = System.Drawing.Color.Red;
            }

        }


        private bool ControleVorm(string BtwNummer)
        {
            string BtwNummerPatroon = @"^BE[0-9]{4}\.[0-9]{3}\.[0-9]{3}$";
            return Regex.IsMatch(BtwNummer, BtwNummerPatroon);
        }


        private bool ControleInhoud(string BtwNummer)
        {
            string BtwAlleenCijfers = BtwNummer.Replace(".", "");
            int Eerste8Nummers = Convert.ToInt32(BtwAlleenCijfers.Substring(2, 8));
            int Laatste2Nummers = Convert.ToInt32(BtwAlleenCijfers.Substring(10, 2));
            return ((97 - (Eerste8Nummers % 97)) == Laatste2Nummers);
        }
    }
}
