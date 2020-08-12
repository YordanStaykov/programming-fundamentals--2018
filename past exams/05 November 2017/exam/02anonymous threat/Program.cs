using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02anonymous_threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] toDo = command.Split();
                string whatToDo = toDo[0];
                if (whatToDo == "merge")
                {
                    int startIndex = int.Parse(toDo[1]) ;
                    int endIndex = int.Parse(toDo[2]);

                    if (endIndex > input.Count - 1 )
                    {
                        endIndex = input.Count - 1;
                    }
                    else if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    if (startIndex > input.Count - 1)
                    {
                        startIndex = input.Count - 1;
                    }
                    else if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    StringBuilder newWord = new StringBuilder();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newWord.Append(input[i]);
                    }
                    
                    
                    input.RemoveRange(startIndex,endIndex - startIndex + 1);
                    input.Insert(startIndex, newWord.ToString());

                }
                else if (whatToDo == "divide")
                {
                    int index = int.Parse(toDo[1]);
                    int partitions = int.Parse(toDo[2]);
                    List<string> chunksArray = new List<string>();
                    string word = input[index];

                    if (word.Length % partitions == 0)
                    {
                        int chunkSize = word.Length / partitions;
                        for (int i = 0; i < word.Length; i += chunkSize)
                        {
                            string chunk = word.Substring(i, chunkSize);
                            chunksArray.Add(chunk);
                        }
                    }
                    else
                    {
                        int chunkSize = input[index].Length / partitions;
                        int leftover = word.Length % partitions;

                        for (int i = 0; i < word.Length; i += chunkSize)
                        {
                            string chunk = word.Substring(i, chunkSize);
                            chunksArray.Add(chunk);
                        }
                        
                    }

                    input.RemoveAt(index);
                    input.InsertRange(index, chunksArray);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
