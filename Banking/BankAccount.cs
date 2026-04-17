public class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get
        {
            return _balance;
        }
    }
    public BankAccount(decimal initialBalance)
    {
        _balance = initialBalance;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Error: Invalid amount.");
            return;
        }
        if (amount > _balance)
        {
            Console.WriteLine("Error: Insufficient funds.");
            return;
        }
        else
        {
            _balance -= amount;
            Console.WriteLine("Withdrawal successful.");
            if (_balance < 500)
            {
                Console.WriteLine("Warning: Low balance!");
            }
        }


    }
}
