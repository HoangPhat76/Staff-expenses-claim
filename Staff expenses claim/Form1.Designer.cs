namespace Staff_expenses_claim
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
            staffexpensetitle = new Label();
            lblStaffName = new Label();
            lblExpenseDate = new Label();
            lblExpenseCategory = new Label();
            lblKilometres = new Label();
            lblAmount = new Label();
            lblEstimatedAmounttitle = new Label();
            gbEstimatedResults = new GroupBox();
            lblAdjustmentMessage = new Label();
            lblEstimate = new Label();
            lblAdjustmentMessagetitle = new Label();
            txtStaffName = new TextBox();
            dtpExpenseDate = new DateTimePicker();
            numKilometres = new NumericUpDown();
            numAmount = new NumericUpDown();
            cboExpenseCategory = new ComboBox();
            btnCal = new Button();
            btnClear = new Button();
            lblPurpose = new Label();
            txtDescription = new RichTextBox();
            lblKmamount = new Label();
            lblMaxInfo = new Label();
            gbEstimatedResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // staffexpensetitle
            // 
            staffexpensetitle.AutoSize = true;
            staffexpensetitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffexpensetitle.Location = new Point(12, 9);
            staffexpensetitle.Name = "staffexpensetitle";
            staffexpensetitle.Size = new Size(353, 32);
            staffexpensetitle.TabIndex = 0;
            staffexpensetitle.Text = "Staff Expense Claim Estimator";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(12, 65);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(66, 15);
            lblStaffName.TabIndex = 1;
            lblStaffName.Text = "Staff Name";
            // 
            // lblExpenseDate
            // 
            lblExpenseDate.AutoSize = true;
            lblExpenseDate.Location = new Point(12, 98);
            lblExpenseDate.Name = "lblExpenseDate";
            lblExpenseDate.Size = new Size(76, 15);
            lblExpenseDate.TabIndex = 2;
            lblExpenseDate.Text = "Expense Date";
            // 
            // lblExpenseCategory
            // 
            lblExpenseCategory.AutoSize = true;
            lblExpenseCategory.Location = new Point(12, 134);
            lblExpenseCategory.Name = "lblExpenseCategory";
            lblExpenseCategory.Size = new Size(100, 15);
            lblExpenseCategory.TabIndex = 3;
            lblExpenseCategory.Text = "Expense Category";
            // 
            // lblKilometres
            // 
            lblKilometres.AutoSize = true;
            lblKilometres.Location = new Point(12, 185);
            lblKilometres.Name = "lblKilometres";
            lblKilometres.Size = new Size(58, 15);
            lblKilometres.TabIndex = 4;
            lblKilometres.Text = "Kilometer";
            lblKilometres.Click += label2_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(12, 216);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(94, 15);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Expense amount";
            // 
            // lblEstimatedAmounttitle
            // 
            lblEstimatedAmounttitle.AutoSize = true;
            lblEstimatedAmounttitle.Location = new Point(31, 29);
            lblEstimatedAmounttitle.Name = "lblEstimatedAmounttitle";
            lblEstimatedAmounttitle.Size = new Size(111, 15);
            lblEstimatedAmounttitle.TabIndex = 6;
            lblEstimatedAmounttitle.Text = "Estimated amount:";
            // 
            // gbEstimatedResults
            // 
            gbEstimatedResults.Controls.Add(lblAdjustmentMessage);
            gbEstimatedResults.Controls.Add(lblEstimate);
            gbEstimatedResults.Controls.Add(lblAdjustmentMessagetitle);
            gbEstimatedResults.Controls.Add(lblEstimatedAmounttitle);
            gbEstimatedResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbEstimatedResults.Location = new Point(12, 384);
            gbEstimatedResults.Name = "gbEstimatedResults";
            gbEstimatedResults.Size = new Size(535, 100);
            gbEstimatedResults.TabIndex = 7;
            gbEstimatedResults.TabStop = false;
            gbEstimatedResults.Text = "Estimated Results";
            // 
            // lblAdjustmentMessage
            // 
            lblAdjustmentMessage.AutoSize = true;
            lblAdjustmentMessage.Location = new Point(179, 63);
            lblAdjustmentMessage.Name = "lblAdjustmentMessage";
            lblAdjustmentMessage.Size = new Size(22, 15);
            lblAdjustmentMessage.TabIndex = 20;
            lblAdjustmentMessage.Text = "---";
            // 
            // lblEstimate
            // 
            lblEstimate.AutoSize = true;
            lblEstimate.Location = new Point(179, 29);
            lblEstimate.Name = "lblEstimate";
            lblEstimate.Size = new Size(38, 15);
            lblEstimate.TabIndex = 19;
            lblEstimate.Text = "$0.00";
            // 
            // lblAdjustmentMessagetitle
            // 
            lblAdjustmentMessagetitle.AutoSize = true;
            lblAdjustmentMessagetitle.Location = new Point(31, 63);
            lblAdjustmentMessagetitle.Name = "lblAdjustmentMessagetitle";
            lblAdjustmentMessagetitle.Size = new Size(126, 15);
            lblAdjustmentMessagetitle.TabIndex = 17;
            lblAdjustmentMessagetitle.Text = "Adjustment Message:";
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(148, 57);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(217, 23);
            txtStaffName.TabIndex = 8;
            // 
            // dtpExpenseDate
            // 
            dtpExpenseDate.Location = new Point(148, 92);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(217, 23);
            dtpExpenseDate.TabIndex = 9;
            dtpExpenseDate.Value = new DateTime(2026, 10, 5, 0, 0, 0, 0);
            // 
            // numKilometres
            // 
            numKilometres.Location = new Point(148, 177);
            numKilometres.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numKilometres.Name = "numKilometres";
            numKilometres.Size = new Size(120, 23);
            numKilometres.TabIndex = 10;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(148, 216);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 23);
            numAmount.TabIndex = 11;
            // 
            // cboExpenseCategory
            // 
            cboExpenseCategory.FormattingEnabled = true;
            cboExpenseCategory.Items.AddRange(new object[] { "Mileage", "Meal", "Parking" });
            cboExpenseCategory.Location = new Point(147, 126);
            cboExpenseCategory.Name = "cboExpenseCategory";
            cboExpenseCategory.Size = new Size(218, 23);
            cboExpenseCategory.TabIndex = 12;
            cboExpenseCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(148, 355);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(124, 23);
            btnCal.TabIndex = 13;
            btnCal.Text = "Calculate Estimate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(290, 355);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Location = new Point(12, 255);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(50, 15);
            lblPurpose.TabIndex = 15;
            lblPurpose.Text = "Purpose";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(148, 255);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(399, 94);
            txtDescription.TabIndex = 16;
            txtDescription.Text = "";
            // 
            // lblKmamount
            // 
            lblKmamount.AutoSize = true;
            lblKmamount.Location = new Point(290, 179);
            lblKmamount.Name = "lblKmamount";
            lblKmamount.Size = new Size(74, 15);
            lblKmamount.TabIndex = 17;
            lblKmamount.Text = "$0.85 per km";
            // 
            // lblMaxInfo
            // 
            lblMaxInfo.AutoSize = true;
            lblMaxInfo.Location = new Point(290, 218);
            lblMaxInfo.Name = "lblMaxInfo";
            lblMaxInfo.Size = new Size(246, 15);
            lblMaxInfo.TabIndex = 18;
            lblMaxInfo.Text = "Maximum allowed: $35 (Meal) / $40 (Parking)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 496);
            Controls.Add(lblMaxInfo);
            Controls.Add(lblKmamount);
            Controls.Add(txtDescription);
            Controls.Add(lblPurpose);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
            Controls.Add(cboExpenseCategory);
            Controls.Add(numAmount);
            Controls.Add(numKilometres);
            Controls.Add(dtpExpenseDate);
            Controls.Add(txtStaffName);
            Controls.Add(gbEstimatedResults);
            Controls.Add(lblAmount);
            Controls.Add(lblKilometres);
            Controls.Add(lblExpenseCategory);
            Controls.Add(lblExpenseDate);
            Controls.Add(lblStaffName);
            Controls.Add(staffexpensetitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Staff Expense Claim Estimator window";
            gbEstimatedResults.ResumeLayout(false);
            gbEstimatedResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometres).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label staffexpensetitle;
        private Label lblStaffName;
        private Label lblExpenseDate;
        private Label lblExpenseCategory;
        private Label lblKilometres;
        private Label lblAmount;
        private Label lblEstimatedAmounttitle;
        private GroupBox gbEstimatedResults;
        private TextBox txtStaffName;
        private DateTimePicker dtpExpenseDate;
        private NumericUpDown numKilometres;
        private NumericUpDown numAmount;
        private ComboBox cboExpenseCategory;
        private Button btnCal;
        private Button btnClear;
        private Label lblPurpose;
        private RichTextBox txtDescription;
        private Label lblAdjustmentMessagetitle;
        private Label lblKmamount;
        private Label lblMaxInfo;
        private Label lblAdjustmentMessage;
        private Label lblEstimate;
    }
}
