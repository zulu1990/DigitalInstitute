namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 & Task 2
            SimpleDelegates();

            //Task 3
            NamelessFunctionDelegate();

            //Task 4
            ActionDelegate();

            //Task 5
            FuncDelegate();
        }

        public static void SimpleDelegates()
        {
            PerformCalculation calculation = default;

            calculation += Add;
            var sum = calculation(5, 2);
            Console.WriteLine(sum);

            calculation += Subtract;
            var difference = calculation(5, 2);
            Console.WriteLine(difference);

            calculation += Multiply;
            var product = calculation(5, 2);
            Console.WriteLine(product);

            calculation += Divide;
            var quotient = calculation(5, 2);
            Console.WriteLine(quotient);
        }

        public delegate double PerformCalculation(double a, double b);
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static void NamelessFunctionDelegate()
        {
            Func<int, int, int> add = delegate (int a, int b) { return a + b; };
            Console.WriteLine(add(7,8));
        }

        public static void ActionDelegate()
        {
            Action<int, int> printSum = delegate (int a, int b) {  Console.WriteLine(a + b); };
            printSum(15,25);
        }

        public static void FuncDelegate()
        {
            Func<int, int, int> sum = delegate (int a, int b) { return a + b; };
            Console.WriteLine(sum(9,9));

            Func<int, int, Func<int, int, int>, int> prod = delegate (int a, int b, Func<int, int, int> func) { return func(a, b) * 2; };
            Console.WriteLine(prod(4,6,sum.Invoke));
        }

    }

    //Task 1: Use a Delegate to Add Numbers
    //Make a delegate that can represent a method.
    //This method should take in two numbers, add them together, and give back the result.
    //Then, create this method and show how you can use the delegate to "point" to this method and use it.

    //Task 2: Make a Delegate Do Multiple Things
    //Take the delegate from Task 1, and show how you can make it do more than one thing.
    //Make a few more methods that can also add two numbers together.
    //Then, make the delegate use all these methods one after the other.

    //Task 3: Make a Delegate Use a 'Nameless' Function
    //Show how to use a delegate with a function that doesn't have a name.
    //This is called an "anonymous function" or a "lambda".
    //This function should also be able to add two numbers and give back the result.

    //Task 4: Use an Action Delegate
    //Action is a type of delegate that takes in parameters but does not return anything.
    //Create an Action delegate that takes in two integer parameters and prints their sum to the console.
    //Call this Action and verify that it works correctly.

    //Task 5: Use a Func Delegate(More challenging)
    //Func is a type of delegate that takes in parameters and returns a value.
    //Create a Func delegate that takes in two integer parameters and returns their sum.
    //Then, create another Func delegate that takes in three parameters: two integers and the previous Func delegate.
    //This Func should use the delegate to add the two integers and then multiply the result by 2.
    //Call this Func and verify that it works correctly.
}