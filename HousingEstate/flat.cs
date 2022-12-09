using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class flat
    {
        private int apartmentNumber;
        private int apartmentArea;
        private int numberOfRooms;
        public int ApartmentNumber
        {
            set { apartmentNumber = value; }
            get  {return this.apartmentNumber; }
        }
        public int ApartmentArea
        {
            set { this.apartmentArea = value; }
            get { return this.apartmentArea; }
        }
        public int NumberOfRooms
        {
            set { numberOfRooms = value; }
            get { return this.numberOfRooms; }
        }
        private List<Person> people = new List<Person>() { };
        public List<Person> People
        {
            get { return people; }
            set { this.people = value; }
        }
        public flat() { }
        public flat(int apartmentNumber, int apartmentArea, int numberOfRooms)
        {
            this.apartmentNumber = apartmentNumber;
            this.apartmentArea = apartmentArea;
            this.numberOfRooms = numberOfRooms;
        }
        public void AddHabbitant(Person habbitant)
        {
            people.Add(habbitant);
        }
        public virtual string ToString()
        {
            
            string clovek = String.Empty;
            for(int i = 0; i < people.Count; i++)
            {
                clovek += people[i].ToString();
            }
            return String.Format($"FLAT\nnumber of apartment: {apartmentNumber}\napartment area: " +
                $"{apartmentArea}\n number of rooms: {numberOfRooms}\nludia: " + GetInfoAboutAllHabbitants());
        }
        public string GetInfoAboutAllHabbitants()
        {
            string clovek = String.Empty;
            for (int i = 0; i < people.Count; i++)
            {
                clovek += people[i].ToString();
            }
            return clovek;
        }
        
    }
}
