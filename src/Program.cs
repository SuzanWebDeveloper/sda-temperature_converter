using System;
class Temperature
{
  public static string TempConvert(double amount, string unit)
  {
    string result;
    if (unit == "F")
    {
      double converted = (amount - 32) * 5 / 9;
      result = Math.Round(converted, 2) + " C";
    }
    else
    {
      double converted = (amount * 9 / 5) + 32;
      result = Math.Round(converted, 2) + " F";
    }
    return result;
  }

  public static void Main(String[] args)
  {
    string result;
    Console.WriteLine("Enter a temperature and its unit(C or F):");
    string input = Console.ReadLine() ?? "";
    string[] inputSplitted = input.Split(" ");
    result = TempConvert(Convert.ToDouble(inputSplitted[0]), inputSplitted[1]);
    Console.WriteLine($"Converted: {input} = {result}");
  }
}