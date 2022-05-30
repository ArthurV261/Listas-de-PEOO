using System; 

public class Program {

  public static void Main(string[] args) {
   Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    String s = Console.ReadLine();
    String[] v = s.Split(":");
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    String r = Console.ReadLine();
    String[] w = r.Split(":");
    int a  = int.Parse(v[0]);
    int b  = int.Parse(v[1]);
    int c  = int.Parse(w[0]);
    int d  = int.Parse(w[1]);
    int sobra = 0;
    int min = b + d;
    if (min >= 60) sobra = min - 60;
    int hora = a + c + (sobra/10);
    Console.WriteLine("Total de Horas = {0:00}:{1:00}",hora, sobra);
 }
}