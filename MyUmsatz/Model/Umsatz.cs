using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUmsatz.Model
{
    public class Umsatz
    {

        public string? DatumVon { get; set; }
        public string? DatumBis { get; set; }
        public string? Beschreibung { get; set; }
        public string? Bank { get; set; }
        public decimal? Betrag { get; set; }

    }

}
