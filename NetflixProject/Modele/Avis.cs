using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Avis
    {
        public double Note
        {
            get;
            private set;
        }

        public string Commentaire { get; private set; }

        public Utilisateur U { get; private set; }

        public Media M { get; private set; }

        public Avis(double note, Utilisateur u, Media m)
        {
            Note = note;
            Commentaire = null;
            U = u;
            M = m;
        }

        public Avis(double note, string commentaire, Utilisateur u, Media m)
        {
            Note = note;
            Commentaire = commentaire;
            U = u;
            M = m;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            if (((Avis)obj).U != U) return false;
            if (((Avis)obj).M != M) return false;
            return true;
        }
    }
}
