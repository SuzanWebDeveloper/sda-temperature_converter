using System;

class Temperature
{
  public static string TempConvert(int amount, string unit)
  {
    string result;
    if (unit == "F")
    {
      int converted = (amount - 32) * 5 / 9;
      result = converted + " C";
    }
    else
    {
      int converted = (amount * 9 / 5) + 32;
      result = converted + " F";
    }
    return result;
  }

  public static void Main(String[] args)
  {
    string result1 = TempConvert(32, "F");
    Console.WriteLine($"{result1}");
    string result2 = TempConvert(100, "C");
    Console.WriteLine($"{result2}");
  }

}