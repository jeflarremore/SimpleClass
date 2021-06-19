using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class Collectable : ICollectable
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Damage { get; set; }

 
    }
}
