using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUmsatz.Model
{
    public class Umsatz
    {
        public string Datum { get; set; }
        public string Beschreibung { get; set; }
        public string Bankname { get; set; }
        public decimal Betrag { get; set; }

        public bool Bezahlt { get; set; }

    }

}
