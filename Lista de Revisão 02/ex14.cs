using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite três valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
 if ( a + b > c && a + c > b && b + c > a)
    {
      if (a == b && a == c)
        Console.WriteLine("Os 3 lados formam um triângulo Equilátero\n");
        else
          if (a == b || a == c || b == c)
            Console.WriteLine("Os 3 lados formam um triângulo Isósceles\n");
            else 
              Console.WriteLine("Os 3 lados formam um triângulo Escaleno\n");
    }
    else 
      Console.WriteLine("Esses valores não formam um triângulo");
  }
}