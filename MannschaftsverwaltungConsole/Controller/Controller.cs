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
            Trainer trainer = new Trainer();
            FussballSpieler fussballSpieler = new FussballSpieler();
            mannschaft.MitgliedAnnehmen(trainer);
            mannschaft.MitgliedAnnehmen(fussballSpieler);

            Verein verein = new Verein();
            verein.MannschaftAnmelden(mannschaft);
            Bundesliga = new Bundesliga("Deutschland", DateTime.Now, new List<Verein>() { verein }, DateTime.Now);

            
        }
        public void Run()
        {
            Terminal.ManschaftsmitgliederAnzeigen(Bundesliga.Vereine.ElementAt(0).Mannschaften.ElementAt(0));
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
