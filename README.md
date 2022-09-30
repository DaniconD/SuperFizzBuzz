# SuperFizzBuzz .NET 6.0

## Background: Classic FizzBuzz
Classic fizzbuzz output is typically described as “Write a program that prints the numbers from 1
to 100. But for multiples of 3, print “Fizz” instead of the number. For multiples of 5, print “Buzz”.
For Multiples of 3 and 5, print “FizzBuzz”.

## Requirements: Super FizzBuzz

1. Develop a class library called SuperFizzBuzz that can do the following:

    • Can produce fizzbuzz output for a user-supplied range of numbers – e.g., from 2 to
    35, or from 1 to 1,000,000,000, or from -1 to -35, etc.

    • Can produce output for a user supplied set of integers, even if they’re not sequential.

    • Can generate tokens other than “Fizz” and “Buzz” and can evaluate division by
    numbers other than 3 and 5. Maybe a user wants to test division by 4, 13, and 9, and
    output “Frog”, “Duck,” and “Chicken” for them (e.g., in this case, 52 would ouput
    “FrogDuck”, 36 would output “FrogChicken”, 468 would output “FrogDuckChicken”,
    etc.)
  
2. Write a console application, using your SuperFizzBuzz class, to solve the classic FizzBuzz
problem as described above in “Classic FizzBuzz”.

3. Write a second console application demonstrating advanced usage of SuperFizzBuzz that
performs the following:

    a. Print the numbers from -12 through 145.

    b. For multiples of 3, print “Fizz”

    c. For Multiples of 7, print “Buzz”

    d. For Multiples of 38, print “Bazz”

    e. Print the appropriate combination of tokens for any number that matches more
    than one of those rules

4. In your solution, include tests for your SuperFizzBuzz class and any other related classes
you develop.

# Included in this project:

• Class library "SuperFizzBuzz"
    
• Console application "Console.ClassicFizzBuzz" that solves the classic implementation, command to execute in root `dotnet run --project Console.ClassicFizzBuzz/Console.ClassicFizzBuzz.csproj`
    
• Console application "Console.SuperFizzBuzz" that solves the advanced implementation, command to execute in root `dotnet run --project Console.SuperFizzBuzz/Console.SuperFizzBuzz.csproj`
    
• Unit tests project for testing SuperFizzBuzz Library, command to execute in root `dotnet test Test.SuperFizzBuzz/Test.SuperFizzBuzz.csproj`
    
• Extra Console application "Console.NotSequentialFizzBuzz" even thought this project was not required for this exercise, I added it to see in action how the    application worked when a set of numbers is provided outside of unit testing, command to execute in root `dotnet run --project Console.NotSequentialFizzBuzz/Console.NotSequentialFizzBuzz.csproj`
