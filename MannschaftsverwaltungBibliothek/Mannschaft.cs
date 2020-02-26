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
        private List<Person> _Personen;
        #endregion

        #region Accessoren/Modifiers
        public string Name { get => _Name; set => _Name = value; }
        public List<Person> Personen { get => _Personen; set => _Personen = value; }
        #endregion

        #region Konstruktoren
        public Mannschaft()
        {
            Name = "<Neue Mannschaft>";
            Personen = new List<Person>();
        }
        public Mannschaft(string name, List<Person> personen)
        {
            Name = name;
            Personen = personen;
        }
        #endregion

        #region Worker
        public void PersonAnnehmen(Person person)
        {
            Personen.Add(person);
        }
        public void PersonEntlassen(Person person)
        {
            Personen.Remove(person);
        }
        #endregion
    }
}
