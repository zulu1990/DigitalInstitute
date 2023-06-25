namespace Task
{
    internal class Program
    {
        static void Main()
        {
            static void printTask(string text)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{text}\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            printTask("Task 1 - Easy");
            Task1.Start();

            printTask("Task 2 - Medium");
            Task2.Start();

            printTask("Task 3 - Hard");
            Task3.Start();

            printTask("Task 4 - Crazy asian (Asian Difficulty)");
            Task4.Start();

            printTask("Crazy asian -> EMOTIONAL DAMAGE");
        }
    }
}