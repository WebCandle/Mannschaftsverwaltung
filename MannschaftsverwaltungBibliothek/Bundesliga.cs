#region Dateikopf
// Datei:       Bundesliga.cs
// Klasse:      Bundesliga
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Bundesliga : Turnier
    {
        #region Eigenschaften
        private List<Verein> _Vereine;
        #endregion

        #region Accessoren/Modifiers
        public List<Verein> Vereine { get => _Vereine; set => _Vereine = value; }
        #endregion

        #region Konstruktoren
        public Bundesliga() : base()
        {
            Vereine = new List<Verein>();
        }
        public Bundesliga(Bundesliga bundesliga) : base(bundesliga)
        {
            Vereine = bundesliga.Vereine;
        }
        public Bundesliga(string standort, DateTime datum, List<Verein> vereine) : base(standort,datum)
        {
            Vereine = vereine;
        }
        #endregion

        #region Worker
        #endregion
    }
}
