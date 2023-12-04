using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Documents
    {
        public string Titre {  get; set; }
        public string Resume { get; set; }
        public int Code { get; set; }
        public double Prix { get; set; }
        public string DateDexpedition { get; set; }
        public int NumeroCase { get; set; }
        public string Etagere { get; set; }

        public Documents(string titr, string resume, int code, double prix, string dateDexpedition)
        {
            Titre = titr;
            Resume = resume;
            Code = code;
            Prix = prix;
            DateDexpedition = dateDexpedition;
         }

    }
}
