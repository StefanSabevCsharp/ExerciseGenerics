using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseGenerics
{
    public class Box<T>
    {
        List<T> list;
        public T Value { get; set; }
       
        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        public Box()
        {
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
        }
        public void Swap(int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
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
