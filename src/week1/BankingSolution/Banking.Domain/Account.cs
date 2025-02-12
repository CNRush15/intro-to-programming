namespace Banking.Domain
{
    public class Account
    {
        private decimal _openingBalance = 5000;

        public void Deposit(decimal amountToDeposit)
        {
            _openingBalance += amountToDeposit;
        }

        public decimal GetBalance()
        {
            return _openingBalance;
        }
    }
}