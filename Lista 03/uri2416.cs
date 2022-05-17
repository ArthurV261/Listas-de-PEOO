using System; 

public class Program {

  public static void Main(string[] args) {
     string s = Console.ReadLine();
     string[] v = s.Split();
      int a = int.Parse(v[0]);
      int b = int.Parse(v[1]);
      int x = a / b;
      int X = b * x;
      int c = a - X;
     Console.WriteLine(c);

  }
}