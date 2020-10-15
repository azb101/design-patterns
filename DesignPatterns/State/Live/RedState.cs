using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Live
{
    internal class RedState : State
    {
        private double _serviceFee;

        public RedState(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;

            Init();
        }

        private void Init()
        {
            this.interest = 0;
            this.lowerLimit = -100;
            this.upperLimit = 0.0;
            _serviceFee = 15.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangedCheck();
        }

        public override void PayInterest()
        {
            // no interest is payed
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
        }

        public void StateChangedCheck()
        {
            if (Balance > upperLimit)
            {
                this.Account.State = new SilverState(this);
            }
        }
    }
}