using System.Diagnostics.Eventing.Reader;

namespace Staff_expenses_claim
{
    public partial class Form1 : Form
    {
        // Declare constants for mileage rate, meal maximum, and parking maximum
        decimal mileageRate = 0.85m;
        decimal mealMaximum = 35.00m;
        decimal parkingMaximum = 40.00m;
        public Form1()
        {
            InitializeComponent();
            // Lecturer requirement: Set the maximum date for the DateTimePicker to today's date so it cannot be set to a future date
            dtpExpenseDate.MaxDate = DateTime.Today;

            // Require a category before entering kilometres or amount.
            cboExpenseCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExpenseCategory.SelectedIndex = -1;

            numKilometres.Enabled = false;
            numExpenseAmount.Enabled = false;

            lblEstimate.Text = "$0.00";
            lblAdjustmentMessage.Text = "---";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the Calculate button click event
        private void btnCal_Click(object sender, EventArgs e)
        {
            // Remove the previous estimate before validating new input.
            lblEstimate.Text = "$0.00";
            lblAdjustmentMessage.Text = "---";

            // Error handling for empty fields
            if (txtStaffName.Text == "")
            {
                // Error handling for empty staff name
                MessageBox.Show(
                    "Please enter staff name",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtStaffName.Focus();
                return;
            }
            
            if (txtDescription.Text == "")
            {
                // Error handling for empty description
                MessageBox.Show(
                    "Please enter description",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtDescription.Focus();
                return;
            }

            if (cboExpenseCategory.Text == "")
            {
                // Error handling for empty category selection
                MessageBox.Show(
                    "Please select a category",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                cboExpenseCategory.Focus();
                return;
            }

            string category = cboExpenseCategory.Text;

            // Milage
            if (category == "Mileage")
            {
                decimal kilometres = numKilometres.Value;

                if (kilometres <= 0)
                {
                    // Error handling for invalid kilometres input
                    MessageBox.Show(
                        "Please enter a valid number of kilometres",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    numKilometres.Focus();
                    return;
                }

                decimal estimate = kilometres * mileageRate;

                lblEstimate.Text = estimate.ToString("C2");

                lblAdjustmentMessage.Text = "Mileage calculated at $0.85 per kilometre.";

                // Display the estimated reimbursement
                MessageBox.Show(
                    "Estimate calculated successfully. \n\n" +
                    "Kilometres: " + kilometres + " km\n" +
                    "Rate: $0.85 per kilometre\n" +
                    "Estimate: " + estimate.ToString("C2"),
                    "Mileage Estimate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            //Meal
            else if (category == "Meal")
            {
                decimal amount = numExpenseAmount.Value;

                if (amount <= 0)
                {
                    // Error handling for invalid meal amount input
                    MessageBox.Show(
                        "Meal amount must be greater than zero",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    numExpenseAmount.Focus();
                    return;
                }

                decimal estimate;

                // Check if the meal amount exceeds the maximum limit
                if (amount > mealMaximum)
                {
                    estimate = mealMaximum;
                    lblAdjustmentMessage.Text = "Meal amount adjusted to $35.00";
                }

                else
                {
                    estimate = amount;
                    lblAdjustmentMessage.Text = "Meal amount is within the $35.00 limit";
                }

                lblEstimate.Text = estimate.ToString("C2");

                // Display the adjustment message and estimated reimbursement
                MessageBox.Show(
                    lblAdjustmentMessage.Text + "\n\nEstimated reimbursement:" +
                    estimate.ToString("C2"),
                    "Meal Estimate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            //Parking
            else if (category == "Parking")
            {
                decimal amount = numExpenseAmount.Value;
                if (amount <= 0)
                {
                    // Error handling for invalid parking amount input
                    MessageBox.Show(
                        "Parking amount must be greater than zero",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    numExpenseAmount.Focus();
                    return;
                }
                decimal estimate;

                // Check if the parking amount exceeds the maximum limit
                if (amount > parkingMaximum)
                {
                    estimate = parkingMaximum;
                    lblAdjustmentMessage.Text = "Parking amount adjusted to $40.00";

                }
                else
                {
                    estimate = amount;
                    lblAdjustmentMessage.Text = "Parking amount is within the $40.00 limit";

                }

                lblEstimate.Text = estimate.ToString("C2");

                // Display the adjustment message and estimated reimbursement
                MessageBox.Show(
                    lblAdjustmentMessage.Text + "\n\nEstimated reimbursement:" +
                    estimate.ToString("C2"),
                    "Parking Estimate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // Event handler for the Clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffName.Clear();
            cboExpenseCategory.SelectedIndex = -1;
            numKilometres.Value = 0;
            numExpenseAmount.Value = 0;
            txtDescription.Clear();

            // Reset the result labels
            lblEstimate.Text = "$0.00";
            lblAdjustmentMessage.Text = "---";

            txtStaffName.Focus();
        }
        
        // Event handler for the expense category selection change event
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEstimate.Text = "$0.00";
            lblAdjustmentMessage.Text = "---";

            string category = cboExpenseCategory.Text;

            // Enable or disable input fields based on the selected category
            if (category == "Mileage")
            {
                
                numKilometres.Enabled = true;
                numExpenseAmount.Enabled = false;

                numExpenseAmount.Value = 0;
            }
            else if (category == "Meal" || category == "Parking")
            {
                
                numKilometres.Enabled = false;
                numExpenseAmount.Enabled = true;

                numKilometres.Value = 0;
            }
            else
            {
                
                numKilometres.Enabled = false;
                numExpenseAmount.Enabled = false;

            }
        }
    }
}
