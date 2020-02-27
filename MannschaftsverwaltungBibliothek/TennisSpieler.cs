#region Dateikopf
// Datei:       TennisSpieler.cs
// Klasse:      TennisSpieler
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class TennisSpieler : Spieler
    {
        #region Eigenschaften
        private int _Score;
        #endregion

        #region Accessoren/Modifiers
        public int Score { get => _Score; set => _Score = value; }
        #endregion

        #region Konstruktoren
        public TennisSpieler() : base()
        {
            Name = "<Neuer TennisSpieler>";
        }
        public TennisSpieler(TennisSpieler tennisspieler) : base(tennisspieler)
        {

        }
        public TennisSpieler(string name, int alt, Geschlecht geschlecht, int nummer,int erfolg) : base(name, alt, geschlecht, nummer,erfolg)
        {

        }
        #endregion

        #region Worker
        public void ScoreAendern(int score)
        {
            Score = score;
        }
        public void VereinWechseln( Verein verein)
        {

        }
        #endregion
    }
}
