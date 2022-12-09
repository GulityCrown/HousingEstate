using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Person
    {
        private string name;
        private int age;
        private string surnName;

        private flat flatRefernce = new flat();
        public flat FlatReference
        {
            get { return this.flatRefernce; }
            set { this.flatRefernce = value; }
        }
        public Person(string name, string surnname, int age)
        {
            this.name = name;
            this.age = age;
            this.surnName = surnname;
        }
        public virtual string ToString()
        {
            return String.Format($"PERSON\nname: {this.name}\nsrunname: {this.surnName}\nage: {this.age}\n");
        }
        public string GetInfoAboutFlat()
        {

            return String.Format($"INFO ABOUT FLAT\n" +
                $"appartment number: {flatRefernce.ApartmentNumber}\nnumber of rooms: {flatRefernce.NumberOfRooms}" +
                $"\nappartment area: {flatRefernce.ApartmentArea}\n");
        }
    }
}
