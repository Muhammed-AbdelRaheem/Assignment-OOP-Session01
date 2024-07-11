using System.Drawing;

namespace Assignment
{
    internal class Program
    {

        #region Q1
        public enum WeekDays
        {
            Saturday,
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
        }

        #endregion

        #region Q2
        public enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        #endregion

        #region Q3

        class Employee
        {
            public string Name;
            public int Age;
            public Permessions permession;

        }

        [Flags]
        public enum Permessions : byte
        {
            Read = 1, write = 2, Delete = 4, Execute = 8
        }

        #endregion

        #region Q4
        public enum Colors
        {
            Red = 1, Green=2, Blue=3
        }

        static bool IsPrimary(Colors color)
        {
            switch (color)
            {
                case Colors.Red:
                case Colors.Green:
                case Colors.Blue:


                    return true;

                default:




                    return false;
            }


        }
        #endregion


        






        static void Main(string[] args)
        {


            #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.


            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);

            //}




            #endregion


            #region 2.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter)");

            //string? input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{

            //    switch (season)
            //    {
            //        case Season.Spring:

            //            Console.WriteLine("Spring: March to May");

            //            break;

            //        case Season.Winter:

            //            Console.WriteLine("Winter: December to February");

            //            break;
            //        case Season.Summer:

            //            Console.WriteLine("Summer: June to August");

            //            break;
            //        case Season.Autumn:

            //            Console.WriteLine("Autumn: September to November");

            //            break;

            //        default:
            //            Console.WriteLine("Please Insert Vailed Season");

            //            break;

            //    }



            //}






            #endregion

            #region 3.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            ////Create Variable from previous Enum to Add and Remove Permission from variable, 
            ////  check if specific Permission is existed inside variable



            //Employee emp = new Employee();

            //emp.permession = (Permessions)8;

            //if ((emp.permession & Permessions.Delete) == Permessions.Delete)
            //{
            //    Console.WriteLine("Delete IS Exicted");
            //}
            //else
            //{

            //    emp.permession = emp.permession ^ Permessions.Delete;

            //}
            //if ((emp.permession & Permessions.Read) == Permessions.Read)
            //{
            //    Console.WriteLine("Read IS Exicted");
            //}
            //else
            //{

            //    emp.permession = emp.permession ^ Permessions.Read;

            //}
            //if ((emp.permession & Permessions.Execute) == Permessions.Execute)
            //{
            //    Console.WriteLine("Execute IS Exicted");
            //}
            //else
            //{

            //    emp.permession = emp.permession ^ Permessions.Execute;

            //}
            //if ((emp.permession & Permessions.write) == Permessions.write)
            //{
            //    Console.WriteLine("write IS Exicted");
            //}
            //else
            //{

            //    emp.permession = emp.permession ^ Permessions.write;

            //}






            #endregion

            #region 4.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Please Insert The Color");

            //string? input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{

            //    if (IsPrimary( color))
            //    {
            //      Console.WriteLine($"{input} Is A Primary Color");
            //    }
            //    else
            //    {
            //       Console.WriteLine($"{input} Is Not A Primary Color");

            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Please Insert Vailed color");
            //}





            #endregion

            #region 5.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.


            //Console.WriteLine("Enter coordinates of Point 1 (x1 y1):");

            //string[] input01 = Console.ReadLine().Split();

            //double x1 = double.Parse(input01[0]);
            //double y1 = double.Parse(input01[1]);

            //Console.WriteLine("Enter coordinates of Point 2 (x2 y2):");

            //string[] input02 = Console.ReadLine().Split();

            //double x2 = double.Parse(input02[0]);
            //double y2 = double.Parse(input02[1]);

            //Point P01= new Point(x1, y1); ;
            //Point P02= new Point(x2, y2);

            //double Distance=P01.DistanceTo(P02);

            //Console.WriteLine($"Distance between Point 1 and Point 2: {Distance}");




            #endregion

        }
    }
}
