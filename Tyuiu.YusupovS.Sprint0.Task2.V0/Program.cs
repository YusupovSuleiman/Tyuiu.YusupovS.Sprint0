﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YusupovS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.YusupovS.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из бибилиотеки Tyuiu.YusupovS.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataServise.GetMessage("Игорь"));
            Console.ReadKey();
        }
    }
}
