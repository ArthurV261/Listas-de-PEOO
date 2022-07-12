using System;

public class Program{
  public static void Main(string[] args){
    string texto = Console.ReadLine().ToLower();
    int x = texto.Length;
    int i = 1;
    string letras = "";
    while(i <= x){
      if(texto.Substring(i-1, i) == "a" || texto.Substring(i-1, i) == "e" || texto.Substring(i-1, i) == "i" || texto.Substring(i-1, i) == "o" || texto.Substring(i-1, i) == "u") letras += texto.Substring(i-1, i);
      i++;
    }
    Console.WriteLine(letras);
  }
}