using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    partial class Program
    {


        static void Main(string[] args)
        {
            var txtBagContents = "Items in Bag";
            // comment
            ICollectable rubystone = Creator.Collectable();
            rubystone.Name = "Ruby Stone";
            rubystone.Points = 200;
            rubystone.Damage = 0;

            ICollectable bagofdiamonds = Creator.Collectable();
            bagofdiamonds.Name = "Diamond Bag";
            bagofdiamonds.Points = 500;
            bagofdiamonds.Damage = 0;

            IImmortal mighty = Creator.Imortal();
            mighty.Name = "Mighty Man";
            mighty.Origin = "Mightopolis";
            mighty.Superpower = "Might";
            mighty.Saying = "I am Mighty Man!";
            mighty.Bent = "good";
            mighty.LifeForce = 1000;
            mighty.Carrying = new List<Collectable>();

            mighty.Speak();


            mighty.Pickup((Collectable)rubystone);

            Console.WriteLine(txtBagContents);
            foreach (var collecteditem in mighty.Carrying)
            {
                Console.WriteLine(" - " + collecteditem.Name);

            }
            mighty.Pickup((Collectable)bagofdiamonds);
            

            Console.WriteLine(txtBagContents);
            foreach (var collecteditem in mighty.Carrying)
            {

                Console.WriteLine(" - " + collecteditem.Name);

            }

            Console.WriteLine("My life force is at " + mighty.LifeForce.ToString());

           Console.ReadLine();


        }
    }
}
