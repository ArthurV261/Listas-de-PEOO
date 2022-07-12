using System;

public class Program{
  public static void Main(string[] args){
    int i = 1;
    int i2 = 1;
    while(i <= 30){
      Console.Write(i + i2);
      i++;
      i2 = i2 + i2;
    }
  }
}