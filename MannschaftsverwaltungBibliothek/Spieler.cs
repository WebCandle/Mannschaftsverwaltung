#region Dateikopf
// Datei:       Spieler.cs
// Klasse:      Spieler
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Spieler : Person
    {
        #region Eigenschaften
        private int _Nummer;
        #endregion

        #region Accessoren/Modifiers
        public int Nummer { get => _Nummer; set => _Nummer = value; }
        #endregion

        #region Konstruktoren
        public Spieler() : base()
        {
            Nummer = 0;
            Name = "<Neuer Spieler>";
        }
        public Spieler(Spieler spieler) : base(spieler)
        {
            Nummer = spieler.Nummer;
        }
        public Spieler(string name, int alt, Geschlecht geschlecht, int nummer) : base(name,alt,geschlecht)
        {
            Nummer = nummer;
        }
        #endregion

        #region Worker
        public void NummerAendern(int nummer)
        {
            Nummer = nummer;
        }
        #endregion
    }
}
