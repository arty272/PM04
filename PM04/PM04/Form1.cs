namespace PM04
{
    public partial class Form1 : Form
    {
        private readonly PayrollCalculator _calculator = new PayrollCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculateNetPay_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            decimal hoursWorked = decimal.Parse(txtHoursWorked.Text);
            int dependents = int.Parse(txtNumberOfDependents.Text);

            decimal grossPay = _calculator.CalculateGrossPay(hoursWorked);
            decimal uifDeduction = _calculator.CalculateUIF(grossPay);
            decimal payeDeduction = _calculator.CalculatePAYE(grossPay, dependents);
            decimal membershipFee = _calculator.CalculateMembershipFee(grossPay);
            decimal totalDeductions = uifDeduction + payeDeduction + membershipFee;
            decimal netPay = _calculator.CalculateNetPay(grossPay, totalDeductions);

            DisplayResults(grossPay, uifDeduction, payeDeduction, membershipFee, totalDeductions, netPay);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtContractorName.Text))
            {
                MessageBox.Show("Please enter the contractor name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtHoursWorked.Text, out decimal hoursWorked) || hoursWorked < 0)
            {
                MessageBox.Show("Please enter a valid number of hours worked (non-negative).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtNumberOfDependents.Text, out int dependents) || dependents < 0)
            {
                MessageBox.Show("Please enter a valid number of dependents (non-negative).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dependents > 10)
            {
                MessageBox.Show("Number of dependents cannot exceed 10.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void DisplayResults(decimal grossPay, decimal uifDeduction, decimal payeDeduction, decimal membershipFee, decimal totalDeductions, decimal netPay)
        {
            lblGrossPayValue.Text = "R " + grossPay.ToString("F2");
            lblUIFValue.Text = "R " + uifDeduction.ToString("F2");
            lblPAYEValue.Text = "R " + payeDeduction.ToString("F2");
            lblMembershipFeeValue.Text = "R " + membershipFee.ToString("F2");
            lblTotalDeductionsValue.Text = "R " + totalDeductions.ToString("F2");
            lblNetPayValue.Text = "R " + netPay.ToString("F2");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtContractorName.Clear();
            txtHoursWorked.Clear();
            txtNumberOfDependents.Clear();
            lblGrossPayValue.Text = " ";
            lblUIFValue.Text = " ";
            lblPAYEValue.Text = " ";
            lblMembershipFeeValue.Text = " ";
            lblTotalDeductionsValue.Text = " ";
            lblNetPayValue.Text = " ";
            txtContractorName.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
