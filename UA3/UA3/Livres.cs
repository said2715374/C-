using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Livres : Documents
    {
       

        public string Auteur {  get; set; }
        public int NumbreDePage { get; set; }

        public Livres(string titre, string resume, int code, double prix, string dateDexpedition, string etager, int Case, string auteur, int numbreDePage) : base(titre, resume, code, prix, dateDexpedition)
        {
            this.NumeroCase = Case;
            this.Etagere = etager;
            Auteur = auteur;
            NumbreDePage = numbreDePage;
        }


        public override string ToString()
        {
            return base.ToString()+"Auteur : "+Auteur+"\n"+
                                    "Nombre de page : "+NumbreDePage;
        }
        

        public override bool Disponibilite()
        {
            throw new NotImplementedException();
        }

        public override void Emplacement()
        {
            throw new NotImplementedException();
        }

        public override void AfficheResume()
        {
            throw new NotImplementedException();
        }
    }
}
