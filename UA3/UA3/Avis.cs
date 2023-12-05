using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Avis 
    {
        public string Commentaire { get; set; }
        public int Note { get; set; }

        public Avis(string commentaire, int note)
        {
            Commentaire = commentaire;
            Note = note;
        }
    }
}
