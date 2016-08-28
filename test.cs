using System;

namespace FirstProject
{
  class MainClass
  {

    public static void Main(string[] args)
    {
      System.Console.WriteLine("enter an integer between 10 and 50");
      string input = Console.ReadLine();
      int value;
      Int32.TryParse(input, out value);
      if(value < 10){
        System.Console.WriteLine(value + " is too small");
      }
      else if(value < 50){
        System.Console.WriteLine(value + " is fine");
      }
      else {
        System.Console.WriteLine(" too high");
      }
      //Console.ReadKey();
    }
  }
}
