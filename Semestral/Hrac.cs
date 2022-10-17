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
    public class Hrac : INotifyPropertyChanged
    {
        private string _jmeno;
        private string _prijmeni;
        private string _pohlavi;
        private int _rokNarozeni;
        private int _vyhral;

        public string Jmeno
        {
            get { return _jmeno; }
            set
            {
                if (_jmeno != value)
                {
                    _jmeno = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Prijmeni
        {
            get { return _prijmeni; }
            set
            {
                if (_prijmeni != value)
                {
                    _prijmeni = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Pohlavi
        {
            get { return _pohlavi; }
            set
            {
                if(_pohlavi != value)
                {
                    _pohlavi = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int RokNarozeni
        {
            get { return _rokNarozeni; }
            set
            {
                if (_rokNarozeni != value)
                {
                    _rokNarozeni = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Vyhral
        {
            get { return _vyhral; }
            set
            {
                if (_vyhral != value)
                {
                    _vyhral = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Hrac(string jmeno, string prijmeni, string pohlavi, int rokNarozeni, int vyhral)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Pohlavi = pohlavi;
            RokNarozeni = rokNarozeni;
            Vyhral = vyhral;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
