#region Dateikopf
// Datei:       Modell/Person.cs
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
    public class Person
    {
        #region Eigenschaften
        private string _Name;
        private int _Alt;
        #endregion

        #region Accessor/Modifiers
        public string Name { get => _Name; set => _Name = value; }
        public int Alt { get => _Alt; set => _Alt = value; }
        #endregion

        #region Konstruktoren
        public Person()
        {
            Name = "";
            Alt = 0;
        }
        public Person(Person person )
        {

        }
        #endregion
    }
}
