using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            Singletone MyData = Singletone.CreateOrGetInstance();

            MyData.FillLstData();

            int sumFirstObject = MyData.LstDataSum();

            Singletone MySecondData = Singletone.CreateOrGetInstance();

            int sumSecondObject = MySecondData.LstDataSum();

            if(sumFirstObject == sumSecondObject)
            {
                Console.WriteLine("Its 1 object");
            }else
            {
                Console.WriteLine("Its not 1 object");
            }
        }
    }
}
