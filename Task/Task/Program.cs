using ExchangeRate.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.Reflection;

class Program
{
    private static readonly HttpClient httpClient = new();
    private const string ApiUrl = "https://api.freecurrencyapi.com/v1/latest";
    private const string ApiKey = "fca_live_Oh2z3uiq7zrItxV1lrPK27IZ0ACtmWblpHJoa3kV";
    private const int miliseconds = 5000;

    static async Task Main()
    {
        try
        {
            httpClient.DefaultRequestHeaders.Add("apikey", ApiKey);

            while (true)
            {
                HttpResponseMessage response = await httpClient.GetAsync(ApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("Response from API:\n");
                    Console.WriteLine(responseBody);

                    PrintData(JsonConvert.DeserializeObject<CurrencyRates>(responseBody)!);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }

                await Task.Delay(miliseconds);

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static void PrintData(CurrencyRates model)
    {
        Console.WriteLine("\nData as JSON-like representation:\n");
        Console.Write("{ \n");

        int i = 0;
        foreach (var kvp in model.Data)
        {
            if (i > 0)
            {
                Console.Write(", \n");
            }

            Console.Write($" \"{kvp.Key}\": {kvp.Value}");
            i++;
        }

        Console.WriteLine("\n }");
    }
}
