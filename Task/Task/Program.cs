namespace Task
{
    internal class Program 
    {
        static readonly List<Action> tasks = new()
        {
            Task1,
            Task2,
            Task3,
            Task4,
            Task5
        };

        static void Main()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Invoke();
            }
        }

        //Task 1: Use a Delegate to Add Numbers
        //Make a delegate that can represent a method.
        //This method should take in two numbers, add them together, and give back the result.
        //Then, create this method and show how you can use the delegate to "point" to this method and use it.
        #region Task 1

        static void Task1()
        {
            WriteTasks("\nTask 1\n");
            del addMethod = AddNumbers;
            Console.WriteLine("Result: " + addMethod(1, 2));
        }

        delegate int del(int x, int y);
        static int AddNumbers(int x, int y)
            => x + y;

        #endregion

        //Task 2: Make a Delegate Do Multiple Things
        //Take the delegate from Task 1, and show how you can make it do more than one thing.
        //Make a few more methods that can also add two numbers together.
        //Then, make the delegate use all these methods one after the other.
        #region Task 2

        static void Task2()
        {
            WriteTasks("\nTask 2\n");
            del delegateMethods = AddNumbers;
            delegateMethods += SubtractNumbers;
            delegateMethods += MultiplyNumbers;

            Console.WriteLine($"Here will be last executed delegates answer : {delegateMethods(1, 2)}");
        }
        static int SubtractNumbers(int x, int y)
            => x - y;
        

        static int MultiplyNumbers(int x, int y)
            => x * y;
        

        #endregion

        //Task 3: Make a Delegate Use a 'Nameless' Function
        //Show how to use a delegate with a function that doesn't have a name.
        //This is called an "anonymous function" or a "lambda".
        //This function should also be able to add two numbers and give back the result.
        #region Task 3
        delegate string stringDelegate(string textOne, string textTwo);
        static void Task3()
        {
            WriteTasks("\nTask 3\n");
            string x = "Beqa check my gladiatorAPI and ", y = "make little code review pls :D";

            stringDelegate anonymousDelegate = delegate (string textOne, string textTwo)
            {
                return textOne + textTwo;
            };

            string result = anonymousDelegate(x, y);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Anonymous Delegate: " + result);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        //Task 4: Use an Action Delegate
        //Action is a type of delegate that takes in parameters but does not return anything.
        //Create an Action delegate that takes in two integer parameters and prints their sum to the console.
        //Call this Action and verify that it works correctly.
        #region Task 4

        static void Task4()
        {
            WriteTasks("\nTask 4\n");
            Action<int, int> sumAction = (a, b) =>
            {
                int sum = a + b;
                Console.WriteLine("Sum: " + sum);
            };

            // Call the Action delegate
            sumAction(3, 5);
        }
        #endregion

        //Task 5: Use a Func Delegate(More challenging)
        //Func is a type of delegate that takes in parameters and returns a value.
        //Create a Func delegate that takes in two integer parameters and returns their sum.
        //Then, create another Func delegate that takes in three parameters: two integers and the previous Func delegate.
        //This Func should use the delegate to add the two integers and then multiply the result by 2.
        //Call this Func and verify that it works correctly.
        #region Task 5
        static void Task5()
        {
            WriteTasks("\nTask 5\n");
            Func<int, int, int> sumFunc = (a, b) => a + b;
            Func<int, int, Func<int, int, int>, int> multiplyFunc = (x, y, func) => func(x, y) * 2;

            int result = multiplyFunc(3, 5, sumFunc);
            Console.WriteLine("Result: " + result);
        }

        #endregion


        #region Common
        public static void WriteTasks(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }


        #endregion
    }
}