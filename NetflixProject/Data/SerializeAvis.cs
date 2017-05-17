using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime;
using System.Collections.ObjectModel;

namespace Data
{
    class SerializeAvis
    {
        /// <summary>
        /// Méthode static permettant la sauvegarde des Meubles dans un fichier XML au lancement de l'App
        /// </summary>
        /*
        public static void SauvergarderMeubles()
        { 
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            string xmlFile = string.Format("{0}{1}", dirInfo, "meubles.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Modele.Media>));

            using (StreamWriter writer = new StreamWriter(xmlFile))
            {
                serializer.WriteObject(writer, Modele.AvisManager.AllAvis);
            }
        }*/
    }
}
