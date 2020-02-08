#region Dateikopf
// Datei:       Turnier.cs
// Klasse:      Turnier
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Turnier
    {
        #region Eigenschaften
        private string _Standort;
        private DateTime _Datum;
        #endregion

        #region Accessoren/Modifiers
        public string Standort { get => _Standort; set => _Standort = value; }
        public DateTime Datum { get => _Datum; set => _Datum = value; }
        #endregion

        #region Konstruktoren
        public Turnier()
        {
            Standort = "<Neuer Standort>";
            Datum = DateTime.Now;
        }
        public Turnier(Turnier turnier)
        {
            Standort = turnier.Standort;
            Datum = turnier.Datum;
        }
        public Turnier(string standort, DateTime datum)
        {
            Standort = standort;
            Datum = datum;
        }
        #endregion
    }
}
