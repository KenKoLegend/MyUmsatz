using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUmsatz.Model
{
    public class UmsatzManager
    {
        public static ObservableCollection<Umsatz> _DatabaseUmsatz = new ObservableCollection<Umsatz>()

        { new Umsatz
        {
            DatumVon = "02.03.21",
            DatumBis = "02.03.28",
            Beschreibung = "Autovertragslaufzeit",
            Bank = "Sparkasse",
            Betrag = 20.23m
        }


        };
        public static ObservableCollection<Umsatz> GetUmsatz()

        { 
            return _DatabaseUmsatz; 
        }

        public static void AddUmsatz(Umsatz umsatz)
        {
            _DatabaseUmsatz.Add(umsatz);
        }
    }
}
