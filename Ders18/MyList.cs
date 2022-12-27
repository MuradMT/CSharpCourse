using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18
{
    public class MyList<T>
    {

        //Generics-deyisenin tipini runtimede mueyyen edir
        //mylist int,string,double
        //code refactoring dogru olmayan-duzeltdik
        T[] arr;
        int Length { get; set; } = 0;
        public MyList()
        {
            arr = new T[0];
        }
        public void Add(T data)
        {
            Length++;
            T[] narr=new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                narr[i] = arr[i];
            }
            //0 1 2 - 3- 0 1 2 3
            narr[Length-1] = data;
            arr = narr;
            //stack heap
            //arr -  {1 2 3}-0x12   -orphan object Garbage Collector
            //narr - {1,2,3,4}-0x13
        }
        public int Count 
        {   
            get { return Length; }
        }
        public void Remove(T data)
        {
            if (arr.Contains(data))
            {
                Length--;
                T[] nnarr = new T[Length];
                int count = 0;
                int temp = 0;
                for (int i = 0; i < arr.Length; i += 1)
                {
                    if (arr[i].Equals(data) && count==0)
                    {
                        count += 1;
                    }
                    else
                    {
                        nnarr[temp] = arr[i];
                        temp++;
                    }
                }
                arr = nnarr;
            }
        }
        //equals ==
        public T[] Data
        {
            get
            {
                return arr;
            }
        }
        public bool Contains(T data)
        {
            return arr.Contains(data);
        }
        //indexer
        public  T this[int index]//Mylist m=new Mylist
            //m[2]
        {
            get
            {
                return arr[index];
            }
        }
    }
}
