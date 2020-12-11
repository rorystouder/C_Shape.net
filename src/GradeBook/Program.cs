using System;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
          if(args.Length > 0){
              Console.WriteLine($"Hello, {args[0]} you are the Stong One!");
          }
          else
          {
            Console.WriteLine("it crashed");
          }
        }
    }
}
