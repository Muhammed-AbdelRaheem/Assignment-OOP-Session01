using Common;
using System.ComponentModel;

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


        }


    }



}



