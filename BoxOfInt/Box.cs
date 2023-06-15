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
        public Box()
        {
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
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
