﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    //状态模式
    //适用性：
    //1.一个对象的行为取决于它的状态，并且它必须在运行时刻根据状态改变它的行为。
    //2.一个操作中含有庞大的多分支的等条件语句，且这些分支依赖于该对象的状态。这个状态通常用一个或多个枚举常量表示。通常，有多个操作包含这一相同的条件结构。State模式将每一个分支放入一个独立的类中。这使得你可根据对象自身的情况将对象的状态作为一个对象，这一对象可以不依赖于其他对象而独立变化。
    public class StatePatternDemo
    {
        public void Test()
        {
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            // Wait for user
            Console.Read();
        }
    }
}
