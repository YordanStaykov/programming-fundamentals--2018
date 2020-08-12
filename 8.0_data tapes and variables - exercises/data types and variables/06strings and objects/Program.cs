using System;

namespace _06strings_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object sentence = hello + " " + world;
            string objToStr = (string)sentence;
            Console.WriteLine(objToStr);
        }
    }
}
