using Task.FilterExtention;

namespace Task
{
    //  Task 2: Filtering Words Based on Consonant Count
    //  You have a list of different words.
    //  You need to make a new list that only includes the words where the count of consonants is greater than the count of vowels.
    //  In English, the vowels are A, E, I, O, U and sometimes Y. All the other letters are consonants.
    //  Use a delegate to decide if a word has more consonants than vowels.
    internal class Task2
    {
        public static void Start()
        {
            List<string> words = new(11)
            {
                "hello",
                "world",
                "open",
                "ai",
                "programming",
                "language",
                "delegate",
                "vowel",
                "consonant",
                "filter",
                "words"
            };

            List<string> result = words.CustomWhere(x => ConsonantWord(x));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        private static bool ConsonantWord(string word)
        {
            string vowels = "aeiouAEIOU";

            int vowelCount = word.CustomCount(c => vowels.CustomContains(c));
            int consonantCount = word.Length - vowelCount;

            return consonantCount > vowelCount;
        }
    }
}
