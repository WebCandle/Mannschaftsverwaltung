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
        #endregion

        #region Accessoren/Modifiers
        #endregion

        #region Konstruktoren
        public Trainer() : base()
        {
            Name = "<Neuer Trainer>";
        }
        public Trainer(Trainer trainer) : base(trainer)
        {

        }
        public Trainer(string name, int alt, Geschlecht geschlecht) : base(name, alt, geschlecht)
        {

        }
        #endregion
    }
}
