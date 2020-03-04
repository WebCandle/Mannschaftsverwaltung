#region Dateikopf
// Datei:       Trainer.cs
// Klasse:      Trainer
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Trainer : Person
    {
        #region Eigenschaften
        private decimal _Gehalt;
        private string _Spielplan;
        #endregion

        #region Accessoren/Modifiers
        public decimal Gehalt { get => _Gehalt; set => _Gehalt = value; }
        public string Spielplan { get => _Spielplan; set => _Spielplan = value; }
        #endregion

        #region Konstruktoren
        public Trainer() : base()
        {
            Name = "<Neuer Trainer>";
        }
        public Trainer(Trainer trainer) : base(trainer)
        {
            Gehalt = trainer.Gehalt;
            Spielplan = trainer.Spielplan;
        }
        public Trainer(string name, int alt, Geschlecht geschlecht, decimal gehalt, string plan) : base(name, alt, geschlecht)
        {
            Gehalt = gehalt;
            Spielplan = plan;
        }
        #endregion

        #region Worker
        public void MannschaftAufstellen(Mannschaft mannschaft)
        {
        }
        public void PlanBestimmen(string spielplan)
        {
            Spielplan = spielplan;
        }
        public override int CompareByName(Person person)
        {
            return string.Compare(Name, person.Name);
        }
        #endregion
    }
}
