using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    class ByName:IComparer<Media>
    {
        public int Compare(Media x, Media y)
        {
            return x.Titre.CompareTo(y.Titre);
        }
    }
}
