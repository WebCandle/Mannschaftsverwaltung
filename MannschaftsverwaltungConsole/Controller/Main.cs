#region Dateikopf
// Datei:       Main.cs
// Klasse:      Programm
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
    class Programm
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Run();
            //controller.Sichern();

            Console.ReadKey();
        }
    }
}
