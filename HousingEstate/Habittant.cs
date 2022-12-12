using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Habittant : Person
    {
        private flat flatRefernce = new flat();
        public flat FlatReference
        {
            get { return this.flatRefernce; }
            set { this.flatRefernce = value; }
        }
        public Habittant(string name, string surnname, int age) : base(name, surnname, age)
        {
        }
        public string GetInfoAboutFlat()
        {

            return String.Format($"INFO ABOUT FLAT\n" +
                $"appartment number: {flatRefernce.ApartmentNumber}\nnumber of rooms: {flatRefernce.NumberOfRooms}" +
                $"\nappartment area: {flatRefernce.ApartmentArea}\n");
        }
    }
}
