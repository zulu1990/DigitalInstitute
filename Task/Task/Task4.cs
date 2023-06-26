using Task.FilterExtention;
using Task.ListExtentions;

namespace Task
{
    internal class Task4
    {
        //  Task 4: Filtering Employees by Department and Salary (Hard one)
        //  You have a list of workers.
        //  Each worker has a name, a department where they work, and a salary.
        //  You need to create a new list.
        //  This list should only have workers who work in the "Sales" department and earn more than $5000.
        //  To do this, you will create three functions:
        //  1) The first function will check if a worker is in the "Sales" department.
        //  2) The second function will check if a worker earns more than $5000.
        //  3) After you create these two functions, you will create a third function.
        //      This function will combine the first two functions.
        //      If a worker passes both checks, they should be added to the new list.
        //  Use this THIRD(!!) function with the Where method to create your new list.
        //  This task will help you understand how to use multiple functions together to filter a list.
        enum DepartmentTypes
        {
            Finance = 0,
            Sales,
            IT,
            HR,
        }
        struct Employee
        {
            public string Name { get; set; }
            public DepartmentTypes DepartmentTypeId { get; set; }
            public Decimal Salary { get; set; }
            public Employee(string name, DepartmentTypes departmentTypeId, int? salary = null)
            {
                Name = name;
                DepartmentTypeId = departmentTypeId;
                Salary = salary ?? GenerateGrades();
            }
            private static int GenerateGrades()
            {
                Random random = new();

                return random.Next(3000, 15000);
            }
        }
        public static void Start()
        {
            var employees = new List<Employee>
            {
                new Employee("John", DepartmentTypes.Finance, 5000),
                new Employee("Emily", DepartmentTypes.Sales, 4500),
                new Employee("Michael", DepartmentTypes.IT, 6000),
                new Employee("Sarah", DepartmentTypes.HR, 4000),
                new Employee("David", DepartmentTypes.Finance, 5500),
                new Employee("Jessica", DepartmentTypes.Sales),
                new Employee("Robert", DepartmentTypes.IT),
                new Employee("Jennifer", DepartmentTypes.HR, 4200),
                new Employee("Daniel", DepartmentTypes.IT, 5800),
                new Employee("Amy", DepartmentTypes.Sales),
                new Employee("Amilly", DepartmentTypes.Sales),
                new Employee("Amaterasy", DepartmentTypes.Sales, 10000),
                new Employee("John", DepartmentTypes.Sales),
                new Employee("Depp", DepartmentTypes.Sales),
            };
            Func<DepartmentTypes, bool> IsFromSalesDepartment = (DepartmentTypes departmentType) => departmentType == DepartmentTypes.Sales;
            Func<decimal, bool> IsSalaryGreaterThan5000 = (decimal salary) => salary > 5000;
            var newList = employees.CustomWhere(x => IsFromSalesDepartment(x.DepartmentTypeId) && IsSalaryGreaterThan5000(x.Salary));

            Action<Employee> action = employee => Console.WriteLine($"Name - {employee.Name}\nDepartment - {Enum.GetName(employee.DepartmentTypeId)}\nSalary - {employee.Salary}\n");

            Console.WriteLine("\nOriginal List\n");
            employees.CustomForEach(action);

            Console.WriteLine("\nFiltered List\n");
            newList.CustomForEach(action);
        }
    }
}
