using System;
using System.Text;

namespace BoxOfString
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> box;

        public Box()
        {
            box = new List<T>();
        }


        public void Add(T element)
        {
            box.Add(element);
        }
        public void Remove(T element)
        {
            box.Remove(element);
        }
        public void Swap(int index1, int index2)
        {
            if (index1 >= 0 && index1 < box.Count && index2 >= 0 && index2 < box.Count)
            {
                (box[index2], box[index1]) = (box[index1], box[index2]);
            }
        }
        public int Count(T itemCompare)
        {
            int count = 0;
            foreach (var item in box)
            {
                if (item.CompareTo(itemCompare) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in box)
            {
                sb.AppendLine($"{typeof(T)}: {item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }

        //public int Count { get { return box.Count; } }
    }
}

