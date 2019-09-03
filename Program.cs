using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRankingApplication
{
 
    class student
    {


        static void Main(string[] args)
        {
            //create a new list students
            List<Student> students = new List<Student>();
            //get the number of students 
            Console.WriteLine("Enter the number of students :");
            int studentNumber = 0;
            while(!int.TryParse(Console.ReadLine(), out studentNumber))
            {
                Console.WriteLine("You have entered an invalid input");
                Console.WriteLine("Please enter a valid number of students");
            }
            //run for the number of students given
            for (int i = 0; i < studentNumber; i++)
            {

                Console.WriteLine("Enter the name of the student :");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the student's marks for SCIENCE :");
                int science = 0;
                    while (!int.TryParse(Console.ReadLine(), out science))
                {
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Please enter a valid number of marks");
                }

                Console.WriteLine("Enter the student's marks for MATHS :");
                int maths = 0;
                while(!int.TryParse(Console.ReadLine(), out maths))
                {
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Please enter a valid number of marks");
                }

                Console.WriteLine("Enter the student's marks for ENGLISH :");
                int english = 0;
                while(!int.TryParse(Console.ReadLine(), out english))
                {
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Please enter a valid number of marks");
                }
                //creates an object student
                Student student = new Student(name, maths, english, science);
                //adds the object student into the list students
                students.Add(student);
            }

            students.OrderByDescending(m => m.total);
            //method to Rank and Display
            RankAndDisplay(students);
        }
        //using RankAndDisplay extension Method called as an instance method
        static void RankAndDisplay(List<Student> students)
        {
            var rankedData = students.Select(s => new {
                position = students.Count(x => x.total > s.total) + 1,//research
                Name = s.name,
                Score = s.total,
                Science = s.science,
                Maths = s.maths,
                English = s.english
  
            }).OrderBy(i => i.position);
            foreach (var item in rankedData)
            {
                Console.WriteLine($"Position:{item.position} Name:{item.Name} English:{item.English} Maths:{item.Maths} Science:{item.Science} Total:{item.Score} ");
            }

        }
        
    }
}
