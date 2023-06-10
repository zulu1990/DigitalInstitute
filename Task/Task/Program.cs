namespace Task
{
    internal class Program
    {
        static void Main()
        {



            Result(CompanyKayValue(NumberOfCompanys()));


        }


        public static int NumberOfCompanys()
        {
            int nuberOfCompan;

            while (true)
            {
                Console.WriteLine($"enter howe many company u have");

                string companys = Console.ReadLine();



                if (int.TryParse(companys, out nuberOfCompan))
                    return nuberOfCompan;

                Console.WriteLine("enter ageyn u have mistake u must enter a digit " + Environment.NewLine);

            }


        }

        public static Dictionary<string, int> CompanyKayValue(int n)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter company name");
                string kay = Console.ReadLine();

                Console.WriteLine("enter price");
                int value = Convert.ToInt32(Console.ReadLine());


                dict[kay] = value;

            }

            return dict;
        }

        public static void Result(Dictionary<string, int> dict)
        {
            int sum = 0;
            Random rand = new Random();


            foreach (int i in dict.Values)
                sum += i;


            for (int i = 0; i < 2; i++)
            {
                int mycompany = 0;
                int randomCompany = rand.Next(0, sum);
                int count = 0;


                foreach (var kayValye in dict)
                {
                    mycompany += kayValye.Value;

                    if (mycompany > randomCompany && count == 0)
                    {
                        count++;
                        Console.WriteLine($"company {kayValye.Key} : price {kayValye.Value} ");
                    }


                }

            }
        }
    }
}

    // Assume you have a website where there are two advertising slots.
    // With every refresh of the website, different advertisements will appear in these two slots.
    // For instance, upon the first refresh, there might be ads for Facebook and Google.
    // On the second refresh, there may be ads for Apple and Microsoft, and so forth.
    // The frequency at which an ad appears is proportional to the amount paid by the advertiser;
    // for example, if Microsoft pays $10,000 and Apple pays $15, Microsoft's ads will appear more often.
    // Now onto the task:
    // You are required to write a method that will randomly return two ads from a dictionary.
    // The likelihood of an ad being returned should be based on the price the advertiser has paid for it.
