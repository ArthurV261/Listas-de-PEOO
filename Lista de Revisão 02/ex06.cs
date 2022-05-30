using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores inteiros:");
    int v1 = int.Parse(Console.ReadLine());
    int v2 = int.Parse(Console.ReadLine());
    int v3 = int.Parse(Console.ReadLine());
    int aux = 0;
    if (v1 > v2) 
    {
      aux = v1;
      v1 = v2;
      v2 = aux;
    }
    if(v1 > v3)
    {
      aux = v1;
      v1 = v3;
      v3 = aux;
    }
    if (v2 > v3)
    {
      aux = v2;
      v2 = v3;
      v3 = aux;
    }
    int valor = v1 + v3;
  Console.WriteLine("A soma do maior com o menor número é " + valor);
  }
}