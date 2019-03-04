using System;
using System.IO;
using StudentClass;


namespace StudentConsolidated
{
    class Program
    {
        static void Main(string[] args)
        {
            // read from the studentdata.txt file
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.

            Student student = new Student();

            Student[] students = student.GetStudentsFromTextFile("C:\\Users\\msunk\\Documents\\CoderGirlLC101\\Lesson09 CoderGirl-StudentConsolidatedSolution\\CoderGirl-StudentConsolidated", 
                                                                 "studentdata.txt");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].Name + " - Average - " + students[i].GetAverage());
            }

            Console.WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].Name + " - Maximum - " + students[i].GetMaximumScore() + " - Minimum - " + students[i].GetMinimumScore());
            }

            Console.WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].Name + " - 6 or more - " + students[i].HasSixOrMore());
            }

            Console.ReadLine();
        }
    }
}
