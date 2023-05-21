namespace Task
{
    //Task 2
    //Create a BankAccount class. The class should have the following private properties:
    //accountNumber,
    //ownerName,
    //balance.

    //Implement a constructor that takes these values as parameters and initializes the properties.
    //The initial balance should be 0.

    //Implement public getters and setters for accountNumber and ownerName, but only a getter for balance(the balance should not be directly settable).
    //Implement two methods: deposit(amount) and withdraw(amount).
    //The deposit(amount) method should add the amount to the balance.
    //The withdraw(amount) method should subtract the amount from the balance, but only if there are sufficient funds in the account.

    class BankAccount
    {
        private long _accountNumber;
        private string _ownerName;
        private double _balance;

        public long AccountNumber
        {
            get => _accountNumber;
            set
            {
                if (!(value < 0))
                {
                    _accountNumber = value;
                }
            }
        }

        public string OwnerName
        {
            get => _ownerName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _ownerName = value;
                }
            }
        }

        public double Balance
        {
            get => _balance;
        }

        public BankAccount(long accountNumber, string ownerName)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = 0;
        }


        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(Balance >= amount)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("There are insufficient funds in the account!");
            }
        }

    }
}