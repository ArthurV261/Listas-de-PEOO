using System; 

public class Program {

  public static void Main(string[] args) {
    
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double x = (a * b)/ 12;
    Console.WriteLine($"{x:0.000}");
  }
}
