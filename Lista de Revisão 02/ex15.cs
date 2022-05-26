
using System;
public class Program {
  public static void Main(string[] args) {
   
    int aux =0;
    
    Console.WriteLine("Digite três valores:");
    
    int v1 =int.Parse(Console.ReadLine());
    int v2 =int.Parse(Console.ReadLine());
    int v3 =int.Parse(Console.ReadLine());

    if (v1 > v2)
    {
      aux = v1;
      v1 = v2;
      v2 = aux;
    }

    if (v1 > v3)
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
    Console.WriteLine(v1+","+v2+","+v3);
    
  }  
}