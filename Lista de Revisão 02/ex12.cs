using System;
class exercicio12 {
  static void Main(){
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    string conta = Console.ReadLine();
    bool soma = conta.Contains("+");
    bool subtração = conta.Contains("-");
    bool multiplicação = conta.Contains("*");
    bool divisão = conta.Contains("/");
    string[] v = conta.Split();
    double total = 0;
    if (soma) {
      v = conta.Split("+");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x+y;
    }
    if (subtração) {
      v = conta.Split("-");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x-y;
    }
    if (multiplicação) {
      v = conta.Split("*");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x*y;
    }
    if (divisão) {
      v = conta.Split("/");
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      total = x/y;
    }
    Console.WriteLine($"O total da operação é {total}");
  }
}