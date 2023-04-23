using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Data
{
   
    public class CustomList<T>
    {
        private List<T> items = new List<T>();

       
        public void Add(T item)
        {
            items.Add(item);
        }

       
        public T Find(Predicate<T> function)
        {
            return items.Find(function);
        }
    }
}
