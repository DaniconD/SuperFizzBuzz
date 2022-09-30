using System;
using System.Collections.Generic;

namespace SuperFizzBuzzLibrary;

// This class provides se following rules: 
// • Can produce fizzbuzz output for a user-supplied range of numbers – e.g., from 2 to 35, or from 1 to 1,000,000,000, or from -1 to -35, etc.
// • Can produce output for a user supplied set of integers, even if they’re not sequential.
// • Can generate tokens other than “Fizz” and “Buzz” and can evaluate division by
//    numbers other than 3 and 5. Maybe a user wants to test division by 4, 13, and 9, and
//    output “Frog”, “Duck,” and “Chicken” for them (e.g., in this case, 52 would ouput
//    “FrogDuck”, 36 would output “FrogChicken”, 468 would output “FrogDuckChicken”, etc.)
public class SuperFizzBuzz {
  // Token dictionary structure
  private Dictionary<Int64,String> Tokens { get; set; } 

  // Constructor
  public SuperFizzBuzz(Dictionary<Int64,String> tokens)
  {
      Tokens = tokens;            
  }

  // Final output
  private List<String> Output = new List<String>();

  // Generates an output for a user-supplied range of numbers.
  public List<String> GenerateOutput(long start, long end)
  {
      EvaluateOutputFromRange(start, end);
      return Output;
  }

  // Generates an output for a user supplied set of integers, even if they’re not sequential.
  public List<String> GenerateOutput(long[] input)
  {
      EvaluateOutputFromSet(input);
      return Output;
  }

  // Evaluates from which direction should we add tokens if a range of numbers is porvided.
  private void EvaluateOutputFromRange(long start, long end) {
    if (start <= end) {
      while (start <= end)
      {                    
          Output.Add(GetToken(start));
          start++;
      }
    } else {
      while (start >= end) {                    
          Output.Add(GetToken(start));
          start--;
      }
    }
  }

  // Adds tokens if a set of integers is provided, even if they're not sequential
  private void EvaluateOutputFromSet(long[] input) {            
    foreach(var i in input)
    {                
        Output.Add(GetToken(i));
    }
  }

  // Validate if the current number match any of the token keys returning the matched values, otherwise returns the number, 
  // adds the result to the output
  private string GetToken(long id)
  {
      // Skip if 0 is evaluated
      if (id == 0) return id.ToString();
      String? output = null;            
      
      foreach( var token in Tokens ) {                
          if (Math.Abs(id) % Math.Abs(token.Key) == 0) {
              output += token.Value;                    
          }
      }
      if (output == null) output = id.ToString();

      return output;
  }
}
