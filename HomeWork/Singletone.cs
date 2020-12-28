using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Singletone
    {
        public static Singletone Instance;
        public static List<int> Lst = new List<int>();
        public static Singletone CreateOrGetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singletone();

                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private Singletone() { }
        public void FillLstData()
        {
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Lst.Add(random.Next(-1000, 1000));
            }
        }
        public int LstDataSum()
        {
            int sum = 0;
            foreach(var i in Lst)
            {
                sum += i;
            }

            return sum;
        }
    }
}
