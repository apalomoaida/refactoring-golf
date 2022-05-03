namespace Hole3 {
    internal static class TakeHomeCalculatorHelpers {

        private static Money Plus(Money total, Money next) {
            if (!next.currency.Equals(total.currency)) {
                throw new Incalculable();
            }

            total = new Money(total.value + next.value, next.currency);
            return total;
        }
    }
}