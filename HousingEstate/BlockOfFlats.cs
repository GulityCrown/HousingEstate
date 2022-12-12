using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class BlockOfFlats
    {
        private int supisneCislo;
        private List<Entrance> vchody = new List<Entrance> (){ };
       
        public int SupisneCislo
        {
            get { return this.supisneCislo; }
            set { this.SupisneCislo = value; }
        }
        private List<Entrance> Vchody
        {
            get { return this.vchody; }
            set { this.vchody = value;}
        }
        
        
        
    }
}
