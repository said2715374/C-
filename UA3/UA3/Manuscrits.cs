using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Manuscrits : Documents
    {
       

        public string Auteur {  get; set; }
        public string LangueOriginal { get; set; }

        public Manuscrits(string titre, string resume, int code, double prix, string dateDexpedition, string etager, int Case, string auteur, string langueOriginal) : base(titre, resume, code, prix, dateDexpedition)
        {
            this.NumeroCase = Case;
            this.Etagere = etager;
            this.Auteur = auteur;
            this.LangueOriginal = langueOriginal;
        }

        public override string ToString()
        {
            return base.ToString()+"Auteur : "+Auteur+"\n"+
                                    "Langue Original : "+LangueOriginal;
        }

        public override void AfficheResume()
        {
            throw new NotImplementedException();
        }

        public override bool Disponibilite()
        {
            throw new NotImplementedException();
        }

        public override void Emplacement()
        {
            throw new NotImplementedException();
        }
    }
}
