using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Please Enter An Inch Measurement: ");
    
       const double CentimetersPerInch = 2.54;
    string input = Console.ReadLine();
 
    double inches;

    if (double.TryParse(input, out inches))
    {
    double centimeters = inches * CentimetersPerInch;

    
    Console.WriteLine($"{inches} inches is {centimeters} centimeters");
      }
    else
    {
      Console.WriteLine("Invalid input. ", "Enter a valid number.");
    }
  
  }

  private static string ConcatName(string firstName, string lastName) {
    return $"{firstName} {lastName}";
  }
}