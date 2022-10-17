using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Semestral
{
    [Serializable()]
    public class Turnaj : INotifyPropertyChanged // Obsahuje constructor a property.
    {
        private string _nazev;
        private string _typ;
        private int _vyhra;

        public string Nazev
        {
            get { return _nazev; }
            set
            {
                if (_nazev != value)
                {
                    _nazev = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Typ
        {
            get { return _typ; }
            set
            {
                if (_typ != value)
                {
                    _typ = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Vyhra
        {
            get { return _vyhra; }
            set
            {
                if (_vyhra != value)
                {
                    _vyhra = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BindingList<Hrac> HranyTurnaj { get; private set; } = new BindingList<Hrac>();

        public Turnaj(string nazev, string typ, int vyhra)
        {
            Nazev = nazev;
            Typ = typ;
            Vyhra = vyhra;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
