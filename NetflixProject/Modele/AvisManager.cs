using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class AvisManager
    {
        public List<Avis> AllAvis
        {
            get;
            private set;
        }

        public AvisManager(List<Avis> l)
        {
            AllAvis = l;
        }

        public void AjouterAvis(Avis avis)
        {
            if (AllAvis.Contains(avis))
            {
                AllAvis[AllAvis.IndexOf(avis)] = avis;
            }
            AllAvis.Add(avis);
        }

        public List<Avis> GetByMedia(Media media)
        {
            List<Avis> l = new List<Avis>();

            var query =
                from avis in AllAvis
                where avis.M.Equals(media)
                select avis;

            foreach(Avis a in query)
            {
                l.Add(a);
            }
            return l;
        }

        public List<Avis> GetByUser(Utilisateur user)
        {
            List<Avis> l = new List<Avis>();

            var query =
                from avis in AllAvis
                where avis.U.Equals(user)
                select avis;

            foreach (Avis a in query)
            {
                l.Add(a);
            }
            return l;
        }
    }
}
