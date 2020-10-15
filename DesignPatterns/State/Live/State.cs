using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Live
{
    internal abstract class State
    {
        protected double interest;
        protected double upperLimit;
        protected double lowerLimit;

        public Account Account { get; set; }
        public double Balance { get; set; }

        public abstract void Withdraw(double amount);

        public abstract void Deposit(double amount);

        public abstract void PayInterest();
    }
}