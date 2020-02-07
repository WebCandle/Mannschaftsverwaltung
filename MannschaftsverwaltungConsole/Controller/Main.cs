#region Dateikopf
// Datei:       Main.cs
// Klasse:      Start
// Datum:      06.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Mannschaftsverwaltung;

namespace MannschaftsverwaltungConsole
{
    class Start
    {
        static void Main(string[] args)
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
