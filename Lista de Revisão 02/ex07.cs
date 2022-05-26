using System; 

public class Program {

  public static void Main(string[] args) {
      double a = double.Parse(Console.ReadLine());
      double b = double.Parse(Console.ReadLine());
      double c = double.Parse(Console.ReadLine());
    
      double delta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
      double bhaskara1 = (-b +delta)/(2*a);
      double bhaskara2 = (-b - delta)/(2*a);
    if( delta > 0)
     {
      Console.WriteLine($"As raízes são {bhaskara1} e {bhaskara2}");
     }
    else
    {
     Console.WriteLine("Impossivel calcular");
    }
  }
}