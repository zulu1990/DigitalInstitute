using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            DebugLogger.LogMessage("This is a log");


            //Task 2
            Employee employee = new Employee();
            employee.EmployeeId = 1;
            employee.FirstName = "John";
            employee.LastName = "Smith";
            employee.EmailAddress = "JohnSmith123";
            employee.PhoneNumber = "abcdef";
            employee.BirthDate = DateTime.Now;

            var validResults = new List<ValidationResult>();
            var validContext = new ValidationContext(employee);

            bool isValidProp = Validator.TryValidateObject(employee, validContext, validResults, true);

            if (!isValidProp)
            {
                foreach (var validationResult in validResults)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }


            //Task 2
            //Part of Task 2.Uncomment when needed
            //var student = new Person();
            //student.Age = -5;

            //var results = new List<ValidationResult>();
            //var context = new ValidationContext(student);

            //bool isValid = Validator.TryValidateObject(student, context, results, true);

            //if (!isValid)
            //{
            //    foreach (var validationResult in results)
            //    {
            //        Console.WriteLine(validationResult.ErrorMessage);
            //    }
            //}

        }
    }






    //    Task 1: Create a Simple Logging Mechanism for Debugging
    //    Objective: In this task, the aim is to create a simple logging mechanism that is only active when the application is running in DEBUG mode.

    //Instructions:

    //Create a new static class called DebugLogger.
    //In the DebugLogger class, define a static method called LogMessage(). This method should accept a string parameter called message.
    //In the LogMessage() method, utilize the
    //#if DEBUG preprocessor directive to control when logging is active. When in DEBUG mode, the method should print the message to the console.
    //When not in DEBUG mode, the method should do nothing.
    //In your Main() method or another method in your program, test the LogMessage() method by logging a simple message.

    // Task 2: lets learn about Data Annotations
    // The System.ComponentModel.DataAnnotations namespace in .NET provides
    // a set of built-in attributes that are used mostly for defining metadata on
    // Entity Framework entity (which you will learn sooner or later) classes and for model validation in ASP.NET applications.

    //Here are some of the most commonly used attributes from this namespace:

    //[Required]: Specifies that a property must have a value; it cannot be null.

    //[StringLength]: Specifies the maximum length of string properties, and optionally their minimum length.

    //[Range]: Specifies the minimum and maximum value for a numerical property.

    //[DataType]: Specifies the datatype of a property. It's used to provide a hint for the views in ASP.NET applications to render appropriate fields for the data type.

    //[Display] or[DisplayName]: Specifies a friendly name for a property, class, or other type.

    //[MaxLength] and[MinLength]: Specifies the maximum or minimum length for array or string data.

    //[EmailAddress]: Validates the property for a correct email format.

    //[Phone]: Validates the property for a correct phone number format.

    //[Url]: Validates the property for a correct URL format.

    //here is an example of using data annotations
    public class Person
    {
        [MinLength(2)]
        [MaxLength(22)]
        [Required]
        public string Name{ get; set; }

        /// <summary>
        /// Age of the student
        /// </summary>
        [Range(0, 150)]
        [Required]
        public int Age { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }

    // Create your custom class and use this custom annotations. then use the validation logic provided in main method above.
}