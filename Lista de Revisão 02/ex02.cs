using System; 

public class Program {

  public static void Main(string[] args) {
   int a = int.Parse(Console.ReadLine());
   int b = int.Parse(Console.ReadLine());
   int c = int.Parse(Console.ReadLine());
   int d = int.Parse(Console.ReadLine());
    int x = (a + b + c + d)/ 4;
    Console.WriteLine("Média = " + x);
    Console.WriteLine("Números menores que a média");
    if (a < x) Console.WriteLine(a);
    if (b < x) Console.WriteLine(b);
    if (c < x) Console.WriteLine(c);
    if (d < x) Console.WriteLine(d);
    Console.WriteLine("Números maiores ou igual que a média");
    if (a >= x) Console.WriteLine(a);
    if (b >= x) Console.WriteLine(b);
    if (c >= x) Console.WriteLine(c);
    if (d >= x) Console.WriteLine(d);
  } 
} 