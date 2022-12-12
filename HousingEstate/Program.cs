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
            Habittant Roman = new Habittant("Roman", "Popper", 27);
            Habittant Martin = new Habittant("Martin", "Popper", 27);
            Habittant Dominik = new Habittant("Dominik", "Sloboda", 25);
            
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
