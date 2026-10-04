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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            lblAdjustmentMessage = new Label();
            lblEstimate = new Label();
            label6 = new Label();
            txtStaffName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numKilometres = new NumericUpDown();
            numAmount = new NumericUpDown();
            cboCategory = new ComboBox();
            btnCal = new Button();
            btnClear = new Button();
            label5 = new Label();
            txtDescription = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 3;
            label1.Text = "Expense Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Kilometer";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 5;
            label3.Text = "Expanse amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 29);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "Estimated amount:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAdjustmentMessage);
            groupBox1.Controls.Add(lblEstimate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 384);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estimated Results";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 63);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 17;
            label6.Text = "Adjustment Message:";
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(148, 57);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(217, 23);
            txtStaffName.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 9;
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
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Mileage", "Meal", "Parking" });
            cboCategory.Location = new Point(147, 126);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(218, 23);
            cboCategory.TabIndex = 12;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 255);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 15;
            label5.Text = "Purpose";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(148, 255);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(399, 94);
            txtDescription.TabIndex = 16;
            txtDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 179);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 17;
            label7.Text = "$0.85 per km";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(290, 218);
            label8.Name = "label8";
            label8.Size = new Size(246, 15);
            label8.TabIndex = 18;
            label8.Text = "Maximum allowed: $35 (Meal) / $40 (Parking)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 496);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
            Controls.Add(cboCategory);
            Controls.Add(numAmount);
            Controls.Add(numKilometres);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtStaffName);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblExpenseDate);
            Controls.Add(lblStaffName);
            Controls.Add(staffexpensetitle);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Staff Expense Claim Estimator window";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometres).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label staffexpensetitle;
        private Label lblStaffName;
        private Label lblExpenseDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtStaffName;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numKilometres;
        private NumericUpDown numAmount;
        private ComboBox cboCategory;
        private Button btnCal;
        private Button btnClear;
        private Label label5;
        private RichTextBox txtDescription;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblAdjustmentMessage;
        private Label lblEstimate;
    }
}
