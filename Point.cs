using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_Session01
{

    //Access Modifier Allowed Inside Struct?
    //    1. Private[Default]
    //    2. Internal
    //    3. Public



    internal struct Point
    {


        //   What You Can Write Inside The Struct Or Class
        //1. Attributes[Fields] => Member Variable

        #region Attribtute
        public int x;
        public int y;
        #endregion

        //2. Functions[Constructor, Getter Setter, Method]

        #region Constructor
        //      Constructor = > always named with same name of struct  or class 
        //                     has no no return
        //  by defult =>  compailer  will always  generate  parametaiers const 
        //               that initialize  attribute of struct with  defulte value of  its datatybe

        //public Point()
        //{
        //    x = 1;
        //    y = 2;
        //// vaild from c#10 .net 6.0
        //}

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        //public Point(int number)
        //{
        //    x = y = number;
        //} 
        #endregion

        #region Method

        public override string ToString()
        {
            return $"({this.x},{this.y})";
        }


        #endregion

        //3. Properties[Full Property, Automatic Property, Indexer]


        //4. Events



    }
}
