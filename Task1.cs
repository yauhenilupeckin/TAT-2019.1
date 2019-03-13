﻿using System;

namespace task1
{
    class interpoint                          //line analysis for repeated > 1 consecutive characters.
    {
        public string str;

        public void CheckRepeat()                  //check reps.
        {
            int n = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])                            //all possible combinations without double sign.
                {
                    for (int k = 0; k < n; k++)
                    {
                        for (int j = i - n + k; j <= i; j++)
                        {
                            Console.Write(str[j]);
                        }
                        Console.Write("\n");
                    }
                    n = n + 1;
                }
                else
                {
                    n = 1;
                }
            }
        }
    }
    class commandlineinstallation //lcommand line conditions.
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("There are more than one command line parameters, only the first one will be considered."); //There are more than one command line parameters
            }

            try
            {
                Console.WriteLine(args[0] + "\n");

                interpoint str1 = new interpoint
                {
                    str = args[0]
                };

                str1.CheckRepeat();
            }
            catch
            {
                Console.WriteLine("Command line parameters are not specified, the string 'access' will be used."); //Command line parameters are not specified.

                Console.WriteLine("access \n");

                interpoint str1 = new interpoint
                {
                    str = "access"
                };

                str1.CheckRepeat();
            }

            Console.ReadKey();
        }
    }
}