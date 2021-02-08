using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralino_Telefonico
{
    public class Telefonata
    {
        public DateTime Data { get; private set; }

        public int DurataInSecondi { get; private set; }

        public string NumeroChiamato { get; private set; }

        public Telefonata (DateTime data, int durataSecondi, string numerochiamato)
        {
            Data = data;
            DurataInSecondi = durataSecondi;
            NumeroChiamato = numerochiamato;
        }

        public override string ToString()
        {
            return ($"chiamato {NumeroChiamato} il {Data} per{DurataInSecondi} secondi");
        }
    }
}
