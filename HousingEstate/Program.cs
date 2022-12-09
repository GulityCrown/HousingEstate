using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Roman = new Person("Roman", "Popper", 27);
            Person Martin = new Person("Martin", "Popper", 27);
            Person Dominik = new Person("Dominik", "Sloboda", 25);
            
            flat DudovByt = new flat(526, 25, 4);
            Roman.FlatReference = DudovByt;
            DudovByt.AddHabbitant(Roman);
            DudovByt.AddHabbitant(Martin);
            DudovByt.AddHabbitant(Dominik);
            Console.WriteLine(DudovByt.GetInfoAboutAllHabbitants());
            Console.WriteLine(Roman.GetInfoAboutFlat());
        }
    }
}
