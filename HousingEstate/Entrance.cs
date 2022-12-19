using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Entrance
    {
        private int orientationNumber;
        private int north;
        private int south;
        private int floor;
        private int numOfFlats;
        private BlockOfFlats pReference = new BlockOfFlats();
        public BlockOfFlats PReference
        {
            get { return this.pReference; }
            set { this.pReference = value; }
        }
        public int OrientationNumber
        {
            get { return this.orientationNumber; }
            set { this.orientationNumber = value; }
        }
        public int North
        {
            get { return this.north; }
            set 
            {
                if(this.north %2 == 0)
                {
                    this.north = value;
                }
                else
                {
                    Console.WriteLine("Error, you must input even number");
                }
            }
        }
        
        public int South
        {
            get { return this.south; }
            set 
            { 
                if(this.south %2 != 0)
                {
                    this.south = value;
                }
                else
                {
                    Console.WriteLine("Error you must input odd number");
                }
            }
        }
        public int Floor
        {
            get { return this.floor; }
            set { this.floor = value; }
        }
        public int NumOfFlats
        {
            get { return this.numOfFlats; }
            set { this.numOfFlats = value; }
        }
        public Entrance()
        {

        }
        public Entrance(int orientationNumber, int floor, int numOfFlats)
        {
            this.orientationNumber = orientationNumber;
            this.floor = floor;
            this.numOfFlats = numOfFlats;
        }
        



    }
}
