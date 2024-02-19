using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur.Models
{
    enum Couleurs { Coeur, Pique, Carreau, Trefle }
    enum Valeurs { As, Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Vallet, Reine, Roi }
    internal class Carte
    {
        public Couleurs Couleur { get; set; }
        public Valeurs Valeur { get; set; }

        public override string ToString()
        {
            return $"{Valeur} de {Couleur}";
        }
    }
}
