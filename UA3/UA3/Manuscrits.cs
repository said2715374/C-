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
        public List<string> languesTraduction = new List<string>();

        public Manuscrits(string titre, string resume, int code, double prix, string dateDexpedition, string etager, int Case, string auteur, string langueOriginal) : base(titre, resume, code, prix, dateDexpedition)
        {
            this.NumeroCase = Case;
            this.Etagere = etager;
            this.Auteur = auteur;
            this.LangueOriginal = langueOriginal;
            this.Disponible = 1;
        }

        public override string ToString()
        {
            return base.ToString()+"Auteur : "+Auteur+"\n"+
                                    "Langue Original : "+LangueOriginal;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public void AjouterLangueTraduction(string langue)
        {
            languesTraduction.Add(langue);
        }

        public List<string> GetLanguesTraduction()
        {
            return languesTraduction;
        }

    }
}
