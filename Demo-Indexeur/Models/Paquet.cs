using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur.Models
{
    internal class Paquet
    {
        private List<Carte> _paquet = new List<Carte>();

        public void InitialiserPaquet()
        {
            _paquet.Clear();
            for (int i = 0; i < 52; i++)
            {
                _paquet.Add(new Carte()
                {
                    Couleur = (Couleurs)(i % 4),
                    Valeur = (Valeurs)(i % 13)
                });
            }
        }

        public Carte this[int position]
        {
            get {
                if (position > _paquet.Count - 1) return null;// gestion d'Exception
                return _paquet[position]; 
            }
            set {
                if (position > _paquet.Count - 1) _paquet.Add(value);
                else _paquet[position] = value; 
            }
        }

        public Carte this[Valeurs valeur, Couleurs couleur]
        {
            get
            {
                foreach (Carte carte in _paquet)
                {
                    if(carte.Couleur == couleur && carte.Valeur == valeur) return carte;
                }
                return null;
            }
        }
    }
}
