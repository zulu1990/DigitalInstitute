using Task.FilterExtention;

namespace Task
{
    internal class Task3
    {
        //  Task 3: Filtering Students Based on Average Grades
        //  You have a list of students, and each student has a name and a list of grades.
        //  You need to make a new list that only includes the students whose average grade is greater than 85.
        //  This will involve adding up all of a student's grades and dividing by the total number of grades to find the average.
        //  Use a delegate to decide if a student's average grade is greater than 85.
        struct Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Grades { get; set; }

            public Student(string name, List<int> grades = null)
            {
                Name = name;
                Grades = grades ?? GenerateGrades();
            }

            private static List<int> GenerateGrades()
            {
                List<int> grades = new(3);
                Random random = new();
                for (int i = 0; i < 3; i++)
                {
                    grades.Add(random.Next(30, 100));
                }
                return grades;
            }
        }

        public static void Start()
        {
            List<Student> studentsAutoGrades = new(10)
            {
                new Student("Mishiko"),
                new Student("Beqa"),
                new Student("Nika"),
                new Student("Gio"),
                new Student("Marika"),
                new Student("Mari"),
                new Student("Noe"),
                new Student("Luka"),
                new Student("Tornike"),
                new Student("Nino"),
            };

            List<Student> students = new(10)
            {
                new Student("Mishiko", new List<int>
                {
                    50, 31, 99
                }),
                new Student("Beqa", new List<int>
                {
                    33, 55, 10
                }),
                new Student("Nika", new List<int>
                {
                    69, 41, 12
                }),
                new Student("Gio", new List<int>
                {
                    75, 12, 74
                }),
                new Student("Marika", new List<int>
                {
                    94, 13, 16
                }),
                new Student("Mari", new List<int>
                {
                    99, 31, 94
                }),
                new Student("Noe", new List<int>
                {
                    73, 26, 94
                }),
                new Student("Luka", new List<int>
                {
                    41, 26, 35
                }),
                new Student("Tornike", new List<int>
                {
                    31, 21, 53
                }),
                new Student("Nino", new List<int>
                {
                    99, 99, 99
                }),
            };
            // even tho its not necessary to divide by 3 to minimum number to passed is 255 (85 * 3) 84 is not passable
            var AverageGradeMoreThan85Auto = studentsAutoGrades.CustomWhere(x => IsGreaterThan85(x.Grades));

            var AverageGradeMoreThan85 = students.CustomWhere(x => x.Grades.CustomSum() / x.Grades.CustomCount() > 85);


            AverageGradeMoreThan85Auto.ForEach(x =>
            {
                Console.WriteLine($"Name - {x.Name}");
                Console.WriteLine("Grades:");
                foreach (var grade in x.Grades)
                {
                    Console.WriteLine($"Grade - {grade}");
                }
            });


            AverageGradeMoreThan85.ForEach(x =>
            {
                Console.WriteLine($"Name - {x.Name}");
                Console.WriteLine("Grades:");
                foreach (var grade in x.Grades)
                {
                    Console.WriteLine($"Grade - {grade}");
                }
            });
        }

        static bool IsGreaterThan85(IEnumerable<int> grades)
            => grades.CustomAverage() > 85;
    }
}
