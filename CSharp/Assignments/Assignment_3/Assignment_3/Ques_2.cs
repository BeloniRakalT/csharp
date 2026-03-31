using System;

namespace Assignment_3
{
    class Student
    {
        int rollno;
        string name;
        string studentClass;
        int semester;
        string branch;
        int[] marks = new int[5];

        // Constructor
        public Student(int rollno, string name, string studentClass, int semester, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.studentClass = studentClass;
            this.semester = semester;
            this.branch = branch;
        }

        // Input marks
        public void GetMarks()
        {
            Console.WriteLine("\nEnter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Result calculation
        public void DisplayResult()
        {
            int total = 0;
            bool fail = false;

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                    fail = true;

                total += marks[i];
            }

            double avg = total / 5.0;

            Console.WriteLine("Average Marks: " + avg);

            if (fail)
                Console.WriteLine("Result: FAIL (One subject < 35)");
            else if (avg < 50)
                Console.WriteLine("Result: FAIL (Average < 50)");
            else
                Console.WriteLine("Result: PASS");
        }

        // Display student data
        public void DisplayData()
        {
            Console.WriteLine("\n--- STUDENT DETAILS ---");
            Console.WriteLine("Roll No  : " + rollno);
            Console.WriteLine("Name     : " + name);
            Console.WriteLine("Class    : " + studentClass);
            Console.WriteLine("Semester : " + semester);
            Console.WriteLine("Branch   : " + branch);
        }
    }

    internal class Ques_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- STUDENT PROGRAM ----");

            Console.Write("Enter Roll No: ");
            int roll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Class: ");
            string cls = Console.ReadLine();

            Console.Write("Enter Semester: ");
            int sem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();

            Student s = new Student(roll, name, cls, sem, branch);

            s.DisplayData();
            s.GetMarks();
            s.DisplayResult();

            Console.ReadLine();
        }
    }
}