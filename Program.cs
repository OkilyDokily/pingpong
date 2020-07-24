using System;
using PingPong.Models;
using System.Collections.Generic;
namespace PingPong{
  public class Program{
    public static void Main(){
    Console.WriteLine("Enter a number");
    int number = int.Parse(Console.ReadLine());
    List<string> results = PingAndOrPong.createListWithInputNumber(number);
      foreach(string result in results){
        Console.WriteLine(result);
      }
    }

  }
}