using System; 

public class Program {

  public static void Main(string[] args) {
     string s = Console.ReadLine();
       double a = double.Parse(s);
      double A = Math.Pow(a,3);
       double x = (4/3.0) * 3.14159 * A ;
    Console.WriteLine($"VOLUME = {x:0.000}");
  }
}