using System; 

public class Program {

  public static void Main(string[] args) {
     string s = Console.ReadLine();
       double a = double.Parse(s);
       double A = a * 3.5;
       double b = double.Parse(Console.ReadLine());
       double B = b * 7.5;
       double x = (A + B)/11;
    Console.WriteLine($"MEDIA = {x:0.00000}");
  }
}