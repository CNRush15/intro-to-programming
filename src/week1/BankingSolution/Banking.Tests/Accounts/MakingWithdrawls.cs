
using Banking.Domain;

namespace Banking.Tests.Accounts;
public class MakingWithdrawals
{

    [Theory]
    [InlineData(42.23)]
    [InlineData(3.23)]
    public void MakingWithdrawalsDecreasesTheBalance(decimal amountToWithdraw)
    {
        var account = new Account();
        var openingBalance = account.GetBalance();


        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());
    }
  
    [Fact]

    public void CannotMakeWithdrawalWithNegativeNumbers()

    {
        var account = new Account();

        Assert.Throws<AccountNegativeTransactionAmountException>(() => account.Withdraw(-3));
    }


    [Fact]
    public void CanWithdrawFullBalance()
    {
        var account = new Account();

        account.Withdraw(account.GetBalance()); 
        Assert.Equal(0, account.GetBalance());  
    }

    [Fact]
    public void WhenOverdraftBalanceIsNotReducedNotAllowed()
    {

        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountThatRepresentsMorethanOpeningBalance = openingBalance + .01M;

        try
        {
        account.Withdraw(amountThatRepresentsMorethanOpeningBalance);

        }
        catch (AccountTransactionException)
        {

        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void WhenOverDraftmethodThrows()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountThatRepresentsMorethanOpeningBalance = openingBalance + .01M;

   

        Assert.Throws<AccountOverdraftException>(() => account.Withdraw(amountThatRepresentsMorethanOpeningBalance));
    }
}