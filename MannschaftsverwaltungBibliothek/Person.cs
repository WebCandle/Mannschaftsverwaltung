#region Dateikopf
// Datei:       Person.cs
// Klasse:      Person
// Datum:      06.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public abstract class Person
    {
        #region Eigenschaften
        private string _Name;
        private int _Alt;
        private Geschlecht _Geschlecht;
        #endregion

        #region Accessor/Modifiers
        public string Name { get => _Name; set => _Name = value; }
        public int Alt { get => _Alt; set => _Alt = value; }
        public Geschlecht Geschlecht { get => _Geschlecht; set => _Geschlecht = value; }
        #endregion

        #region Konstruktoren
        public Person()
        {
            Name = "";
            Alt = 0;
            Geschlecht = Geschlecht.Maenlich;
        }
        public Person(Person person)
        {
            Name = person.Name;
            Alt = person.Alt;
            Geschlecht = person.Geschlecht;
        }
        public Person(string name, int alt, Geschlecht geschlecht)
        {
            Name = name;
            Alt = alt;
            Geschlecht = geschlecht;
        }
        #endregion

        #region Worker
        public abstract int CompareByName( Person person);
        #endregion
    }
}
