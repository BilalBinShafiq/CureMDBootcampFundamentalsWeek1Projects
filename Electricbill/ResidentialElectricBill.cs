using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampFundamentalWeek1Projects
{
    class ResidentialElectricBill : ElectricBill
    {
        public ResidentialElectricBill(string n, float uc, int tr)
        {
            this.Name = n;
            this.UnitConsumed = uc;
            this.TaxRate = tr;
        }
        public override double calculateBillForLessThan100Units()
        {
            this.UnitPrice = this.UnitConsumed * 5;
            return this.UnitPrice;
        }
        public override double calculateBillBetween100To200Units()
        {
            this.UnitPrice = 100 * 5;
            this.UnitPrice = this.UnitPrice + ((this.UnitConsumed - 100) * 17);
            return this.UnitPrice;
        }
        public override double calculateBillBetween200To500Units()
        {
            this.UnitPrice = 100 * 5;
            this.UnitPrice = this.UnitPrice + (100 * 17);
            this.UnitPrice = this.UnitPrice + ((this.UnitConsumed - 200) * 23);
            return this.UnitPrice;
        }
        public override double calculateBillGreaterThen500Units()
        {
            this.UnitPrice = 100 * 5;
            this.UnitPrice = this.UnitPrice + (100 * 17);
            this.UnitPrice = this.UnitPrice + (300 * 23);
            this.UnitPrice = this.UnitPrice + ((this.UnitConsumed - 500) * 69);
            return this.UnitPrice;
        }
        public override double calculateBillTax()
        {
            this.TaxPrice = this.UnitPrice * (Convert.ToDouble(this.TaxRate) / 100);
            return this.TaxPrice;
        }
        public override double calculateFinalBill()
        {
            if (this.UnitConsumed < 101)
            {
                this.calculateBillForLessThan100Units();
            }
            else if (this.UnitConsumed > 100 && this.UnitConsumed < 201)
            {
                this.calculateBillBetween100To200Units();
            }
            else if (this.UnitConsumed > 200 && this.UnitConsumed < 501)
            {
                this.calculateBillBetween200To500Units();
            }
            else
            {
                this.calculateBillGreaterThen500Units();
            }
            this.calculateBillTax();
            return this.UnitPrice + this.TaxPrice;
        }
    }
}
