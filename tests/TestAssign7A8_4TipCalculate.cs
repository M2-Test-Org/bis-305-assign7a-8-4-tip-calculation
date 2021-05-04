using Xunit;
using System.IO;
using System;
using System.Text;

public class TestAssign7A8_4TipCalculate
{

    [Fact]
    public void TestCase()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);
        
        TipCalculation.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.AppendLine("Meal price: $30.00. Tip percent: 0.20");
        expectedOutcome.AppendLine("Tip in dollars: $6.00.  Total bill $36.00");
        expectedOutcome.AppendLine("Meal price: $30.00. Tip percent: 0.17");
        expectedOutcome.AppendLine("Tip in dollars: $5.00.  Total bill $35.00");

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
    }
}
