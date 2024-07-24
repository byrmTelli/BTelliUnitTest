using System.Text.RegularExpressions;

namespace BTelliUnitTest.APP;

public class CalculatorTest
{
    [Fact]
    public void TestAdd()
    {
        // //Arrange --- we are defining variables here.
        // int a = 5;
        // int b = 15;

        // var calculator = new Calculator();

        // var regeX = "^love";

        // //Act --- Initializing method which we are going to test here.

        // var result = calculator.Add(a, b);

        // //Assert --- Running the method

        // Assert.Equal<int>(20,result);


        //---------True-False

        // Assert.True(3<5);
        // Assert.False(3>5);

        //----------Regex Comparision

        // Assert.Matches(regeX, "loveforever");
        // Assert.Matches(regeX, "l0veforever");
        // Assert.DoesNotMatch(regeX, "l8veforever");

        //------ Start-End With

        // Assert.StartsWith("once","once upon a timem");
        // Assert.EndsWith("time", "once upon a timee");

        // Assert.InRange(2, 1, 5);



        // Assert.Single(new List<string>(){"bayram","eren"});

    }
    
    [Theory]
    [InlineData(2,5,7)]
    [InlineData(4,5,9)]
    public void TestAdd2(int a, int b, int expectedData)
    {
        var calculator = new Calculator();

        var result = calculator.Add(a, b);

        Assert.Equal(result, expectedData); 
    }
}