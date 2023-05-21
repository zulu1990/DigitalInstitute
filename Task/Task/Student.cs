namespace Task
{
    //Task 3: Building a Student Class with Overloaded Constructors

    //Create a Student class. The class should have the following private properties:
    //  name
    //  grade
    //  and a PUBLIC property SchoolName.
    // 1)Implement a constructor that takes no parameters and sets name to "Unnamed", grade to 1, and schoolName to "Unknown".
    // 2)Implement another constructor that takes one parameter for name and sets grade to 1, and schoolName to "Unknown".
    //  Use the this keyword to navigate from this constructor to the first constructor when no name is given.
    // 3) Implement another constructor that takes two parameters, one for name and one for grade, and sets schoolName to "Unknown".
    //  Use the this keyword to navigate from this constructor to the second constructor when only name is given, and to the first constructor when no parameters are given.
    // 4) Implement a final constructor that takes all three parameters and sets the corresponding properties.
    //  Use the this keyword to navigate from this constructor to the third constructor when schoolName is not given, to the second constructor when only name is given, and to the first constructor when no parameters are given.
    // 5) Implement public getters and setters for each of these properties.
    //  Make sure that the setter methods validate the inputs (for example, name should not be an empty string, grade should be between 1 and 12).

    class Student
    {
        private string _name;
        private int _grade;
        public string SchoolName;

        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public int Grade
        {
            get => _grade;
            set
            {
                if (value > 1 || value < 12)
                {
                    _grade = value;
                }
            }
        }
        
        public Student()
        {
            _name = "Unnamed";
            _grade = 1;
            SchoolName = "Unknown";
        }

        public Student(string name):this()
        {
            _name = name;
        }

        public Student(string name, int grade):this(name)
        {
            _grade = grade;
        }

        public Student(string name, int grade, string schoolName):this(name,grade)
        {
            SchoolName = schoolName;
        }

    }
}