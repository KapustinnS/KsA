﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "abcdefwxyz";
            string x = Console.ReadLine();
            if (data.Contains(x))
            {
                Console.Write("Содержиться");
            }
            else
            {
                Console.Write("Не содержится");
            }
        }
    }
}
