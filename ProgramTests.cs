using Xunit;
using System.IO;
using System;

public class ProgramTests
{
    [Fact]
    public void TestGreeting()
    {
        using (var sw = new StringWriter())
        using (var sr = new StringReader("Alice\n"))
        {
            Console.SetOut(sw);
            Console.SetIn(sr);
            
            Program.Main();
            var result = sw.ToString().Trim().Split('\n');
            Assert.Equal("Hello, Alice!", result[^1].Trim());
        }
    }
}