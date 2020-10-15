namespace State.Live
{
    internal class SilverState : State
    {
        public SilverState(State state) : this(state.Account, state.Balance)
        {
        }

        public SilverState(Account account, double balance)
        {
            this.Account = account;
            this.Balance = balance;
            Init();
        }

        public void Init()
        {
            interest = 0;
            lowerLimit = 0;
            upperLimit = 1000;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += Balance * interest;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        public void StateChangeCheck()
        {
            if (Balance < lowerLimit)
                Account.State = new RedState(this);
            else if (Balance > upperLimit)
                Account.State = new GoldenState(this);
        }
    }
}