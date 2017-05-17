using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    /// <summary>
    /// Media est une classe abstraite représentant un média (film ou série).
    /// </summary>
    public abstract class Media
    {
        /// <summary>
        /// Le titre du media
        /// </summary>
        public string Titre { get; private set; }

        /// <summary>
        /// Le genre cinématographique auquel appartient le média (policier, drame, humour, ...)
        /// </summary>
        public string Genre { get; private set; }

        /// <summary>
        /// Le producteur du média
        /// </summary>
        public string Producteur { get; private set; }

        /// <summary>
        /// L'année de sortie du média
        /// </summary>
        public int AnneeDeSortie { get; private set; }

        /// <summary>
        /// La moyenne des notes laissées par les utilisateurs
        /// </summary>
        public float NoteMoyenne
        {
            get { return NoteMoyenne; }
        }

    
        public Media(string titre, string genre, string producteur, int anneeDeSortie)
        {
            Titre = titre;
            Genre = genre;
            Producteur = producteur;
            AnneeDeSortie = anneeDeSortie;
        }

        public override string ToString()
        {
            return Titre;
        }

        /// <summary>
        /// Redéfinition de la méthode Equals(object obj)
        /// </summary>
        /// <param name="obj"> Un objet  </param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            return ((Media)obj).Titre.Equals(Titre);
        }
    }
}
