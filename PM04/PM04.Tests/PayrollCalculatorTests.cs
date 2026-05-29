namespace PM04.Tests
{
    [TestClass]
    [TestCategory("PayrollCalculator")]
    public class PayrollCalculatorTests
    {
        private PayrollCalculator _calculator = null!;
        public TestContext? TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            _calculator = new PayrollCalculator();
            TestContext?.WriteLine("Test initialized - PayrollCalculator instance created");
            TestContext?.WriteLine($"Test started at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }

        #region Gross Pay Tests

        [TestMethod]
        [TestCategory("GrossPay")]
        public void CalculateGrossPay_With10Hours_Returns9500()
        {
            // Arrange
            decimal hours = 10;
            decimal expected = 9500;

            // Act
            decimal result = _calculator.CalculateGrossPay(hours);

            // Assert
            Assert.AreEqual(expected, result, "Gross Pay calculation failed for 10 hours");
            TestContext?.WriteLine($"Test passed: 10 hours × R950 = R{result}");
        }

        #endregion

        #region UIF Tests

        [TestMethod]
        [TestCategory("UIF")]
        public void CalculateUIF_With9500GrossPay_Returns95()
        {
            // Arrange
            decimal grossPay = 9500;
            decimal expected = 95;

            // Act
            decimal result = _calculator.CalculateUIF(grossPay);

            // Assert
            Assert.AreEqual(expected, result, "UIF calculation failed");
            TestContext?.WriteLine($"UIF for R{grossPay}: R{result}");
        }

        #endregion

        #region Membership Tests

        [TestMethod]
        [TestCategory("Membership")]
        public void CalculateMembershipFee_With9500GrossPay_Returns1235()
        {
            // Arrange
            decimal grossPay = 9500;
            decimal expected = 1235;

            // Act
            decimal result = _calculator.CalculateMembershipFee(grossPay);

            // Assert
            Assert.AreEqual(expected, result, "Membership Fee calculation failed");
            TestContext?.WriteLine($"Membership Fee for R{grossPay}: R{result}");
        }

        #endregion

        #region PAYE Tests

        [TestMethod]
        [TestCategory("PAYE")]
        public void CalculatePAYE_With9500GrossPayAndZeroDependents_Returns2375()
        {
            // Arrange
            decimal grossPay = 9500;
            int dependents = 0;
            decimal expected = 2375;

            // Act
            decimal result = _calculator.CalculatePAYE(grossPay, dependents);

            // Assert
            Assert.AreEqual(expected, result, "PAYE calculation failed");
            TestContext?.WriteLine($"PAYE for R{grossPay} with {dependents} dependents: R{result}");
        }

        #endregion

        #region Net Pay Tests

        [TestMethod]
        [TestCategory("NetPay")]
        public void CalculateNetPay_WithGrossPayAndTotalDeductions_ReturnsCorrectNetPay()
        {
            // Arrange
            decimal grossPay = 9500;
            decimal totalDeductions = 3705;
            decimal expected = 5795;

            // Act
            decimal result = _calculator.CalculateNetPay(grossPay, totalDeductions);

            // Assert
            Assert.AreEqual(expected, result, "Net Pay calculation failed");
            TestContext?.WriteLine($"Net Pay: R{grossPay} - R{totalDeductions} = R{result}");
        }

        #endregion

        #region Integration Tests

        [TestMethod]
        [TestCategory("Integration")]
        public void FullPayrollCalculation_With10HoursAndZeroDependents()
        {
            // Arrange
            decimal hours = 10;
            int dependents = 0;

            // Act
            decimal grossPay = _calculator.CalculateGrossPay(hours);
            decimal uif = _calculator.CalculateUIF(grossPay);
            decimal paye = _calculator.CalculatePAYE(grossPay, dependents);
            decimal membership = _calculator.CalculateMembershipFee(grossPay);
            decimal totalDeductions = uif + paye + membership;
            decimal netPay = _calculator.CalculateNetPay(grossPay, totalDeductions);

            // Assert
            Assert.AreEqual(9500, grossPay);
            Assert.AreEqual(95, uif);
            Assert.AreEqual(2375, paye);
            Assert.AreEqual(1235, membership);
            Assert.AreEqual(3705, totalDeductions);
            Assert.AreEqual(5795, netPay);

            TestContext?.WriteLine($"Gross Pay: R{grossPay}, UIF: R{uif}, Membership: R{membership}, PAYE: R{paye}, Total Deductions: R{totalDeductions}, Net Pay: R{netPay}");
        }

        #endregion
    }
}
