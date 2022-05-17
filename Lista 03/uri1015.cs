using System; 

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] v = s.Split();
    double x1 = double.Parse(v[0]);
    double y1 = double.Parse(v[1]);

    string r = Console.ReadLine();
    string[] w = r.Split();
    double x2 = double.Parse(w[0]);
    double y2 = double.Parse(w[1]);

    double a = Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2);
    double b = Math.Sqrt(a);
    Console.WriteLine($"{b:0.0000}");
  }
}