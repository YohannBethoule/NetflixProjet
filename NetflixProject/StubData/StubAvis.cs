using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;

namespace StubData
{
    public class StubAvis : AvisManager
    {
        public StubAvis(MediaManager m) : base(ChargerAvis(m))
        { }

        public static List<Avis> ChargerAvis(MediaManager m)
        {
            List<Avis> l = new List<Avis>();

            Avis a1 = new Avis(2, new Utilisateur("User1"), m.GetRandom());
            Avis a2 = new Avis(1, new Utilisateur("User1"), m.GetRandom());
            Avis a3 = new Avis(4, new Utilisateur("User1"), m.GetRandom());
            Avis a4 = new Avis(1.5, new Utilisateur("User2"), m.GetRandom());
            Avis a5 = new Avis(2, new Utilisateur("User3"), m.GetRandom());
            Avis a6 = new Avis(3, "Commentaire", new Utilisateur("User3"), m.GetRandom());
            Avis a7 = new Avis(4.5, "Commentaire", new Utilisateur("User4"), m.GetRandom());
            Avis a8 = new Avis(2.5, "Commentaire", new Utilisateur("User5"), m.GetRandom());

            return l;
        }
        
        public void AfficherListe(List<Avis> l)
        {
            foreach(Avis a in l)
            {
                Console.WriteLine($"Note donnée par {a.U.Pseudo} concernant {a.M.Titre} : {a.Note}");
            }
        }
    }
}
