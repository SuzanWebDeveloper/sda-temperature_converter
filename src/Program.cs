using System;

// Modify the application to prompt the user for a temperature value and a scale (Celsius 'C' or Fahrenheit 'F').
// // Expected output
// Enter a temperature and its unit (C or F):
// > 45 F
// Converted: 45 F = 7.22 C

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
    string result;
    result = TempConvert(32, "F");
    Console.WriteLine($"{result}");
    result = TempConvert(100, "C");
    Console.WriteLine($"{result}");
  }

}