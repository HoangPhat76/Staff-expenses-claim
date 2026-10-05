using System.Diagnostics.Eventing.Reader;

namespace Staff_expenses_claim
{
    public partial class Form1 : Form
    {
        decimal mileageRate = 0.85m;
        decimal mealMaximum = 35.00m;
        decimal parkingMaximum = 40.00m;
        public Form1()
        {
            InitializeComponent();
            dtpExpenseDate.MaxDate = DateTime.Now;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "")
            {
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
                MessageBox.Show(
                    "Please enter description",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtDescription.Focus();
                return;
            }

            if (cboCategory.Text == "")
            {
                MessageBox.Show(
                    "Please select a category",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                cboCategory.Focus();
                return;
            }

            string category = cboCategory.Text;

            // Milage
            if (category == "Mileage")
            {
                decimal kilometres = numKilometres.Value;

                if (kilometres <= 0)
                {
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
                decimal amount = numAmount.Value;

                if (amount <= 0)
                {
                    MessageBox.Show(
                        "Meal amount must be greater than zero",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    numAmount.Focus();
                    return;
                }

                decimal estimate;

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

                MessageBox.Show(
                    lblAdjustmentMessage.Text + "\n\nEstimated reimbursement:" +
                    estimate.ToString("C2"),
                    "Meal Estimate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else if (category == "Parking")
            {
                decimal amount = numAmount.Value;
                if (amount <= 0)
                {
                    MessageBox.Show(
                        "Parking amount must be greater than zero",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    numAmount.Focus();
                    return;
                }
                decimal estimate;

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

                MessageBox.Show(
                    lblAdjustmentMessage.Text + "\n\nEstimated reimbursement:" +
                    estimate.ToString("C2"),
                    "Parking Estimate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffName.Clear();
            cboCategory.SelectedIndex = -1;
            numKilometres.Value = 0;
            numAmount.Value = 0;
            txtDescription.Clear();

            lblEstimate.Text = "$0.00";
            lblAdjustmentMessage.Text = "---";

            txtStaffName.Focus();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cboCategory.Text;

            if (category == "Mileage")
            {
                
                numKilometres.Enabled = true;
                numAmount.Enabled = false;

                numAmount.Value = 0;
            }
            else if (category == "Meal" || category == "Parking")
            {
                
                numKilometres.Enabled = false;
                numAmount.Enabled = true;

                numKilometres.Value = 0;
            }
            else
            {
                
                numKilometres.Enabled = false;
                numAmount.Enabled = false;

            }
        }
    }
}
