using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            
            List<int> bestDnaArr = new List<int>();

            int bestDnaIndex = 0;
            int bestSequenceStart = int.MaxValue;
            int bestSeqenceLegth = 0;
            int count = 0;

            while (input != "Clone them!")
            {
                List<int> currentDna = Console.ReadLine().Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();


                //List<int> currentDna = new List<int>();
                //for (int i = 0; i < input.Length; i++)
                //{
                //    char symbol = input[i];
                //    if (symbol == '0')
                //    {
                //        currentDna.Add(0);
                //    }
                //    else if (symbol == '1')
                //    {
                //        currentDna.Add(1);
                //    }

                //}

                int startIndex = 0;
                int currentLength = 1;
                int bestSeqStart = 0;
                int longestSeq = 1;
                

                for (int i = 1; i < currentDna.Count; i++)
                {
                    if (currentDna[i] == 1 && currentDna[i] == currentDna[i - 1])
                    {

                        currentLength++;
                        if (currentLength > longestSeq)
                        {
                            longestSeq = currentLength;
                            bestSeqStart = startIndex;
                        }
                    }
                    else
                    {
                        currentLength = 1;
                        startIndex = i;
                    }
                }
                    count++;

                if (bestSeqStart < bestSequenceStart && longestSeq >= bestSeqenceLegth)
                {
                    bestSequenceStart = bestSeqStart;
                    bestSeqenceLegth = longestSeq;
                    bestDnaIndex = count;
                    bestDnaArr.Clear();
                    bestDnaArr.AddRange(currentDna);
                }
                else if (bestSeqStart == bestSequenceStart && longestSeq == bestSeqenceLegth)
                {
                    if (currentDna.Sum() > bestDnaArr.Sum())
                    {
                        bestDnaArr.Clear();
                        bestDnaArr.AddRange(currentDna);
                        bestDnaIndex = count;
                    }
                }

                input = Console.ReadLine();
            }
            
                Console.WriteLine($"Best DNA sample {bestDnaIndex} with sum: {bestDnaArr.Sum()}.");
                Console.WriteLine(string.Join(" ", bestDnaArr));

            

        }
    }
}
