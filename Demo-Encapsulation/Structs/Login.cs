using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Encapsulation.Structs
{
    internal struct Login
    {
        public string email;
        private string motDePasse;

        public void DefinirMotDePasse(string motDePasse)
        {
            if(this.motDePasse is null) this.motDePasse = motDePasse;
        }

        public bool VerifierConnexion(string email, string motDePasse)
        {
            return this.motDePasse == motDePasse && this.email == email;
        }
    }
}
