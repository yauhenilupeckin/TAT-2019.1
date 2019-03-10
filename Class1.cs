﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// The Class Program provide main
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 0 && args[0].Length > 2)
            {
                string NewArg = null;

                foreach (string arg in args)
                {
                    NewArg += arg;
                    SearchForConsecutiveSymbol Obj = new SearchForConsecutiveSymbol();
                    Obj.Search(NewArg);

                }
            }


            else
            {

                Console.WriteLine("String contains less than 2 symbols ");

            }

            Console.Read();
        }

    }
}
