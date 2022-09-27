﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo.Entities {
    internal class Account {
        public int Number { get; private set; } // O private no setter é para encapsular a sua mudança.
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) {
            Balance -= amount + 5;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}

