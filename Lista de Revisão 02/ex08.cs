using System;
public class Program {
  public static void Main(string[]args){    
  int aux =0;
    Console.WriteLine("Digite quatro valores:");
    int v1 = int.Parse(Console.ReadLine());
    int v2 = int.Parse(Console.ReadLine());
    int v3 = int.Parse(Console.ReadLine());
    int v4 = int.Parse(Console.ReadLine());
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
    if (v1 > v4)
    {
      aux = v1;
      v1 = v4;
      v4 = aux;
    }
    if (v2 > v3)
    {
      aux = v2;
      v2 = v3;
      v3 = aux;
    }
    if (v2 > v4)
    {
      aux = v2;
      v2 = v4;
      v4 = aux;
    }
    if (v3 > v4)
    {
      aux = v3;
      v3 = v4;
      v4 = aux;
    }  
    
Console.WriteLine(v1+","+v2+","+v3+","+v4);
    Console.WriteLine("Maior Valor: " + (v4));
    Console.WriteLine("Menor Valor: " + (v1));
    Console.WriteLine("A soma do Segundo menor com Segundo maior" + (v2+v3));
  }
}