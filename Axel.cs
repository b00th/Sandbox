using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Axel
    {
        public string Model;
        public string Farve;
        public string Årgang;
        public Axel(string ModelNavn, string FarveKode, string Årgang)
        {
            this.Model = ModelNavn;
            this.Farve = FarveKode;
            this.Årgang = Årgang;
        }
    }
}
