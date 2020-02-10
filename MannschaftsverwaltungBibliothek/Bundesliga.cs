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
        private DateTime _Saison;
        #endregion

        #region Accessoren/Modifiers
        public List<Verein> Vereine { get => _Vereine; set => _Vereine = value; }
        public DateTime Saison { get => _Saison; set => _Saison = value;  }
        #endregion

        #region Konstruktoren
        public Bundesliga() : base()
        {
            Vereine = new List<Verein>();
        }
        public Bundesliga(Bundesliga bundesliga) : base(bundesliga)
        {
            Vereine = bundesliga.Vereine;
            Saison = bundesliga.Saison;
        }
        public Bundesliga(string standort, DateTime datum, List<Verein> vereine, DateTime saison) : base(standort,datum)
        {
            Vereine = vereine;
            Saison = saison;
        }
        #endregion

        #region Worker
        public void VereineAufstellen()
        {

        }
        public void VereinAnmelden(Verein verein)
        {
            Vereine.Add(verein);
        }
        public void VereinAbmelden(Verein verein)
        {
            Vereine.Remove(verein);
        }
        #endregion
    }
}
