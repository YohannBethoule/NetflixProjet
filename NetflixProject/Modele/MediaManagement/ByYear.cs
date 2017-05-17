using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    class ByYear:IComparer<Media>
    {
        public int Compare(Media x, Media y)
        {
            return x.AnneeDeSortie.CompareTo(y.AnneeDeSortie);
        }
    }
}
