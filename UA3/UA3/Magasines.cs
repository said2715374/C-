using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Magasines : Documents
    {
      

        public string Categories { get; set; }
        public string Article {  get; set; }

        public Magasines(string titre, string resume, int code, double prix, string dateDexpedition, string etager, int Case,string categories, string article) : base(titre, resume, code, prix, dateDexpedition)
        {
            this.NumeroCase = Case;
            this.Etagere = etager;
            Categories = categories;
            Article = article;
        }

        public override string ToString()
        {
            return base.ToString()+"Categorie : "+Categories+"\n"+
                                    "Article : "+Article;
        }

      

        public override bool Disponibilite()
        {
            throw new NotImplementedException();
        }

        
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
