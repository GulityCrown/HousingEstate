using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class HousingEstate
    {
        private List<BlockOfFlats> oHousingEstate = new List<BlockOfFlats>() { };
        public List<BlockOfFlats> OHousingEstate
        {
            get { return this.oHousingEstate; }
            set { this.oHousingEstate = value; }
        }
        public void AddBlockOfFlats(BlockOfFlats panelak)
        {
            this.oHousingEstate.Add(panelak);
        }

    }
}
