using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class MediaManager : System.Collections.ObjectModel.ObservableCollection<Media>
    {
        public List<Media> AllMedias
        {
            get;
            private set;
        }
        private List<Media> SortedList;
        public ObservableCollection<Media> SortedObservableList
        {
            get
            {
                return new ObservableCollection<Media>(SortedList);
            }
        }



        public MediaManager(List<Media> DataBase):base()
        {
            AllMedias = new List<Media>(DataBase);
            SortedList = new List<Media>(AllMedias);
        }

        public void ActualiserSelection(Dictionary<Filtre, string> currentFilters, string tri)
        {

            SortedList.Clear();
             // LINQ sur all media

           foreach (Media m in AllMedias)
            {
                if(Test(m, currentFilters))
                {
                    SortedList.Add(m);
                }   
            }


            if (tri.Equals("Titre"))
            {
                //SortedList.AddRange(AllMedias.Where(t => t.Titre.Equals("Dardevil")).ToList());
                SortedList.Sort(new ByName());
            }
            if (tri.Equals("Date de sortie"))
            {
               SortedList.Sort(new ByYear());
            }
            if (tri.Equals("Note moyenne"))
            {
                SortedList.Sort(new ByMark());
            }
        }
        
        private bool Test(Media m, Dictionary<Filtre, string> filtres)
        {
            bool match = true;
            foreach(KeyValuePair<Filtre, string> entry in filtres)
            {
                switch (entry.Key)
                {
                    case Filtre.Type:
                        if (entry.Value.Equals("Serie"))
                        {
                            match = (m is Serie);
                        }
                        if (entry.Value.Equals("Film"))
                        {
                            match = (m is Film);
                        }
                        break;

                    case Filtre.Genre:
                        match = m.Genre.Equals(entry.Value);
                        break;

                    case Filtre.Producteur:
                        match = m.Producteur.Equals(entry.Value);
                        break;

                }
                if (!match)
                {
                    return false;
                }
            }
            return true;
        }
        
        public Media GetRandom()
        {
            return RandomLib.RandomizeList.GetRandom(SortedList);
        }
    }
}
