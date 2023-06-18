namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Advertisement googleAd = new Advertisement("Google");
            Advertisement microsoftAd = new Advertisement("Microsoft");
            Advertisement facebookAd = new Advertisement("Facebook");
            Advertisement appleAd = new Advertisement("Apple");
            Advertisement amazonAd = new Advertisement("Amazon");
            Advertisement nvidiaAd = new Advertisement("Nvidia");
            Advertisement teslaAd = new Advertisement("Tesla");

            Dictionary<Advertisement, decimal> ads = new Dictionary<Advertisement, decimal>()
            {
                {googleAd, 10000},
                {microsoftAd, 20000},
                {facebookAd, 15000},
                {appleAd, 22000},
                {amazonAd, 8000},
                {nvidiaAd, 17500},
                {teslaAd, 12500},
            };

            foreach(Advertisement ad in RecommendedTwoAds(ads))
            {
                Console.WriteLine(ad);
            }
        }


        public static IEnumerable<Advertisement> RecommendedTwoAds(Dictionary<Advertisement, decimal> ads)
        {
            Random random = new Random();
            double maxP = double.MinValue;
            Advertisement recommendedAd = default(Advertisement);

            for (int i = 0; i < 2; i++)
            {
                foreach (KeyValuePair<Advertisement, decimal> pair in ads)
                {
                    double p = random.NextDouble() * (double)pair.Value;
                    if (p > maxP)
                    {
                        maxP = p;
                        recommendedAd = pair.Key;
                    }
                }
                maxP = double.MinValue;
                ads.Remove(recommendedAd);
                yield return recommendedAd;
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
}