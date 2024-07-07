using Common;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Assignment_OOP_Session01
{
    //What You Can Write Inside Namespace ?
    //1. Class
    //2. Struct
    //3. Interface
    //4. Enum


    //    What You Can Write Inside Namespace?
    //1. Class
    //2. Struct
    //3. Interface
    //4. Enum





    internal class Program
    {

        #region Exp Handling
        static void DoSomeCode()
        {
            try
            {
                int x, y, z;

                x = int.Parse(Console.ReadLine()); // system.formatExp
                y = int.Parse(Console.ReadLine());
                z = x / y; //system.diviedbyzeroexp



                int[] numbers = { 1, 2, 3 }; // siz 3
                numbers[10] = 100; // system.indexoutofrange
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void DoSomeProtictevCode()
        {
            int x, y, z;
            bool flag;

            do
            {
                Console.WriteLine("enter first Number");
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);

            do
            {
                Console.WriteLine("enter Secound Number");
                flag = int.TryParse(Console.ReadLine(), out y);
            }
            while (!flag || y == 0);

            z = x / y;



            int[] numbers = { 1, 2, 3 };
            if (numbers?.Length > 10)
            {
                numbers[10] = 100;

            }

        }

        #endregion


        public enum Days
        {
            Saturday,
            sunday, 
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
        }

        public enum Grades
        {
            A,B, C, D, E, F
        }
        public enum Gender
        {
           Male=1 ,Female=2
        }


        [Flags]
        public enum Permession
        {
            Delete =1 ,Exectue = 2 ,Read =4 ,Write = 8

        }

        class employee
        {
            public string name;
            public int age;
            public Gender gender;
            public decimal salary;
            public Permession permession;
        }

        static void Main(string[] args)
        {

            #region Exp Handling
            //DoSomeCode();

            //try
            //{
            //    DoSomeProtictevCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //Close, Delete,Release
            //    //Open File
            //    //Conection With Database
            //}
            //Console.WriteLine("After Try Catch"); 
            #endregion


            #region Access Modifiers


            TypeA typeA = new  TypeA(); // vailed

            //TypeB typeB = new TypeB(); //invailed

            //typeA.x=10 //invaild
            //typeA.y = 10; // invaild
            //typeA.z = 10;//vaild
            #endregion


            #region Enum

            //Days day = Days.sunday;

            #region Ex01

            //Grades x = Grades.A;
            //if (x==Grades.A)
            //{
            //    Console.WriteLine(":)");

            //}
            //else
            //{
            //    Console.WriteLine("):");


            //}
            //Grades y = (Grades)2;
            //Console.WriteLine( y );

            #endregion

            #region EX02
            //Console.WriteLine(  "Please Enter Your Grade");
            ////Grades x = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //bool Result = Enum.TryParse(typeof(Grades), Console.ReadLine(), out object x);
            //Console.WriteLine($"result is {Result}"  );
            //Console.WriteLine( $"Your grade Is {x}" );

            #endregion

            #region Ex03

            ////Gender G1 = Gender.Female; // Female
            ////Gender G2 = (Gender)2;     //Female


            //string Gender = "male";

            ////Enum.TryParse(typeof(Gender), Console.ReadLine(), out object Result);


            ////bool flag=  Enum.TryParse<Gender>(Gender,out Gender Result);
            //bool flag=  Enum.TryParse<Gender>(Gender,true,out Gender Result);

            //Console.WriteLine( flag );
            //Console.WriteLine(Result);

            #endregion

            #region Ex04


            employee employee =  new employee();
            employee.name = "mohamed";
            //employee.permession = Permession.Write;

            //employee.permession = (Permession)3;//Delete,Excute
            //Console.WriteLine(employee.permession);

            ////if u want to add permession (read)
            ////    Do XOR Operator

            //employee.permession = employee.permession^Permession.Read;
            //Console.WriteLine(employee.permession);         //Delete,Excute ,read

            ////if u want to remove permession (read)
            ////    Do XOR Operator

            //employee.permession = employee.permession ^ Permession.Read;
            //Console.WriteLine(employee.permession);//Delete,Excute



            ////if u want to check if delete is Existed or not
            ////    do and operation 
            ////            &

            //employee.permession = employee.permession & Permession.Delete;

            //if delete exited => Return Delete value 
            //    if not => reture random value



            //if ((employee.permession & Permession.Read)== Permession.Read)
            //{
            //    Console.WriteLine("read is Exicted");

            //}
            //else
            //{

            //    employee.permession = employee.permession ^ Permession.Read;

            //}



            //if u want to check if peromession is exict or not 
            //    if  exicted  = > do nothing
            //    if not exicte =>add 
            //    do OR Operation

            employee.permession = employee.permession | Permession.Read;
            Console.WriteLine(employee.permession);

            #endregion




            #endregion


        }

        enum Roles
        {
            Admin = 10, Editor = 20 ,Viewer=30
        }


    }



}



