using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampFundamentalWeek1Projects
{
    abstract class ElectricBill
    {
        string name = "";
        double unitConsumed, unitPrice = 0, taxPrice = 0;
        int taxRate;

        public ElectricBill()
        {
            unitConsumed = 0;
            taxRate = 0;
            unitPrice = 0;
            taxPrice = 0;
        }
        public ElectricBill(string n, float uc, int tr)
        {
            this.name = n;
            this.unitConsumed = uc;
            this.taxRate = tr;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double UnitConsumed
        {
            get { return this.unitConsumed; }
            set { this.unitConsumed = value; }
        }
        public int TaxRate
        {
            get { return this.taxRate; }
            set { this.taxRate = value; }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }
        public double TaxPrice
        {
            get { return this.taxPrice; }
            set { this.taxPrice = value; }
        }
        
        public abstract double calculateBillForLessThan100Units();
        public abstract double calculateBillBetween100To200Units();
        public abstract double calculateBillBetween200To500Units();
        public abstract double calculateBillGreaterThen500Units();
        public abstract double calculateBillTax();
        public abstract double calculateFinalBill();
    }
}
