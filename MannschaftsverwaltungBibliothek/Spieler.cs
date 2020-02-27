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
    public abstract class Spieler : Person
    {
        #region Eigenschaften
        private int _Nummer;
        private int _Erfolg;
        #endregion

        #region Accessoren/Modifiers
        public int Nummer { get => _Nummer; set => _Nummer = value; }
        public int Erfolg { get => _Erfolg; set => _Erfolg = value; }
        #endregion

        #region Konstruktoren
        public Spieler() : base()
        {
            Nummer = 0;
            Name = "<Neuer Spieler>";
            Erfolg = 0;
        }
        public Spieler(Spieler spieler) : base(spieler)
        {
            Nummer = spieler.Nummer;
            Erfolg = spieler.Erfolg;
        }
        
        public Spieler(string name, int alt, Geschlecht geschlecht, int nummer, int erfolg) : base(name,alt,geschlecht)
        {
            Nummer = nummer;
            Erfolg = erfolg;
        }
        #endregion

        #region Worker
        public int CompareByErfolg(Spieler spieler)
        {
            if( Erfolg > spieler.Erfolg)
            {
                return 1;
            } else if (Erfolg == spieler.Erfolg)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public override int CompareByName(Person person)
        {
            return string.Compare(Name, person.Name);
        }
        #endregion
    }
}
