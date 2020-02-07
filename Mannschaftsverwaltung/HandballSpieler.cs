﻿#region Dateikopf
// Datei:       HandballSpieler.cs
// Klasse:      HandballSpieler
// Datum:      07.02.2020
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class HandballSpieler : Spieler
    {
        #region Eigenschaften
        private bool _Ersatzmann;
        #endregion

        #region Accessoren/Modifiers
        public bool Ersatzmann { get => _Ersatzmann; set => _Ersatzmann = value; }
        #endregion

        #region Konstruktoren
        public HandballSpieler() : base()
        {
            Ersatzmann = false;
            Name = "<Neuer HandballSpieler>";
        }
        public HandballSpieler(HandballSpieler handballSpieler) : base(handballSpieler)
        {
            Ersatzmann = handballSpieler.Ersatzmann;
        }
        public HandballSpieler(string name, int alt, Geschlecht geschlecht, int nummer, bool ersatzmann) : base(name, alt, geschlecht, nummer)
        {
            Ersatzmann = ersatzmann;
        }
        #endregion

        #region Worker
        #endregion
    }
}
