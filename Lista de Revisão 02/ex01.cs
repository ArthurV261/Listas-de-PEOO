using System; 

public class Program {

  public static void Main(string[] args) {
   string s = Console.ReadLine();
    int a = int.Parse(s);
   string r = Console.ReadLine();
    int b = int.Parse(r);
   if (a > b) Console.WriteLine(a);
    else 
      if (b > a) Console.WriteLine(b);
       else
         if (a == b) Console.WriteLine("Números iguais");
  } 
}