#region Dateikopf
// Datei:       TennisSpieler.cs
// Klasse:      TennisSpieler
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class TennisSpieler : Spieler
    {
        #region Eigenschaften
        #endregion

        #region Accessoren/Modifiers
        #endregion

        #region Konstruktoren
        public TennisSpieler() : base()
        {
            Name = "<Neuer TennisSpieler>";
        }
        public TennisSpieler(TennisSpieler tennisspieler) : base(tennisspieler)
        {

        }
        public TennisSpieler(string name, int alt, Geschlecht geschlecht, int nummer) : base(name, alt, geschlecht, nummer)
        {

        }
        #endregion

        #region Worker
        #endregion
    }
}
