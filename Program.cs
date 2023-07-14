using System;


namespace _14july2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jagged Array
            //int noc, nos;             //noc=number of class; nos=number of student
            //Console.WriteLine("Enter Number of Classes");
            //noc = int.Parse(Console.ReadLine());
            //string[][] students = new string[noc][];
            //for (int i = 0; i < noc; i++)
            //{
            //    Console.WriteLine("Enter Number of Student in Class " + (i + 1));
            //    nos = int.Parse(Console.ReadLine());

            //    students[i] = new string[nos];
            //    for (int j = 0; j < nos; j++)
            //    {
            //        Console.WriteLine($"Enter Student {j + 1}\'s name");
            //        students[i][j] = Console.ReadLine();
            //    }
            //}
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($" Students List of class {i + 1}");
            //    Console.WriteLine("************************");
            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        Console.WriteLine(students[i][j]);
            //    }
            //    Console.WriteLine("************************");
            //}
            //Console.ReadKey();

            //Jagged Array Exercise-01
            //Console.Write("Enter the number of employees: ");
            //int numEmployees = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the number of working days for each employee: ");
            //int numDays = Convert.ToInt32(Console.ReadLine());

            //// Create a jagged array to store salaries
            //int[][] salaries = new int[numEmployees][];

            // Input salaries for each employee
            //for (int i = 0; i < numEmployees; i++)
            //{
            //    salaries[i] = new int[numDays];

            //    for (int j = 0; j < numDays; j++)
            //    {
            //        Console.Write($"Enter salary for Employee {i + 1}, Day {j + 1}: ");
            //        salaries[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            // Display the salary for each day and calculate the total salary for each employee
            //Console.WriteLine("\nDay1\tDay2\tDay3\tDay4\tDay5\tTotalSalary");

            //for (int i = 0; i < numEmployees; i++)
            //{
            //    int totalSalary = 0;

            //    for (int j = 0; j < numDays; j++)
            //    {
            //        Console.Write($"{salaries[i][j]}\t");
            //        totalSalary += salaries[i][j];
            //    }

            //    Console.WriteLine(totalSalary);
            //}

            //Console.ReadKey();

            int r, c;
            int[][,] myJArray = new int[3][,];
            myJArray[0] = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            myJArray[1] = new int[3, 2] { { 1, 2 }, { 2, 3 },{5,4 } };
            myJArray[2] = new int[3, 3] { { 1, 2,6 }, { 2, 3,7 },{5,4,8 } };
            Console.WriteLine("Stored Values are");
            for(int i=0; i<myJArray.Length;i++)
            {
                for (r = 0; r < myJArray[i].GetLength(0); r++)
                {
                    for (c = 0; c < myJArray[i].GetLength(0); c++)
                    {
                        Console.Write(myJArray[i][r, c] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("***********************");

            }
            Console.ReadKey();
        }
    }
}
