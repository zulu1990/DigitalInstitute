namespace Task.FilterExtention
{
    public static class Extensions
    {
        public static IEnumerable<int> PrimeFilterAsExtention(this IEnumerable<int> numbers, Func<int, bool> predicate)
        {
            List<int> result = new();

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public static List<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new ();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static int CustomCount<T>(this IEnumerable<T> source)
        {
            int count = 0;

            foreach (var item in source)
            {
               count++;
            }

            return count;
        }
        public static int CustomCount<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            int count = 0;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool CustomContains<T>(this IEnumerable<T> source, T value)
        {
            return source.CustomAny(item => EqualityComparer<T>.Default.Equals(item, value));
        }

        public static bool CustomAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static int CustomSum<T>(this IEnumerable<T> source)
            where T : IConvertible
        {
            int sum = 0;
            foreach (var item in source)
            {
                sum += Convert.ToInt32(item);
            }
            return sum;
        }
        public static int CustomAverage<T>(this IEnumerable<T> source)
            where T : IConvertible
        {
            int sum = 0;
            foreach (var item in source)
            {
                sum += Convert.ToInt32(item);
            }
            return sum / source.CustomCount();
        }
    }
}