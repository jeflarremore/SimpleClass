using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
   public static class Creator
    {
        public static IImmortal Imortal()
        {
            return new Immortal();
        }

        public static ICollectable Collectable()
        {
            return new Collectable();
        }


    }


}
