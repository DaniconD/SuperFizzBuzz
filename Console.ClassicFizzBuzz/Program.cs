using SuperFizzBuzzLibrary;
using System;
using System.Collections.Generic;

namespace Console.ClassicFizzBuzz{
  class Program {

    // ClassicFizzBuzz
    static void Main(string[] args) {
      Dictionary<Int64, String> tokens = new Dictionary<Int64, String> {
        {3, "Fizz"},
        {5, "Buzz"}
      };

      SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(tokens);
      List<String> output = superFizzBuzzLibrary.GenerateOutput(1, 100);   
      
      foreach (var o in output)
      {
          System.Console.WriteLine(o);
      }
    }
  }
  
}
