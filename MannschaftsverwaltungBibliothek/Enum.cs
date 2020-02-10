#region Dateikopf
// Datei:       Enum.cs
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public enum Geschlecht
    {
        Weiblich = 1,
        Maenlich = 2
    }
    public enum Position
    {
        Stuermer = 1,
        Verteidiger = 2,
        Mittelfeld = 3,
        Torwart = 4,
    }
}
