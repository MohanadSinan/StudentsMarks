using System;
using System.Collections.Generic;

namespace StudentsMarks
{
    public class StudentData
    {
        public string StudentName { get; set; }
        public int ID { get; set; }
        public decimal Mark { get; set; }
        public string Status
        {
            get
            {
                if (Mark < 60) return "Failed";
                else return "Passed";
            }
        }

        public override string ToString()
        {
            return ID + "\t" + StudentName + "\t\t" + Mark + "\t" + Status;
        }
    }
    public class Example
    {
        public static void Main()
        {

            // Create a list of Students Data.
            List<StudentData> studentsData = new List<StudentData>();

            // Add students data to the list.
            Console.Write($"Enter the number of students: ");
            var num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n-------------------------------------\n");

            if (num >= 2)
            {
                int id = 1;
                for (int i = 0; i != num; i++)
                {
                    int n = i + 1;
                    Console.Write($"Enter the student {n} name: ");
                    var SetName = Console.ReadLine();
                    Console.Write($"Enter the student {n} mark: ");
                    var SetMark = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("\n-------------------------------------\n");

                    studentsData.Add(new StudentData() { ID = id, StudentName = SetName, Mark = SetMark });
                    id++;
                }
            }
            else
            {
                Console.Write($"Enter the student name: ");
                var SetName = Console.ReadLine();
                Console.Write($"Enter the student mark: ");
                var SetMark = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\n-------------------------------------\n");

                studentsData.Add(new StudentData() { ID = 1, StudentName = SetName, Mark = SetMark });
            }


            /*
            // Add parts to the list.
            studentsData.Add(new StudentData() { ID = 1, StudentName = "Name1", Mark = 100 });
            studentsData.Add(new StudentData() { ID = 2, StudentName = "Name2", Mark = 59.5M });
            studentsData.Add(new StudentData() { ID = 3, StudentName = "Name3", Mark = 42 });
            studentsData.Add(new StudentData() { ID = 4, StudentName = "Name4", Mark = 88 });
            studentsData.Add(new StudentData() { ID = 5, StudentName = "Name5", Mark = 61 });
            studentsData.Add(new StudentData() { ID = 6, StudentName = "Name6", Mark = 60.5M });
            */

            // Write out the studentsData in the list. This will call the overridden ToString method
            // in the StudentData class.
            Console.WriteLine("[ID]\t[Name]\t\t[Mark]\t[Status]");
            foreach (StudentData aStudentData in studentsData)
            {
                Console.WriteLine(aStudentData);
            }
        }

    }
}
