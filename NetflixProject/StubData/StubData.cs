using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;


namespace StubData
{
    public static class StubData
    {
        public static List<Media> Charge()
        {
            List<Media> l = new List<Media>();

            Serie s1 = new Modele.Serie("Daredevil", Genres.Comics, "Marvel", 2015);
            Serie s2 = new Modele.Serie("Orange is the new black", Genres.Thriller, "Netflix", 2014);
            Serie s3 = new Modele.Serie("Iron Fist", Genres.Comics, "Marvel", 2017);
            Serie s4 = new Modele.Serie("Black Mirror", Genres.ScienceFiction, "Des génies", 2015);

            Film f1 = new Modele.Film("Avengers", Genres.Comics, "Marvel", 2012);
            Film f2 = new Modele.Film("Avatar", Genres.ScienceFiction, "Netlix", 2009);
            Film f3 = new Modele.Film("Le nombre 23", Genres.Thriller, "Netflix", 2012);
            Film f4 = new Modele.Film("Osef", Genres.Humour, "Osef", 2011);

            l.Add(s1);
            l.Add(s2);
            l.Add(s3);
            l.Add(s4);
            l.Add(f1);
            l.Add(f2);
            l.Add(f3);
            l.Add(f4);

            return l;
        }
    }
}
