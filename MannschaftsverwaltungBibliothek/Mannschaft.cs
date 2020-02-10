#region Dateikopf
// Datei:       Mannschaft.cs
// Klasse:      Mannschaft
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Mannschaft
    {
        #region Eigenschaften
        private string _Name;
        private Trainer _Trainer;
        private List<Physiotherapeut> _Physiotherapeuten;
        private List<FussballSpieler> _FussballSpielers;
        #endregion

        #region Accessoren/Modifiers
        public string Name { get => _Name; set => _Name = value; }
        public Trainer Trainer { get => _Trainer; set => _Trainer = value; }
        public List<Physiotherapeut> Physiotherapeuten { get => _Physiotherapeuten; set => _Physiotherapeuten = value; }
        public List<FussballSpieler> FussballSpielers { get => _FussballSpielers; set => _FussballSpielers = value; }
        #endregion

        #region Konstruktoren
        public Mannschaft()
        {
            Name = "<Neue Mannschaft>";
            Trainer = new Trainer();
            Physiotherapeuten = new List<Physiotherapeut>();
            FussballSpielers = new List<FussballSpieler>();
        }
        public Mannschaft(Mannschaft mannschaft)
        {
            Name = mannschaft.Name;
            Trainer = mannschaft.Trainer;
            Physiotherapeuten = mannschaft.Physiotherapeuten;
            FussballSpielers = mannschaft.FussballSpielers;
        }
        public Mannschaft(string name, Trainer trainer, List<Physiotherapeut> physiotherapeuten, List<FussballSpieler> fussballSpielers)
        {
            Name = name;
            Trainer = trainer;
            Physiotherapeuten = physiotherapeuten;
            FussballSpielers = fussballSpielers;
        }
        #endregion

        #region Worker
        public void SpielerAnnehmen(FussballSpieler spieler)
        {
            FussballSpielers.Add(spieler);
        }
        public void SpielerEntlassen(FussballSpieler spieler)
        {
            FussballSpielers.Remove(spieler);
        }
        public void VereinWechseln(Verein verein)
        {

        }
        #endregion
    }
}
