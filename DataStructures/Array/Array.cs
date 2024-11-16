using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;
        public int Count { get; private set; }
        public int Capacity => InnerList.Length;
        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }

        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                Add(item);
            }
        }
        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.ToArray().Length];
            Count = 0;
            foreach (var item in collection)
            {
                Add(item);
            }
        }




        public void Add(T item) 
        {
            if (InnerList.Length == Count)
            {
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];
            /*
            for (int i = 0; i < temp.Length; i++) 
            { 
                temp[i] = InnerList[i];
            
            }
            */

            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;

        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator() => InnerList.Take(Count).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
