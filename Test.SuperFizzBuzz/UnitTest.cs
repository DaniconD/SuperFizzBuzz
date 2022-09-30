using SuperFizzBuzzLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SuperFizzBuzzTest;
[TestClass]
public class UnitTest
{
    // // Snapshots needed to test all cases
    private Dictionary<Int64, String> classicfizzBuzzSnap = new Dictionary<Int64, String> {
        {3,"Fizz"},
        {5,"Buzz"}
    };
    
    private Dictionary<Int64, String> advancedfizzBuzzSnap = new Dictionary<Int64, String> {
        {4, "Frog"},
        {13, "Duck"},
        {9, "Chicken"}
    };

    // *********************************************************
    // Test related to the Classic usage of SuperFizzBuzz
    // *********************************************************
    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf3_ReturnFizz()
    {    
            long[] input = new long[] {-3,-6,9,12,18};
            List<String> expectedOutput = new List<string> { "Fizz", "Fizz", "Fizz", "Fizz", "Fizz" };            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(classicfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf5_ReturnBuzz() {    
            long[] input = new long[] {-10,-5,5,20,50};
            List<String> expectedOutput = new List<string> { "Buzz", "Buzz", "Buzz", "Buzz", "Buzz" };            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(classicfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf3And5_ReturnFizzBuzz() {    
            long[] input = new long[] {-15,30,45,90,-300};
            List<String> expectedOutput = new List<string> { "FizzBuzz", "FizzBuzz", "FizzBuzz", "FizzBuzz", "FizzBuzz" };            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(classicfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    [TestMethod]
    public void SuperFizzBuzz_WhenANumberHasNoMultiple_ReturnNumber() {    
            long[] input = new long[] {-1,2,4,22,-13};
            List<String> expectedOutput = new List<string>();
            foreach( var element in input) {
              expectedOutput.Add(element.ToString());
            }            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(classicfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    // *********************************************************
    // Test related to the Advanced usage of SuperFizzBuzz
    // *********************************************************
    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf4_ReturnFrog()
    {    
            long[] input = new long[] {-4,-16,8,12,20};
            List<String> expectedOutput = new List<string> { "Frog", "Frog", "Frog", "Frog", "Frog" };            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(advancedfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf13_ReturnDuck()
    {    
            long[] input = new long[] {-13,-130,26};
            List<String> expectedOutput = new List<string> { "Duck", "Duck", "Duck"};            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(advancedfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf9_ReturnChicken()
    {    
            long[] input = new long[] {9,90,-18};
            List<String> expectedOutput = new List<string> { "Chicken", "Chicken", "Chicken"};            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(advancedfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf4And13_ReturnFrogDuck() {    
            long[] input = new long[] {52,104, -208};
            List<String> expectedOutput = new List<string> { "FrogDuck", "FrogDuck", "FrogDuck"};            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(advancedfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }

    [TestMethod]
    public void SuperFizzBuzz_WhenANumberIsMultipleOf4And13And9_ReturnFrogDuckChicken() {    
            long[] input = new long[] {468, -936};
            List<String> expectedOutput = new List<string> { "FrogDuckChicken", "FrogDuckChicken"};            

            SuperFizzBuzz superFizzBuzzLibrary = new SuperFizzBuzz(advancedfizzBuzzSnap);
            List<String> output = superFizzBuzzLibrary.GenerateOutput(input);

            Assert.IsTrue(expectedOutput.SequenceEqual(output));
    }
}
