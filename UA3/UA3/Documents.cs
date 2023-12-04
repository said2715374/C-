using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal abstract class  Documents : Iresume
    {
        public string Titre {  get; set; }
        public string Resume { get; set; }
        public int Code { get; set; }
        public double Prix { get; set; }
        public string DateDexpedition { get; set; }
        public int NumeroCase { get; set; }
        public string Etagere { get; set; }

        public Documents(string titre, string resume, int code, double prix, string dateDexpedition)
        {
            Titre = titre;
            Resume = resume;
            Code = code;
            Prix = prix;
            DateDexpedition = dateDexpedition;
         }

        public override string ToString()
        {
            return "Titre : " + Titre + "\n" +
                "Code : " + Code + "\n" +
                "Prix : " + Prix + "\n" +
                "Date dexpedition : " + DateDexpedition;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public abstract void  Emplacement();
        public abstract bool Disponibilite();

        public abstract void AfficheResume();
        
    }
}
