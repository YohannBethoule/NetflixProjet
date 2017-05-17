using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Film : Media
    {
        public string Realisateur { get; private set; }

        public int DureeMn { get; private set; }

        public Film(string titre, string genre, string producteur, int dateSortie):base(titre, genre, producteur, dateSortie)
        { }
    }
}
