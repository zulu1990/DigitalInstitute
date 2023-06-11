using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //Constraints in Generics:
    //Create a generic class SortedCollection<T> that maintains a sorted collection of items.
    //Use the constraint on T such that T implements IComparable<T>.
    //This is needed so that the items can be sorted.

    //The class should have the following methods:
    //AddItem(T item) : This method should add a new item to the collection and then ensure the collection remains sorted.
    //GetItem(int index): This method should return the item at the given index.
    //Test the SortedCollection<T> class with a simple custom class that implements IComparable<T>,
    //and show how the items are always sorted when added to the collection.
    internal class SortedCollection<T>
        where T : IComparable<T>
    {
        private List<T> list;

        public int Count => list.Count;

        public SortedCollection()
        {
            list = new List<T>();
        }
        public void AddItem(T item)
        {
            list.Add(item);
            list.Sort();
        }


        public T GetItem(int index)
        {

            try
            {
                return list[index];
            }
            catch
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }
        }
    }


    internal class CustomClass : IComparable<CustomClass>
    {
        public int MyProperty { get; set; }
        public int CompareTo(CustomClass? other)
        {
            return MyProperty.CompareTo(other.MyProperty);
        }

        public override string ToString()
        {
            return MyProperty.ToString();
        }
    }
}
