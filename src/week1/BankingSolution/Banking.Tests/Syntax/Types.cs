


namespace Banking.Tests.Syntax;

public class Types
{
    string Name = "Bob";

    [Fact]
    public void DeclaringVariables()
    {
        var age = 55;


        int dogAge;




        var yourAge = 16.5;

        var myHourlyPay = 18.23M; 


        Assert.Equal("Bob", Name);


        Assert.Equal(55, age);

    }

    [Fact]
    public void AnotherThing()
    {
        Assert.Equal("Bob", this.Name);
    }
}