using SuperFizzBuzzLibrary;
using System;
using System.Collections.Generic;

namespace Console.AdvancedFizzBuzz{
  class Program {

    // AdvancedFizzBuzz
    static void Main(string[] args) {
      Dictionary<Int64, String> tokens = new Dictionary<Int64, String> {
          {3, "Fizz"},
          {5, "Buzz"},
          {38, "Bazz"}
      };

      SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(tokens);
      List<String> output = superFizzBuzzLibrary.GenerateOutput(-12, 145);   
                
      foreach (var o in output)
      {
          System.Console.WriteLine(o);
      }
    }
  }
}

