﻿using System;

namespace _06dna_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMatch = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j  = 1; j  <= 4; j ++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if (i + j + k >= numMatch)
                        {
                            Console.Write("O");
                            if (i == 1)
                            {
                                Console.Write("A");
                            }
                            if (i == 2)
                            {
                                Console.Write("C");
                            }
                            if (i == 3)
                            {
                                Console.Write("G");
                            }
                            if (i == 4)
                            {
                                Console.Write("T");
                            }

                            if (j == 1)
                            {
                                Console.Write("A");
                            }
                            if (j == 2)
                            {
                                Console.Write("C");
                            }
                            if (j == 3)
                            {
                                Console.Write("G");
                            }
                            if (j == 4)
                            {
                                Console.Write("T");
                            }

                            if (k == 1)
                            {
                                Console.Write("A");
                            }
                            if (k == 2)
                            {
                                Console.Write("C");
                            }
                            if (k == 3)
                            {
                                Console.Write("G");
                            }
                            if (k == 4)
                            {
                                Console.Write("T");
                            }
                            Console.Write("O" + " ");

                        }
                        else
                        {
                            Console.Write("X");
                            if (i == 1)
                            {
                                Console.Write("A");
                            }
                            if (i == 2)
                            {
                                Console.Write("C");
                            }
                            if (i == 3)
                            {
                                Console.Write("G");
                            }
                            if (i == 4)
                            {
                                Console.Write("T");
                            }

                            if (j == 1)
                            {
                                Console.Write("A");
                            }
                            if (j == 2)
                            {
                                Console.Write("C");
                            }
                            if (j == 3)
                            {
                                Console.Write("G");
                            }
                            if (j == 4)
                            {
                                Console.Write("T");
                            }

                            if (k == 1)
                            {
                                Console.Write("A");
                            }
                            if (k == 2)
                            {
                                Console.Write("C");
                            }
                            if (k == 3)
                            {
                                Console.Write("G");
                            }
                            if (k == 4)
                            {
                                Console.Write("T");
                            }
                            Console.Write("X" + " ");
                        }
                    }
                        Console.WriteLine();
                }
            }
        }
    }
}
