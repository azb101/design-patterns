using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Live
{
    internal class GoldenState : State
    {
        public GoldenState(State state) : this(state.Account, state.Balance)
        {
        }

        public GoldenState(Account account, double balance)
        {
            Account = account;
            Balance = balance;
            Init();
        }

        private void Init()
        {
            interest = 0.05;
            lowerLimit = 1000;
            upperLimit = 1000000;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            CheckStateChange();
        }

        public override void PayInterest()
        {
            Balance += Balance * interest;
            CheckStateChange();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            CheckStateChange();
        }

        private void CheckStateChange()
        {
            if (Balance < 0.0)
            {
                Account.State = new RedState(this);
            }
            else if (Balance < lowerLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}