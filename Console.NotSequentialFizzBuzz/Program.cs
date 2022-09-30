using SuperFizzBuzzLibrary;
using System;
using System.Collections.Generic;

namespace Console.NotSequentialFizzBuzz;
class Program {

  // NotSequentialFizzBuzz
  // This project is not required for the challange but I added it to see in action
  // how the application works when a set of numbers is provided
  static void Main(string[] args) {
    Dictionary<Int64, String> tokens = new Dictionary<Int64, String> {
      {4, "Frog"},
      {13, "Duck"},
      {9, "Chicken"}
    };

    long[] setOfIntegers = {1,3,4,5,-8,13,15,36,-26,52,468};
    SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(tokens);
    List<String> output = superFizzBuzzLibrary.GenerateOutput(setOfIntegers);   
    
    foreach (var o in output)
    {
        System.Console.WriteLine(o);
    }
  }
}
