using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Serie:Media
    {
        public List<Saison> Saisons;
        
        public Serie(string titre, string genre, string producteur, int dateSortie) : base(titre, genre, producteur, dateSortie)
        { }   
        
    }
}
