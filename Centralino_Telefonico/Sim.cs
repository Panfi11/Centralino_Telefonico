using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralino_Telefonico
{
    public class Sim
    {
        private static long UltimoSerialUtilizzato = 0;

        public long Seriale { get; private set; }

        public string NumeroTelefono { get; private set; }

        public double Credito { get; private set; }

        public List<Telefonata> Telefonate { get; private set; } = new List<Telefonata>();

        public Sim(string numeroTelefono, double credito)
        {
            NumeroTelefono = NumeroTelefono;
            Credito = credito;
            Seriale = GeneraSeriale();
        }
        private static long GeneraSeriale()
        {
            return +UltimoSerialUtilizzato;
        }

        public Telefonata Chiama(string numero, DateTime data, int durata)
        {
            Telefonata t = new Telefonata(data, durata, numero);
            Telefonate.Add(t);
            return t;
        }

        public int CalcolaMinutiTotali(string numeri)
        {
            int somma = 0;
            foreach (Telefonata t in Telefonate)
            {
                somma += t.DurataInSecondi;
            }
            return somma / 60;
        }
        public string StampaElenchiChiamate()
        {
            string s = "";
            foreach(Telefonata t in Telefonate.OrderBy())
            {
                s += t.ToString() + "\n";
            }
            return s;

        }
    }
}
