using System;
using System.Collections.Generic;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvertisementSelector selector = new AdvertisementSelector();

            // Add advertisements with their corresponding prices
            selector.AddAdvertisement("Facebook", 10000);
            selector.AddAdvertisement("Google", 12000);
            selector.AddAdvertisement("Apple", 15000);
            selector.AddAdvertisement("Microsoft", 10000);

            // Get two random advertisements
            (string ad1, string ad2) = selector.GetRandomAdvertisements();

            Console.WriteLine("Randomly selected advertisements:");
            Console.WriteLine(ad1);
            Console.WriteLine(ad2);
        }
    }




    public class AdvertisementSelector
    {
        private Dictionary<string, int> ads;
        private Random random;

        public AdvertisementSelector()
        {
            ads = new Dictionary<string, int>();
            random = new Random();
        }

        public void AddAdvertisement(string ad, int price)
        {
            ads[ad] = price;
        }

        public (string, string) GetRandomAdvertisements()
        {
            int totalSum = CalculateTotalSum();
            int randomValue = random.Next(1, totalSum + 1);

            string firstAd = SelectAdvertisement(randomValue);
            string secondAd = SelectAdvertisement(randomValue, firstAd);

            return (firstAd, secondAd);
        }

        private int CalculateTotalSum()
        {
            int sum = 0;
            foreach (var ad in ads)
            {
                sum += ad.Value;
            }
            return sum;
        }

        private string SelectAdvertisement(int randomValue, string excludedAd = "")
        {
            int accumulatedSum = 0;
            foreach (var ad in ads)
            {
                if (ad.Key != excludedAd)
                {
                    accumulatedSum += ad.Value;
                    if (accumulatedSum >= randomValue)
                    {
                        return ad.Key;
                    }
                }
            }
            throw new InvalidOperationException("No valid advertisement found.");
        }
    }
}

