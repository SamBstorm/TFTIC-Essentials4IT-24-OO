using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Proprietes.Models
{
    internal class Login
    {
        #region Champs / Variables membres
        private string _motDePasse; 
        #endregion

        public string MotDePasse
        {
            private get
            {
                return this._motDePasse;
            } //Accès à la donnée
            set {
                if(this._motDePasse is null)
                {
                    this._motDePasse = value;
                }
            } //L'enregistrement de nouvelle valeur à la donnée
        }

        public string Email { get; set; }
        

        /* Méthode devenue inutile car utilisation de la propriété
        public void DefinirMotDePasse(string motDePasse)
        {
            if(this._motDePasse is null) this._motDePasse = motDePasse;
        }*/

        public bool VerifierConnexion (string email, string motDePasse)
        {
            return this._motDePasse == motDePasse && this.Email == email;
        }
    }
}
