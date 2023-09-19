namespace LoanCalculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtMortgage_Click(object sender, EventArgs e)
        {
            //Create some local variables
            double LoanAmount = 0.0;
            double DownPayment = 0.0;
            double InterestRate = 0.0;
            double MonthlyPayment = 0.0;
            int Terms = 0;

            //Do some validation
            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                LoanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                DownPayment = Convert.ToDouble(txtDownPayment.Text);
            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                InterestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTermsinYears.Text))
                Terms = Convert.ToInt32(txtTermsinYears.Text);

            //Mortgage Payment calculation logic
            //Formula: Payment = (Loan Amount - Down Payment)* (1 + Interest Rate / 12)^(Terms * 12)
            int TermsinMonths = Terms * 12;
            MonthlyPayment = (LoanAmount - DownPayment) * (Math.Pow((1 + InterestRate / 12), TermsinMonths) * InterestRate) / (12 * (Math.Pow((1 + InterestRate / 12), TermsinMonths) - 1));

            MonthlyPayment = Math.Round(MonthlyPayment, 2);

            //Display the result
            lblMonthlyPayments.Text = String.Format("Monthly Payment: R {0}", MonthlyPayment.ToString());






        }

        private void txtAuto_Click(object sender, EventArgs e)
        {
            double LoanAmount = 0.0;
            double DownPayment = 0.0;
            double InterestRate = 0.0;
            double MonthlyPayment = 0.0;
            int Terms = 0;

            //Do some validation
            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                LoanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                DownPayment = Convert.ToDouble(txtDownPayment.Text);
            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                InterestRate = Convert.ToDouble(txtInterestRate.Text);
            if (!String.IsNullOrEmpty(txtTermsinYears.Text))
                Terms = Convert.ToInt32(txtTermsinYears.Text);

            //Mortgage Payment calculation logic
            //Formula: Payment = (Loan Amount - Down Payment)* (1 + Interest Rate / 12)^(Terms * 12)
            int TermsinMonths = Terms * 12;
            InterestRate /= 12;
            //display results
            MonthlyPayment = (InterestRate * LoanAmount) / (1 - Math.Pow(1 + InterestRate, TermsinMonths * -1));
            MonthlyPayment = Math.Round(MonthlyPayment, 2);

            //display results
            lblMonthlyPayments.Text = String.Format("Monthly payment: R {0}", MonthlyPayment.ToString());
        }
    }
}