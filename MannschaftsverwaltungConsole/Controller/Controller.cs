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
        public Controller()
        {

        }
        public void Run()
        {

        }
        public void Sichern()
        {
            Bundesliga bundesliga = new Bundesliga();

            //Speichern vom Objekt Bundesliga
            XmlSerializer SR = new XmlSerializer(typeof(Bundesliga));
            FileStream FS = new FileStream("Bundesliga.xml", FileMode.Create);
            SR.Serialize(FS, bundesliga);
            FS.Close();
        }
    }
}
