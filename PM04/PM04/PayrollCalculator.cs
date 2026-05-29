namespace PM04
{
    public class PayrollCalculator
    {
        private const decimal HOURLY_RATE = 950.00m;
        private const decimal UIF_RATE = 0.01m;
        private const decimal PAYE_RATE = 0.25m;
        private const decimal DEPENDENT_DEDUCTION_RATE = 0.0575m;
        private const decimal MEMBERSHIP_RATE = 0.13m;

        public decimal CalculateGrossPay(decimal hoursWorked)
        {
            return hoursWorked * HOURLY_RATE;
        }

        public decimal CalculateUIF(decimal grossPay)
        {
            return grossPay * UIF_RATE;
        }

        public decimal CalculatePAYE(decimal grossPay, int dependents)
        {
            decimal taxableAmount = grossPay - (grossPay * DEPENDENT_DEDUCTION_RATE * dependents);
            return taxableAmount * PAYE_RATE;
        }

        public decimal CalculateMembershipFee(decimal grossPay)
        {
            return grossPay * MEMBERSHIP_RATE;
        }

        public decimal CalculateNetPay(decimal grossPay, decimal totalDeductions)
        {
            return grossPay - totalDeductions;
        }
    }
}
