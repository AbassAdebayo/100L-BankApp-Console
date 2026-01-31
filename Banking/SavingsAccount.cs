public class SavingsAccount : BankAccount
{
    private const decimal WithdrawalFee = 20m;

    public SavingsAccount(decimal initialBalance) : base(initialBalance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        decimal totalAmount = amount + WithdrawalFee;

        if (totalAmount > Balance)
        {
            Console.WriteLine("Error: Insufficient funds.");
            return;
        }
        base.Withdraw(totalAmount);
    }
}