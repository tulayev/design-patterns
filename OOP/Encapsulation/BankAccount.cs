namespace OOP.Encapsulation
{
    internal class BankAccount
    {
        private decimal _balance; // hidden

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }

            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            _balance -= amount;
        }

        public decimal GetBalance()
        {
            return _balance;  // read-only access
        }
    }
}
