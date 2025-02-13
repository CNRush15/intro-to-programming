

using Banking.Domain;

namespace Banking.Tests.Accounts;
public class NewAccounts
{
    [Fact]
    public void BalanceIsCorrect()
    {
        var correctOpeningBalance = 5000M;
        var myAccount = new Account();
        var yourAccount = new Account();

        var myBalance = myAccount.GetBalance();
        decimal yourBalance = yourAccount.GetBalance();

        Assert.Equal(correctOpeningBalance, myBalance);
        Assert.Equal(correctOpeningBalance, yourBalance);


    }
}