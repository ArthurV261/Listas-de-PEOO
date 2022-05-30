using System; 
public class Program {
  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    string[] v = texto.Split('/');
    int d = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    int a = int.Parse(v[2]);
    string r = "A data informada não é valida";
    if (m <= 12 && m >= 1 && a >= 1900 && a <= 2100) {
      switch (m) {
        case 1:
        case 3:
        case 5:
        case 8:
        case 10:
        case 12:
          if (d <= 31 && d >= 1) r = "A data informada é válida";
          break;
        case 2:
          if (d <= 28 && d >= 1) r = "A data informada é válida";
          break;
        default:
          if (d <= 30 && d >= 1) r = "A data informada é válida";
          break;
      }
    }
    Console.WriteLine(r);
  }
}