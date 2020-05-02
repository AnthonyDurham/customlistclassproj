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
        private int count;
        private int capacity;


        // constructor (SPAWNER)

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
            //need values for variables
        }
        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];

                }
                else
                {
                    throw new ArgumentOutOfRangeException();

                }
            }
            set
            {
                items[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;

            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        // member method ( can do )

        public void Add(T item)
        {
            //check count compared to capacity


            if (count == capacity)

            {
                capacity = capacity * 2;
                T[] tempArray = new T[capacity];
                
                for (int i = 0; i < count ; i++)
                {
                    tempArray[i] = items[i];

                }
                    items = tempArray;


               // when my orginal array reaches index 4 my new array should be added 
           
                //how do we get the values out of the old array and into this new array

            }
              items[count] = item;
              count++;

           


        }
        //{10, 20, 30}
        //{20, 30}
        public void Remove(T canBeAnything)
        { 
           
            for (int i = 0; i <count ; i++)
            {

                if (items[i].Equals(canBeAnything))
                {
                    canBeAnything = items[i];
                   
                   
                }

           
                


            }
            
        }
    }    

}
    