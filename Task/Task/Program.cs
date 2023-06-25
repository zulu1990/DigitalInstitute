namespace Task
{
    internal class Program
    {
        // Before you start!!!!!!!!!!!!
        // you don't need to use the keyword "delegate" in any of these tasks (use FUNC!).
        // do a little reasearch about LINQ and "Where" method in LINQ
        // you will have to create 3 functions, that will be passed to the WHERE method.

        static void Main(string[] args)
        {
            WriteTasks("\nTask 1\n");
            Task1.Start();
            WriteTasks("\nTask 2\n");
            Task2.Start();
            WriteTasks("\nTask 3\n");
            Task3.Start();
            WriteTasks("\nTask 4\n");
            Task4.Start();
        }
        public static void WriteTasks(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}