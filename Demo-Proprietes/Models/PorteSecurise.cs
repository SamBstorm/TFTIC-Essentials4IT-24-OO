using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Proprietes.Models
{
    internal class PorteSecurise
    {
		//commande : propfull + tab + tab
		private int _codePin;

		public int CodePin
		{
			private get { return _codePin; }
			set { _codePin = value; }
		}

		//commande : prop + tab + tab
        public string Emplacement { get; set; }

    }
}
