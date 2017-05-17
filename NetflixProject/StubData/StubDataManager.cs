using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;

namespace StubData
{
    public class StubDataManager : Modele.MediaManager
    {
        public StubDataManager() : base(StubData.Charge())
        {

        }

        public override string ToString()
        {
            string s;
            s = "Titre     Producteur     Genre     Année de sortie\n";
            foreach (Modele.Media m in CurrentList)
            {
                s = s + $"{m.Titre}     {m.Producteur}     {m.Genre}     {m.AnneeDeSortie}\n";
            }
            return s;
        }
    }
}
