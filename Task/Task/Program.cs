namespace Task
{
    internal class Program
    {
        private static readonly Dictionary<string, int> dictionary = new()
        {
            { "Facebook", 5000 },      // 11
            { "Google", 8000 },        // 8
            { "Apple", 10000 },        // 4
            { "Microsoft", 15000 },    // 1
            { "Amazon", 12000 },       // 2
            { "Netflix", 9000 },       // 6
            { "Tesla", 11000 },        // 3
            { "IBM", 7000 },           // 9
            { "Samsung", 9500 },       // 7
            { "Intel", 6000 }          // 10
        };

        private const int bannerCount = 2;

        static void Main()
        {
            Console.WriteLine("Random Ads:\n");

            foreach (string ad in GetRandomAds())
            {
                Console.WriteLine($"{ad}\n");
            }
        }

        private static List<string> GetRandomAds()
        {
            List<string> randomAds = new();
            List<int> randomIndexes = GenerateRandomIndexes();

            foreach (int index in randomIndexes)
            {
                string ad = GetAdAtIndex(index);
                randomAds.Add(ad);
            }

            return randomAds;
        }

        private static List<int> GenerateRandomIndexes()
        {
            List<int> weights = dictionary.Values.ToList();
            List<int> randomIndexes = new(bannerCount);
            Random random = new();

            while (randomIndexes.Count < bannerCount)
            {
                int totalWeight = weights.Sum();
                int randomNumber = random.Next(totalWeight);

                int cumulativeWeight = 0;
                int currentIndex = 0;

                while (currentIndex < weights.Count)
                {
                    cumulativeWeight += weights[currentIndex];

                    if (randomNumber < cumulativeWeight)
                    {
                        randomIndexes.Add(currentIndex);
                        weights.RemoveAt(currentIndex);
                        break;
                    }

                    currentIndex++;
                }
            }

            return randomIndexes;
        }

        private static string GetAdAtIndex(int index)
        {
            int currentIndex = 0;

            foreach (string ad in dictionary.Keys)
            {
                if (currentIndex == index)
                {
                    return ad;
                }

                currentIndex++;
            }

            throw new IndexOutOfRangeException("Invalid index");
        }
    }
}