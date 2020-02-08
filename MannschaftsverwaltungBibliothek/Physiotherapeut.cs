#region Dateikopf
// Datei:       Physiotherapeut.cs
// Klasse:      Physiotherapeut
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Physiotherapeut : Person
    {
        #region Eigenschaften
        #endregion

        #region Accessoren/Modifiers
        #endregion

        #region Konstuktoren
        public Physiotherapeut() : base()
        {
            Name = "<Neuer Physiotherapeut>";
        }
        public Physiotherapeut(Physiotherapeut physiotherapeut) : base(physiotherapeut)
        {

        }
        public Physiotherapeut(string name, int alt, Geschlecht geschlecht) : base(name, alt, geschlecht)
        {

        }
        #endregion
    }
}
