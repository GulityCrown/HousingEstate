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
        private int poschodia;
        private int pocetBytov;

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
        public int Poschodia
        {
            get { return this.poschodia; }
            set { this.poschodia = value; }
        }
        public int PocetBytov
        {
            get { return this.pocetBytov; }
            set { this.pocetBytov = value; }
        }
        public Entrance()
        {

        }
        public Entrance(int orientationNumber, int poschodia, int pocetBytov)
        {
            this.orientationNumber = orientationNumber;
            this.poschodia = poschodia;
            this.pocetBytov = pocetBytov;
        }
        



    }
}
