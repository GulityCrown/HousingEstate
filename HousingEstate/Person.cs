using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    public class Person
    {
        private string name;
        private int age;
        private string surnName;

        
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
        
    }
}
