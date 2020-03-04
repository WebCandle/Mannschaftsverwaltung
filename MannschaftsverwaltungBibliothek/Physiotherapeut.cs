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
        private decimal _Gehalt;
        #endregion

        #region Accessoren/Modifiers
        public decimal Gehalt { get => _Gehalt; set => _Gehalt = value; }
        #endregion

        #region Konstuktoren
        public Physiotherapeut() : base()
        {
            Name = "<Neuer Physiotherapeut>";
        }
        public Physiotherapeut(Physiotherapeut physiotherapeut) : base(physiotherapeut)
        {
            Gehalt = physiotherapeut.Gehalt;
        }
        public Physiotherapeut(string name, int alt, Geschlecht geschlecht, decimal gehalt) : base(name, alt, geschlecht)
        {
            Gehalt = gehalt;
        }
        #endregion

        #region Worker
        public void Behandel(FussballSpieler spieler)
        {
        }
        public override int CompareByName(Person person)
        {
            return string.Compare(Name, person.Name);
        }
        #endregion
    }
}
