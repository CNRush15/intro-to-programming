using Todos.Api.Utils;

namespace Todos.Tests;

public class UnitTest1
{
    [Fact]
    public void CanFormatAName()
    {
        //given
        string firstName = "Bob", lastName = "Smith", fullName;
        var formatter = new Formatters();
        //when
        fullName= formatter.FormatName(firstName, lastName);
        //then
        Assert.Equal("Bob Smith", fullName);
        

    }

    [Theory]
    [InlineData("Bob", "Smith", "Bob Smith")]
    [InlineData("Luke", "Skywalker", "Luke Skywalker")]
    
    public void CanFormatAnyName(string firstName, string lastName, string expecting)
    {
        var formatter = new Formatters();
        var fullName = formatter.FormatName(firstName, lastName);   

        Assert.Equal(expecting, fullName);
    }
}
