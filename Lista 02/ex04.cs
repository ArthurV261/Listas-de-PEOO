using System; 

public class Program {

  public static void Main(string[] args) {
      Console.WriteLine("Digite o valor da base");
        string s = Console.ReadLine();
        double b = double.Parse(s);
           
      Console.WriteLine("Digite o valor da altura");
        string r = Console.ReadLine();
        double h = double.Parse(r);

      double a = b * h;
      double p = b * 2 + h * 2;
      double d = Math.Sqrt(Math.Pow(b,2) + Math.Pow(h,2));
      Console.WriteLine($"Àrea = {a:0.00}");
      Console.WriteLine($"Perímetro = {p:0.00}");
      Console.WriteLine($"Diagonal = {d:0.00}");
  }
}
