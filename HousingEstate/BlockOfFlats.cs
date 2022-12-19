using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class BlockOfFlats
    {
        private int cadastralRegistrationNumber;
        private List<Entrance> entrances = new List<Entrance> (){ };
       
        public int CadastralRegistrationNumber
        {
            get { return this.cadastralRegistrationNumber; }
            set { this.cadastralRegistrationNumber = value; }
        }
        public List<Entrance> Entrances
        {
            get { return this.entrances; }
            set { this.entrances = value;}
        }
        public void AddEntrance(Entrance entrance)
        {
            this.entrances.Add(entrance);
            entrance.PReference = this;
            entrance.OrientationNumber += 2;
        }
       

    }
}
