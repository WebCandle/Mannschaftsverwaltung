#region Dateikopf
// Datei:       FussballSpieler.cs
// Klasse:      FussballSpieler
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class FussballSpieler : Spieler
    {
        #region Eigenschaften
        private bool _Ersatzmann;
        private Position _Position;
        #endregion

        #region Accessoren/Modifiers
        public bool Ersatzmann { get => _Ersatzmann; set => _Ersatzmann = value; }
        public Position Position { get => _Position; set => _Position = value; }
        #endregion

        #region Konstruktorn
        public FussballSpieler() : base()
        {
            Ersatzmann = false;
            Name = "<Neuer FussballSpieler>";
        }
        public FussballSpieler(FussballSpieler fussballSpieler) : base(fussballSpieler)
        {
            Ersatzmann = fussballSpieler.Ersatzmann;
        }
        public FussballSpieler(string name, int alt, Geschlecht geschlecht, int nummer, bool ersatzmann,int erfolg) : base(name, alt, geschlecht,nummer,erfolg)
        {
            Ersatzmann = ersatzmann;
        }
        #endregion

        #region Worker
        public void PositionAendern(Position position)
        {
            Position = position;
        }
        public void SpielerUmtauchen()
        {
            Ersatzmann = !Ersatzmann;
        }
        public void MannschaftAendern(Mannschaft mannschaft)
        {

        }
        #endregion
    }
}
