using System; 

public class Program {

  public static void Main(string[] args) {
    char[] arr ={'/'};
    String s = Console.ReadLine();
    String[] v = s.Split(arr);
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);
    switch(b)
    {
      case 1: Console.WriteLine($"A  data é {a} de Janeiro de {c}"); break;
      case 2: Console.WriteLine($"A  data é {a} de Fevereiro de {c}"); break;
      case 3: Console.WriteLine($"A  data é {a} de Março de {c}"); break;
      case 4: Console.WriteLine($"A  data é {a} de Abril de {c}"); break;
      case 5: Console.WriteLine($"A  data é {a} de Maio de {c}"); break;
      case 6: Console.WriteLine($"A  data é {a} de Junho de {c}"); break;
      case 7: Console.WriteLine($"A  data é {a} de Julho de {c}"); break;
      case 8: Console.WriteLine($"A  data é {a} de Agosto de {c}"); break;
      case 9: Console.WriteLine($"A  data é {a} de Setembro de {c}"); break;
      case 10: Console.WriteLine($"A  data é {a} de Outubro de {c}"); break;
      case 11: Console.WriteLine($"A  data é {a} de Novembro de {c}"); break;
      case 12: Console.WriteLine($"A  data é {a} de Dezembro de {c}"); break;
    }
  }
}