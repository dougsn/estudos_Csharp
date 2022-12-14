using ContaBancaria_Exception.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria_Exception.Entities {
    internal class Account {

        public int Number { get; set; }
        public string holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            this.holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if (amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(amount > Balance) {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;

        }


    }
}
