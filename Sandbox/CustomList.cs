using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;


        // constructor (SPAWNER)
        public CustomList()
        {
            items = new T[4];
            
        }
        public CustomList(int length)
        {
            items = new T[length];

        }
         

        // member methods (CAN DO)
        public void Add(T item)
        {
            T[int index]; a
;
            if (index < 0 && index >= item.Length)
                Console.Read IndexOuttOfRange;
        }
    }
}
