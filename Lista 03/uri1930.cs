using System; 

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] v = s.Split();
    int T1 = int.Parse(v[0]);
    int T2 = int.Parse(v[1]);
    int T3 = int.Parse(v[2]);
    int T4 = int.Parse(v[3]);
    int x = (T1 - 3)+ T2 + T3 + T4;
    Console.WriteLine(x);
  }
}
