using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Utilisateur
    {
        public string Pseudo { get; private set; }

        public Utilisateur(string pseudo)
        {
            Pseudo = pseudo;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            return ((Utilisateur)obj).Pseudo.Equals(Pseudo);
        }
    }
}
