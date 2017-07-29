using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    public class Purchase
    {
        private int number;
        private double amount;
        private string purpose;

        //Constructor
        public Purchase(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }
        //Properties
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
