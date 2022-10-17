using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Semestral
{
    public static class Databaze
    {
        public static BindingList<Hrac> Hraci { get; private set; } = new BindingList<Hrac>();
        public static BindingList<Turnaj> Turnaje { get; private set; } = new BindingList<Turnaj>();

        static Databaze()
        {
            // Toto odkomentujte v případě odebrání .bin souborů
            /*Hraci.Add(new Hrac("Pepa", "Vomacka", "Muz", 1980, 1000));
            Hraci.Add(new Hrac("Aneta", "Ticha", "Zena", 1996, 100000));
            Hraci.Add(new Hrac("Jan", "Serial", "Muz", 1978, 52000));
            Hraci.Add(new Hrac("Petra", "Kvitova", "Zena", 1990, 153000000));

            Turnaj t = new Turnaj("WTP", "dvouhra", 5500);
            Turnaje.Add(t);
            t.HranyTurnaj.Add(new Hrac("Tomáš", "Jedno", "Muz", 1980, 100));

            Turnaje.Add(new Turnaj("wimbledon", "dvouhra", 5000));
            Turnaje.Add(new Turnaj("ATP", "dvouhra", 500));
            Turnaje.Add(new Turnaj("Melnicka liga", "ctyrhra", 300));*/

            //Serializuj();
            // Toto zakomentujte v případě odebrání .bin souborů a načítání nových.
            Deserializuj();
        }

        public static void Pridat(object hO, object tO) // Přidává hráče do turnaje
        {
            Hrac h = (Hrac)hO;
            Turnaj t = (Turnaj)tO;

            t.HranyTurnaj.Add(h);
            Hraci.Remove(h);
        }

        public static void Odebrat(object hO, object tO) // Odebírá hráče z turnaje
        {
            Hrac h = (Hrac)hO;
            Turnaj t = (Turnaj)tO;

            t.HranyTurnaj.Remove(h);
            Hraci.Add(h);
        }

        public static void Serializuj() // Serializace dat
        {
            Serializuj<Hrac>(Hraci, "hraci.bin");
            Serializuj<Turnaj>(Turnaje, "turnaje.bin");
        }

        public static void Serializuj<T>(BindingList<T> list, string soubor) // Serializace dat
        {
            using (Stream s = File.Open(soubor, FileMode.Create))
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, list);
            }
        }

        public static void Deserializuj() // Deserializace dat
        {
            Hraci = Deserializuj<Hrac>("hraci.bin");
            Turnaje = Deserializuj<Turnaj>("turnaje.bin");
        }

        public static BindingList<T> Deserializuj<T>(string soubor) // Deserializace dat
        {
            using (Stream s = File.Open(soubor, FileMode.Open))
            {
                BinaryFormatter b = new BinaryFormatter();
                return (BindingList<T>)b.Deserialize(s);
            }
        }
    }
}
