using System;

namespace FirstProject
{
  class MainClass
  {

    public static void Main(string[] args)
    {
      int value = 0;
      float[] floatArray = {1.2f, 5.3f, 45.3f, 45.1f, 89.1236f, 5.0f};
      while(value <= 5){
        Console.WriteLine(floatArray[value]);
        value++;
      }

    }
  }
}
