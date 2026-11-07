using System.Net.WebSockets;

namespace Student_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, Name = "Hadia Ebrahim", Age = 20, Grade = 50 },
                new Student { StudentId = 2, Name = "Ahmed Ebrahim", Age = 22, Grade = 60 },
                new Student { StudentId = 3, Name = "Hadeer Ebrahim", Age = 19, Grade = 80 },
                new Student { StudentId = 4, Name = "Hodina Ebrahim", Age = 19, Grade = 80 },
                new Student { StudentId = 5, Name = "Sara", Age = 19, Grade = 80 },
            };
            //Get all students with Grade > 80 (FindAll)
            var highGradeStudents = students.FindAll(s => s.Grade > 80);
            Console.WriteLine("Students with Grade > 80:");
            foreach (var student in highGradeStudents)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
            //Get the first student with Grade < 60 (Find)
            var lowGradeStudent = students.Find(s=>s.Grade < 60);
            Console.WriteLine("\nFirst student with Grade < 60:");
            if (lowGradeStudent != null)
            {
                Console.WriteLine($"ID: {lowGradeStudent.StudentId}, Name: {lowGradeStudent.Name}, Age: {lowGradeStudent.Age}, Grade: {lowGradeStudent.Grade}");
            }
            else
            {
                Console.WriteLine("No student found with Grade < 60.");
            }
            //Get the index of the student named "Sara" (FindIndex)
            var studentName=students.FindIndex(s => s.Name == "Sara");
            Console.WriteLine($"\nIndex of student named 'Sara': {studentName}");
            //Check if all students passed (Grade >= 60) (All)
            var allPasssed=students.All(s => s.Grade >= 60);
            Console.WriteLine($"\nAll students passed: {allPasssed}");
            //Check if any student is under 20 years old (Any)
            var anyUnder20=students.Any(s => s.Age < 20);
            Console.WriteLine($"\nAny student under 20: {anyUnder20}");
            //Count how many students have Grade > 80 (Count with Where)
            var countHighGradfe=students.Count(s => s.Grade > 80);
            Console.WriteLine($"\nNumber of students with Grade > 80: {countHighGradfe}");
            //Order students by Age ascending (OrderBy)
            var orderedByAge = students.OrderBy(s => s.Age);
            Console.WriteLine("\nStudents ordered by Age:");
            foreach (var student in orderedByAge)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
            //Select only the student names (Select)
            var selectNames=students.Select(s => s.Name);
            Console.WriteLine("\nStudent Names:");
            foreach (var name in selectNames)
            {
                Console.WriteLine(name);
            }
            //Get the student with Id = 3 (Single)
            var studentWithId3 = students.Single(s => s.StudentId == 3);
            Console.WriteLine($"\nStudent with ID = 3: ID: {studentWithId3.StudentId}, Name: {studentWithId3.Name}, Age: {studentWithId3.Age}, Grade: {studentWithId3.Grade}");
            //Get the student with Id = 10 or null if not exists (SingleOrDefault)
            var studentWithId10=students.SingleOrDefault(s=>s.StudentId == 10);
            if (studentWithId10 != null)
            {
                Console.WriteLine($"\nStudent with ID = 10: ID: {studentWithId10.StudentId}, Name: {studentWithId10.Name}, Age: {studentWithId10.Age}, Grade: {studentWithId10.Grade}");
            }
            else
            {
                Console.WriteLine("\nNo student found with ID = 10.");
            }
            //Get the first student in the list (First)
            var firstStudent = students.First();
            Console.WriteLine($"\nFirst student in the list: ID: {firstStudent.StudentId}, Name: {firstStudent.Name}, Age: {firstStudent.Age}, Grade: {firstStudent.Grade}");
            //Get the first student with Grade < 60 or null if not exists (FirstOrDefault)
            var firstLowGradeStudent = students.FirstOrDefault(s => s.Grade < 60);
            //Get the highest grade (Max)
            var highestGrade = students.Max(s => s.Grade);
            //Get the lowest grade(Min)
            var lowestGrade = students.Min(s => s.Grade);
            //Get the average grade(Average)
            var averageGrade = students.Average(s => s.Grade);
            //Take the first 3 students(Take)
            var firstThreeStudents = students.Take(3);
            //Get the last student in the list(Last)
            var lastStudent = students.Last();
            //Get the last student with Grade< 60 or null if not exists(LastOrDefault)
            var lastLowGradeStudent = students.LastOrDefault(s => s.Grade < 60);
            Console.WriteLine( $"\nHighest Grade: {highestGrade}, Lowest Grade: {lowestGrade}, Average Grade: {averageGrade}");
            Console.WriteLine("\nFirst 3 students:");
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
            Console.WriteLine($"\nLast student in the list: ID: {lastStudent.StudentId}, Name: {lastStudent.Name}, Age: {lastStudent.Age}, Grade: {lastStudent.Grade}");
            if (lastLowGradeStudent != null)
            {
                Console.WriteLine($"\nLast student with Grade < 60: ID: {lastLowGradeStudent.StudentId}, Name: {lastLowGradeStudent.Name}, Age: {lastLowGradeStudent.Age}, Grade: {lastLowGradeStudent.Grade}");
            }
            else
            {
                Console.WriteLine("\nNo student found with Grade < 60.");
            }

        }
    }
}
