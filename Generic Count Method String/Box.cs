using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        List<T> list;
       
        public Box()
        {
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
        }
        public int Count(T element)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
      
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
