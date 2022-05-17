using System; 

public class Program {

  public static void Main(string[] args) {
     Console.WriteLine("Digite seu nome completo: ");
           string s = Console.ReadLine();
           string[] v = s.Split();
           Console.WriteLine("Bem Vindo ao C#, " + v[0]);
  }
}
