#region Dateikopf
// Datei:       Verein.cs
// Klasse:      Verein
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Verein
    {
        #region Eigenschaften
        private string _Name;
        private DateTime _Gruendungsdatum;
        private List<Mannschaft> _Mannschaften;
        #endregion

        #region Accessoren/Modifiers
        public string Name { get => _Name; set => _Name = value; }
        public DateTime Gruendungsdatum { get => _Gruendungsdatum; set => _Gruendungsdatum = value; }
        public List<Mannschaft> Mannschaften { get => _Mannschaften; set => _Mannschaften = value; }
        #endregion

        #region Konstruktoren
        public Verein()
        {
            Name = "<Neuer Verein>";
            Gruendungsdatum = DateTime.Now;
            Mannschaften = new List<Mannschaft>();
        }
        public Verein(Verein verein)
        {
            Name = verein.Name;
            Gruendungsdatum = verein.Gruendungsdatum;
            Mannschaften = verein.Mannschaften;
        }
        public Verein(string name, DateTime gruendungsdatum, List<Mannschaft> mannschaften)
        {
            Name = name;
            Gruendungsdatum = gruendungsdatum;
            Mannschaften = mannschaften;
        }
        #endregion

        #region Worker
        public void MannschaftZurueckZiehen(Mannschaft mannschaft)
        {
            Mannschaften.Add(mannschaft);
        }
        public void MannschaftenAufstellung()
        {

        }
        public void MannschaftAnmelden(Mannschaft mannschaft)
        {
            Mannschaften.Add(mannschaft);
        }
        public void MannschaftAbmelden(Mannschaft mannschaft)
        {
            Mannschaften.Remove(mannschaft);
        }
        #endregion

    }
}
