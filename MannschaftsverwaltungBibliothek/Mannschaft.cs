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
        private List<Person> _Mitglieder;
        #endregion

        #region Accessoren/Modifiers
        public string Name { get => _Name; set => _Name = value; }
        public List<Person> Mitglieder { get => _Mitglieder; set => _Mitglieder = value; }
        #endregion

        #region Konstruktoren
        public Mannschaft()
        {
            Name = "<Neue Mannschaft>";
            Mitglieder = new List<Person>();
        }
        public Mannschaft(string name, List<Person> personen)
        {
            Name = name;
            Mitglieder = personen;
        }
        #endregion

        #region Worker
        public void MitgliedAnnehmen(Person person)
        {
            Mitglieder.Add(person);
        }
        public void MitgliedEntlassen(Person person)
        {
            Mitglieder.Remove(person);
        }
        public void SortMitgliederByName()
        {

        }
        #endregion
    }
}
