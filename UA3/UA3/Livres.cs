using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Livres : Documents, Iresume
    {



        public override string ToString()
        {
            return base.ToString();
        }
        public void AfficheResume()
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
