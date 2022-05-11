using System;

namespace Hole5 {
    public class TaxRate {
        private readonly int percent;

        private TaxRate(int taxRate) {
            this.percent = taxRate;
        }
        
        public static TaxRate Of(int percent) {
            return new TaxRate(percent);
        }
        
        public Money Apply(Money first, Money total) {
            Double amount = total.value * (percent / 100d);
            return Money.Create(Convert.ToInt32(amount), first.currency);
        }
    }
}
