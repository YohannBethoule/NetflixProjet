using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;


namespace StubData
{
    public class StubMedia : MediaManager
    {
            public StubMedia() : base(ChargeMedia())
            { } 
            

            public override string ToString()
            {
                string s;
                s = "Titre     Producteur     Genre     Année de sortie\n";
                foreach (Media m in SortedObservableList)
                {
                    s = s + $"{m.Titre}     {m.Producteur}     {m.Genre}     {m.AnneeDeSortie}\n";
                }
                return s;
            }

            public static List<Media> ChargeMedia()
        {
            List<Media> l = new List<Media>();

            Serie s1 = new Modele.Serie("Serie1", "Action", "Prod1", 2010);
            Serie s2 = new Modele.Serie("Serie2", "Action", "Prod1", 2011);
            Serie s3 = new Modele.Serie("Serie3", "Action", "Prod2", 2012);
            Serie s4 = new Modele.Serie("Serie4", "Comics", "Prod1", 2009);
            Serie s5 = new Modele.Serie("AutreSerie1", "Comics", "Prod2", 2010);
            Serie s6 = new Modele.Serie("AutreSerie2", "Comics", "Prod3", 2011);
            Serie s7 = new Modele.Serie("AutreSerie3", "Science-Fiction", "Prod3", 2012);
            Serie s8 = new Modele.Serie("AutreSerie4", "Science-Fiction", "Prod4", 2009);

            Film f1 = new Modele.Film("Film1", "Comics", "Prod4", 2013);
            Film f2 = new Modele.Film("Film2", "Action", "Prod1", 2011);
            Film f3 = new Modele.Film("Film3", "Action", "Prod3", 2012);
            Film f4 = new Modele.Film("Film4", "Comics", "Prod1", 2005);
            Film f5 = new Modele.Film("AutreFilm1", "Comics", "Prod2", 20171);
            Film f6 = new Modele.Film("AutreFilm2", "Comics", "Prod1", 2011);
            Film f7 = new Modele.Film("AutreFilm3", "Science-Fiction", "Prod1", 2012);
            Film f8 = new Modele.Film("AutreFilm4", "Science-Fiction", "Prod4", 2009);

            l.Add(s1);
            l.Add(s2);
            l.Add(s3);
            l.Add(s4);
            l.Add(s5);
            l.Add(s6);
            l.Add(s7);
            l.Add(s8);
            l.Add(f1);
            l.Add(f2);
            l.Add(f3);
            l.Add(f4);
            l.Add(f5);
            l.Add(f6);
            l.Add(f7);
            l.Add(f8);


            return l;
        }

    
    }
}
