namespace LoanCalculators
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtLoanAmount = new TextBox();
            label2 = new Label();
            txtDownPayment = new TextBox();
            label3 = new Label();
            txtInterestRate = new TextBox();
            txtTerms = new Label();
            txtTermsinYears = new TextBox();
            txtMortgage = new Button();
            txtAuto = new Button();
            lblMonthlyPayments = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 31);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(400, 31);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(150, 31);
            txtLoanAmount.TabIndex = 1;
            txtLoanAmount.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 115);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Down Payment";
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(400, 115);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(150, 31);
            txtDownPayment.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 174);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 4;
            label3.Text = "Interest Rate";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(400, 174);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(150, 31);
            txtInterestRate.TabIndex = 5;
            txtInterestRate.TextChanged += textBox1_TextChanged_1;
            // 
            // txtTerms
            // 
            txtTerms.AutoSize = true;
            txtTerms.Location = new Point(99, 235);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(122, 25);
            txtTerms.TabIndex = 6;
            txtTerms.Text = "Terms in Years";
            // 
            // txtTermsinYears
            // 
            txtTermsinYears.Location = new Point(400, 235);
            txtTermsinYears.Name = "txtTermsinYears";
            txtTermsinYears.Size = new Size(150, 31);
            txtTermsinYears.TabIndex = 7;
            // 
            // txtMortgage
            // 
            txtMortgage.Location = new Point(353, 294);
            txtMortgage.Name = "txtMortgage";
            txtMortgage.Size = new Size(112, 34);
            txtMortgage.TabIndex = 8;
            txtMortgage.Text = "Mortgage";
            txtMortgage.UseVisualStyleBackColor = true;
            txtMortgage.Click += txtMortgage_Click;
            // 
            // txtAuto
            // 
            txtAuto.Location = new Point(520, 294);
            txtAuto.Name = "txtAuto";
            txtAuto.Size = new Size(112, 34);
            txtAuto.TabIndex = 9;
            txtAuto.Text = "Auto";
            txtAuto.UseVisualStyleBackColor = true;
            txtAuto.Click += txtAuto_Click;
            // 
            // lblMonthlyPayments
            // 
            lblMonthlyPayments.AutoSize = true;
            lblMonthlyPayments.Location = new Point(108, 332);
            lblMonthlyPayments.Name = "lblMonthlyPayments";
            lblMonthlyPayments.Size = new Size(173, 25);
            lblMonthlyPayments.TabIndex = 10;
            lblMonthlyPayments.Text = "MonthlyPayments: $";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(lblMonthlyPayments);
            Controls.Add(txtAuto);
            Controls.Add(txtMortgage);
            Controls.Add(txtTermsinYears);
            Controls.Add(txtTerms);
            Controls.Add(txtInterestRate);
            Controls.Add(label3);
            Controls.Add(txtDownPayment);
            Controls.Add(label2);
            Controls.Add(txtLoanAmount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Loan Calculators";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLoanAmount;
        private Label label2;
        private TextBox txtDownPayment;
        private Label label3;
        private TextBox txtInterestRate;
        private Label txtTerms;
        private TextBox txtTermsinYears;
        private Button txtMortgage;
        private Button txtAuto;
        private Label lblMonthlyPayments;
    }
}