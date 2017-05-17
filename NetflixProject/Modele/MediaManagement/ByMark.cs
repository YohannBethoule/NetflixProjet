using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    class ByMark : IComparer<Media>
    {
        public int Compare(Media x, Media y)
        {
            return x.NoteMoyenne.CompareTo(y.NoteMoyenne);
        }
    }
}
