﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mannschaftsverwaltung;

namespace MannschaftsverwaltungConsole
{
    public class Terminal
    {
        public void ManschaftsmitgliederAnzeigen(Mannschaft mannschaft)
        {
            ConsoleTable table = new ConsoleTable();
            table.SetHeaders("Name", "Alt", "Typ");
            foreach (var item in mannschaft.Mitglieder)
            {
                string typ = item.GetType().ToString();
                var t = typ.Split('.');
                table.AddRow(item.Name, item.Alt.ToString(), t[1]);
            }
            Console.WriteLine(table.ToString());
        }
    }
}
