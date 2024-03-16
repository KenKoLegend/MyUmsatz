using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyUmsatz.Model;

namespace MyUmsatz.ViewModel
{
    public class UmsatzViewModel
    {
        public ObservableCollection<Umsatz> Umsaetze { get; set; }


        public UmsatzViewModel()
        {
            Umsaetze = UmsatzManager.GetUmsatz();



        }
    }
}
