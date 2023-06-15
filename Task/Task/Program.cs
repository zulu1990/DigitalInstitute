namespace Task
{
    // Task 1
    // Generic Classes
    public class Pair<T, U>
    {
        private T First { get; set; }
        private U Second { get; set; }

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public (T, U) GetValues()
        {
            return (First, Second);
        }
    }

    // Task 2
    // Generic Methods
    public static class SwapUtility
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            //T temp = a;
            //a = b;
            //b = temp;
            (a, b) = (b, a);
        }
    }

    // Task 3
    // Constraints in Generics
    public class SortedCollection<T> where T : IComparable<T>
    {
        private readonly List<T> items;

        public SortedCollection()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
            items.Sort();
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
                return items[index];

            throw new IndexOutOfRangeException("Invalid index");
        }

        public int Count()
           => items.Count;
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            // Pair<T, U> class demonstration
            Pair<int, string> pair1 = new Pair<int, string>(1, "One");
            Console.WriteLine(pair1.GetValues());

            Pair<float, string> pair2 = new Pair<float, string>(3.14f, "Pi");
            Console.WriteLine(pair2.GetValues());
            Console.WriteLine();

            // Task 2
            // SwapUtility class demonstration
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");
            SwapUtility.Swap(ref num1, ref num2);
            Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");

            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"Before swap: str1 = {str1}, str2 = {str2}");
            SwapUtility.Swap(ref str1, ref str2);
            Console.WriteLine($"After swap: str1 = {str1}, str2 = {str2}");
            Console.WriteLine();
            // Task 3
            // SortedCollection<T> class demonstration
            SortedCollection<int> sortedInts = new();
            sortedInts.AddItem(5);
            sortedInts.AddItem(2);
            sortedInts.AddItem(10);
            sortedInts.AddItem(8);
            sortedInts.AddItem(9);
            for (int i = 0; i < sortedInts.Count(); i++)
            {
                Console.WriteLine(sortedInts.GetItem(i));
            }
        }
    }
}
