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
    while (true)
    {
      Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
      string input = Console.ReadLine() ?? "";
      string[] inputSplitted = input.Split(" ");
      if (input.ToLower() == "quit")
      {
        Console.WriteLine("Program terminated.");
        break;
      }
      if (inputSplitted.Length != 2)
      {
        Console.WriteLine("Invalid input. Please enter a temperature and its unit (C or F) \n");
        continue;
      }
      if (!double.TryParse(inputSplitted[0], out double tempValue))
      {
        Console.WriteLine("Invalid input. Please enter a numeric temperature. \n");
        continue;
      }
      string tempUnit = inputSplitted[1].ToUpper();
      if (tempUnit != "C" && tempUnit != "F")
      {
        Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit. \n");
        continue;
      }
      string result = TempConvert(tempValue, tempUnit);
      Console.WriteLine($"Converted: {input} = {result} \n");
    }
  }
}