using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_H2_sommehus_winforms
{
    public class SommerhusData
    {
        public string EjerId { get; set; }
        public string Navn { get; set; }
        public string ByNavn { get; set; }
        public string VejNavn { get; set; }
        public decimal Pris { get; set; }
        public string Område { get; set; }
        public string Inspektør { get; set; }

    }
    public class SommerhusejereData
    {
        public string Navn { get; set; }
        public string tlf { get; set; }
        public string email { get; set; }

    }
}
