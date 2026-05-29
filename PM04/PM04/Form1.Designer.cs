namespace PM04
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
            lblTitle = new Label();
            lblContractorName = new Label();
            txtContractorName = new TextBox();
            lblHoursWorked = new Label();
            txtHoursWorked = new TextBox();
            lblNumberOfDependents = new Label();
            txtNumberOfDependents = new TextBox();
            btnCalculateNetPay = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblGrossPay = new Label();
            lblGrossPayValue = new Label();
            lblUIF = new Label();
            lblUIFValue = new Label();
            lblPAYE = new Label();
            lblPAYEValue = new Label();
            lblMembershipFee = new Label();
            lblMembershipFeeValue = new Label();
            lblTotalDeductions = new Label();
            lblTotalDeductionsValue = new Label();
            lblNetPay = new Label();
            lblNetPayValue = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.DarkBlue;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(250, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mzansi Tech Contractors";
            // 
            // lblContractorName
            // 
            lblContractorName.AutoSize = true;
            lblContractorName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContractorName.Location = new Point(30, 80);
            lblContractorName.Name = "lblContractorName";
            lblContractorName.Size = new Size(123, 20);
            lblContractorName.TabIndex = 1;
            lblContractorName.Text = "Contractor Name";
            // 
            // txtContractorName
            // 
            txtContractorName.Location = new Point(201, 78);
            txtContractorName.Name = "txtContractorName";
            txtContractorName.Size = new Size(150, 27);
            txtContractorName.TabIndex = 2;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoursWorked.Location = new Point(30, 120);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(103, 20);
            lblHoursWorked.TabIndex = 3;
            lblHoursWorked.Text = "Hours Worked";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(201, 118);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(150, 27);
            txtHoursWorked.TabIndex = 4;
            // 
            // lblNumberOfDependents
            // 
            lblNumberOfDependents.AutoSize = true;
            lblNumberOfDependents.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfDependents.Location = new Point(30, 160);
            lblNumberOfDependents.Name = "lblNumberOfDependents";
            lblNumberOfDependents.Size = new Size(165, 20);
            lblNumberOfDependents.TabIndex = 5;
            lblNumberOfDependents.Text = "Number of Dependents";
            // 
            // txtNumberOfDependents
            // 
            txtNumberOfDependents.Location = new Point(201, 158);
            txtNumberOfDependents.Name = "txtNumberOfDependents";
            txtNumberOfDependents.Size = new Size(150, 27);
            txtNumberOfDependents.TabIndex = 6;
            // 
            // btnCalculateNetPay
            // 
            btnCalculateNetPay.BackColor = Color.LightGray;
            btnCalculateNetPay.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateNetPay.Location = new Point(33, 273);
            btnCalculateNetPay.Name = "btnCalculateNetPay";
            btnCalculateNetPay.Size = new Size(120, 35);
            btnCalculateNetPay.TabIndex = 7;
            btnCalculateNetPay.Text = "Calculate Net Pay";
            btnCalculateNetPay.UseVisualStyleBackColor = false;
            btnCalculateNetPay.Click += BtnCalculateNetPay_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightGray;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(163, 273);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 35);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightGray;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(248, 273);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 35);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrossPay.Location = new Point(450, 80);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(74, 20);
            lblGrossPay.TabIndex = 10;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // lblGrossPayValue
            // 
            lblGrossPayValue.AutoSize = true;
            lblGrossPayValue.BorderStyle = BorderStyle.FixedSingle;
            lblGrossPayValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrossPayValue.Location = new Point(573, 80);
            lblGrossPayValue.Name = "lblGrossPayValue";
            lblGrossPayValue.Size = new Size(15, 22);
            lblGrossPayValue.TabIndex = 11;
            lblGrossPayValue.Text = " ";
            // 
            // lblUIF
            // 
            lblUIF.AutoSize = true;
            lblUIF.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUIF.Location = new Point(450, 120);
            lblUIF.Name = "lblUIF";
            lblUIF.Size = new Size(106, 20);
            lblUIF.TabIndex = 12;
            lblUIF.Text = "UIF Deduction:";
            // 
            // lblUIFValue
            // 
            lblUIFValue.AutoSize = true;
            lblUIFValue.BorderStyle = BorderStyle.FixedSingle;
            lblUIFValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUIFValue.Location = new Point(573, 120);
            lblUIFValue.Name = "lblUIFValue";
            lblUIFValue.Size = new Size(15, 22);
            lblUIFValue.TabIndex = 13;
            lblUIFValue.Text = " ";
            // 
            // lblPAYE
            // 
            lblPAYE.AutoSize = true;
            lblPAYE.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPAYE.Location = new Point(450, 160);
            lblPAYE.Name = "lblPAYE";
            lblPAYE.Size = new Size(117, 20);
            lblPAYE.TabIndex = 14;
            lblPAYE.Text = "PAYE Deduction:";
            // 
            // lblPAYEValue
            // 
            lblPAYEValue.AutoSize = true;
            lblPAYEValue.BorderStyle = BorderStyle.FixedSingle;
            lblPAYEValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPAYEValue.Location = new Point(573, 160);
            lblPAYEValue.Name = "lblPAYEValue";
            lblPAYEValue.Size = new Size(15, 22);
            lblPAYEValue.TabIndex = 15;
            lblPAYEValue.Text = " ";
            // 
            // lblMembershipFee
            // 
            lblMembershipFee.AutoSize = true;
            lblMembershipFee.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMembershipFee.Location = new Point(450, 200);
            lblMembershipFee.Name = "lblMembershipFee";
            lblMembershipFee.Size = new Size(122, 20);
            lblMembershipFee.TabIndex = 16;
            lblMembershipFee.Text = "Membership Fee:";
            // 
            // lblMembershipFeeValue
            // 
            lblMembershipFeeValue.AutoSize = true;
            lblMembershipFeeValue.BorderStyle = BorderStyle.FixedSingle;
            lblMembershipFeeValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMembershipFeeValue.Location = new Point(573, 200);
            lblMembershipFeeValue.Name = "lblMembershipFeeValue";
            lblMembershipFeeValue.Size = new Size(15, 22);
            lblMembershipFeeValue.TabIndex = 17;
            lblMembershipFeeValue.Text = " ";
            // 
            // lblTotalDeductions
            // 
            lblTotalDeductions.AutoSize = true;
            lblTotalDeductions.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDeductions.Location = new Point(450, 240);
            lblTotalDeductions.Name = "lblTotalDeductions";
            lblTotalDeductions.Size = new Size(124, 20);
            lblTotalDeductions.TabIndex = 18;
            lblTotalDeductions.Text = "Total Deductions:";
            // 
            // lblTotalDeductionsValue
            // 
            lblTotalDeductionsValue.AutoSize = true;
            lblTotalDeductionsValue.BorderStyle = BorderStyle.FixedSingle;
            lblTotalDeductionsValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDeductionsValue.Location = new Point(573, 240);
            lblTotalDeductionsValue.Name = "lblTotalDeductionsValue";
            lblTotalDeductionsValue.Size = new Size(15, 22);
            lblTotalDeductionsValue.TabIndex = 19;
            lblTotalDeductionsValue.Text = " ";
            // 
            // lblNetPay
            // 
            lblNetPay.AutoSize = true;
            lblNetPay.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPay.Location = new Point(450, 280);
            lblNetPay.Name = "lblNetPay";
            lblNetPay.Size = new Size(68, 20);
            lblNetPay.TabIndex = 20;
            lblNetPay.Text = "Net Pay:";
            // 
            // lblNetPayValue
            // 
            lblNetPayValue.AutoSize = true;
            lblNetPayValue.BorderStyle = BorderStyle.FixedSingle;
            lblNetPayValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPayValue.Location = new Point(573, 280);
            lblNetPayValue.Name = "lblNetPayValue";
            lblNetPayValue.Size = new Size(15, 22);
            lblNetPayValue.TabIndex = 21;
            lblNetPayValue.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNetPayValue);
            Controls.Add(lblNetPay);
            Controls.Add(lblTotalDeductionsValue);
            Controls.Add(lblTotalDeductions);
            Controls.Add(lblMembershipFeeValue);
            Controls.Add(lblMembershipFee);
            Controls.Add(lblPAYEValue);
            Controls.Add(lblPAYE);
            Controls.Add(lblUIFValue);
            Controls.Add(lblUIF);
            Controls.Add(lblGrossPayValue);
            Controls.Add(lblGrossPay);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculateNetPay);
            Controls.Add(txtNumberOfDependents);
            Controls.Add(lblNumberOfDependents);
            Controls.Add(txtHoursWorked);
            Controls.Add(lblHoursWorked);
            Controls.Add(txtContractorName);
            Controls.Add(lblContractorName);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Mzansi Tech Contractors Payroll System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtContractorName;
        private Label lblContractorName;
        private Label lblHoursWorked;
        private TextBox txtHoursWorked;
        private Label lblNumberOfDependents;
        private TextBox txtNumberOfDependents;
        private Button btnCalculateNetPay;
        private Button btnReset;
        private Button btnExit;
        private Label lblGrossPay;
        private Label lblGrossPayValue;
        private Label lblUIF;
        private Label lblUIFValue;
        private Label lblPAYE;
        private Label lblPAYEValue;
        private Label lblMembershipFee;
        private Label lblMembershipFeeValue;
        private Label lblTotalDeductions;
        private Label lblTotalDeductionsValue;
        private Label lblNetPay;
        private Label lblNetPayValue;
    }
}
