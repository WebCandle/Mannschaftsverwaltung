using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mannschaftsverwaltung;
using System.Xml.Serialization;
using System.IO;

namespace MannschaftsverwaltungConsole
{
    public class Controller
    {
        private Bundesliga _Bundesliga;
        private Terminal _Terminal;
        public Terminal Terminal { get => _Terminal; set => _Terminal = value; }
        public Bundesliga Bundesliga { get => _Bundesliga; set => _Bundesliga = value; }

        public Controller()
        {
            Mannschaft mannschaft = new Mannschaft();
            Trainer trainer1 = new Trainer();
            trainer1.Name = "Maher Al Abbasi";
            mannschaft.MitgliedAnnehmen(trainer1);

            Physiotherapeut physio1 = new Physiotherapeut();
            physio1.Name = "Wolfgang Stupp";
            mannschaft.MitgliedAnnehmen(physio1);

            FussballSpieler fussballSpieler1 = new FussballSpieler();
            fussballSpieler1.Name = "Lional Messi";
            mannschaft.MitgliedAnnehmen(fussballSpieler1);

            FussballSpieler fussballSpieler2 = new FussballSpieler();
            fussballSpieler2.Name = "Ronaldo";
            mannschaft.MitgliedAnnehmen(fussballSpieler2);

            Verein verein = new Verein();
            verein.MannschaftAnmelden(mannschaft);
            Bundesliga = new Bundesliga("Deutschland", DateTime.Now, new List<Verein>(), DateTime.Now);
            Bundesliga.VereinAnmelden(verein);

            
        }
        public void Run()
        {
            Terminal.ManschaftsmitgliederAnzeigen(Bundesliga.Vereine.First().Mannschaften.First());
        }
        public void Sichern()
        {
            

            //Speichern vom Objekt Bundesliga
            XmlSerializer SR = new XmlSerializer(typeof(Bundesliga));
            FileStream FS = new FileStream("Bundesliga.xml", FileMode.Create);
            SR.Serialize(FS, Bundesliga);
            FS.Close();
        }
    }
}
