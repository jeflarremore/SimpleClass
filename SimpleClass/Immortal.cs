using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Immortal : IImmortal
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Superpower { get; set; }
        public List<Collectable> Carrying { get; set; } 
        public string Saying { get; set; }
        public string Bent { get; set; }
        public int LifeForce { get; set; }



        public void Pickup(Collectable item)
        {
            this.Carrying.Add((Collectable)item);
            CarryingConfirm(item.Name);
        }

        public void Speak()
        {
            Console.WriteLine(Saying + ". I am " + this.Bent + "!" + " I am from " + Origin);
            
        }

        public void CarryingConfirm(string confimationmsg)
        {
            Console.WriteLine("Now carrying a " + confimationmsg + "!");
        }


    }
}
