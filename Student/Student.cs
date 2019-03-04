using System;
using System.IO;

namespace StudentClass
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public Student[] students { get; set; }

        public Student() { }

        public Student[] GetStudentsFromTextFile(string path, string fileName)
        {
            string[] studentsText = File.ReadAllLines(path + "\\" + fileName);

            // create an array of Student classes from thestudentdata text
            Student[] students = new Student[studentsText.Length];

            for (int i = 0; i < studentsText.Length; i++)
            {
                {
                    string[] studentTextInputFields = studentsText[i].Split(" ");
                    Student student = new Student();
                    student.Name = studentTextInputFields[0];

                    int[] scores = new int[studentTextInputFields.Length - 1];

                    for (int j = 1; j < studentTextInputFields.Length; j++)
                    {
                        scores[j - 1] = int.Parse(studentTextInputFields[j]);

                    }
                    student.Scores = scores;
                    students[i] = student;
                }
            }

            return students;
        }

        public int? GetAverage()
        {
            int scoreSum = 0;

            for (int i = 0; i < Scores.Length; i++)
            {
                scoreSum += Scores[i];
            }

            return (scoreSum / Scores.Length);
        }

        public bool HasSixOrMore()
        {
            return (Scores.Length > 5) ? true : false;
        }

        public int? GetMaximumScore()
        {
            int maxScore = 0;

            for (int i = 0; i < Scores.Length; i++)
            {
                if (Scores[i] > maxScore)
                {
                    maxScore = Scores[i];
                }
            }

            return maxScore;
        }

        public int? GetMinimumScore()
        {
            int minScore = 100;

            for (int i = 0; i < Scores.Length; i++)
            {
                if (Scores[i] < minScore)
                {
                    minScore = Scores[i];
                }
            }

            return minScore;
        }
    }
}
