using BMIForms.Exercise;
using System;
using System.Windows.Forms;


namespace BMIForms
{
    public partial class MainForm : Form
    {
        private Employee employee = new Employee();
        BMICalculator bmiCalculator;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //UI initilization 
        private void InitializeGUI()
        {

            this.Text = "The Body Mass Calculator";

            rdbUSUnitInput.Checked = true;
            bmiCalculator = new AmericanCalculator(employee);

            rdbMetricUnitInput.Checked = false;
            lblHeight.Text = "Height (ft)";
            lblWeight.Text = "Weight (lbs)";


            txtHeightInput.Text = string.Empty;
            txtWeightInput.Text = string.Empty;
            txtYourNameInput.Text = string.Empty;

            txtHeightInches.Text = string.Empty;

            lblBMIOutput.Text = string.Empty;
            lblWeightCategoryOutput.Text = string.Empty;
            lblBMIMessageOutput.Text = string.Empty;
            lblNormalWeightDisplay.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ReadInputBMI()) DisplayResults();
        }

        //validatoins
        private bool ReadInputBMI() => ReadName() && ReadHeight() && ReadWeight();

        private void DisplayResults()
        {

            lblBMIOutput.Text = bmiCalculator.CalculateBMI().ToString("f2");
            lblWeightCategoryOutput.Text = bmiCalculator.BMIWeightCategory().ToString();
            lblBMIMessageOutput.Text = bmiCalculator.normalBMIMessage;
            grpResults.Text = "Name : " + employee.Name;
            lblNormalWeightDisplay.Text = bmiCalculator.GetMessage();
        }



        private void rdbMetricUnitInput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMetricUnitInput.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";

                bmiCalculator = new MetricCalculator(employee);
                lblHeightFt.Visible = false;
                lblHeightIn.Visible = false;
                txtHeightInches.Visible = false;
            }
        }
        private void rdbUSUnitInput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUSUnitInput.Checked)
            {
                lblHeight.Text = "Height (ft)";
                lblWeight.Text = "Weight (lbs)";

                bmiCalculator = new AmericanCalculator(employee);

                lblHeightFt.Visible = true;
                lblHeightIn.Visible = true;
                txtHeightInches.Visible = true;
            }
        }


        private bool ReadHeight()
        {

            double height = 0;
            double inches = 0;
            double inchesConverted = 0;


            bool check1 = double.TryParse(txtHeightInput.Text.Trim(), out height);
            bool check2 = double.TryParse(txtHeightInches.Text.Trim(), out inches);

            if (bmiCalculator.Type == UnitTypes.American)
            {
                if (check2 && (inches >= 0))
                {
                    inchesConverted = inches / 12;
                }
                else
                {
                    MessageBox.Show("Invalid Height value (inches)!", "Error!");
                    return false;
                }
            }


            if (check1 && (height > 0))
            {

                if (bmiCalculator.Type == UnitTypes.American)
                {

                    employee.Height = (height + inchesConverted) * 12.00;
                }
                else
                {
                    employee.Height = height / 100.0;
                }
            }
            else
            {
                MessageBox.Show("Enter Height !", "Error!");
                return false;
            }

            return check1;
        }


        private bool ReadName()
        {
            if (string.IsNullOrEmpty(txtYourNameInput.Text.Trim()))
            {
                MessageBox.Show("Please enter your name!", "Error!");
                return false;
            }
            else
            {
                employee.Name = txtYourNameInput.Text.Trim();
            }
            return true;
        }
        private bool ReadWeight()
        {

            double outValue = 0;

            bool flag = double.TryParse(txtWeightInput.Text.Trim(), out outValue);

            if (flag && (outValue > 0))
            {
                employee.Weight = outValue;
            }
            else
            {
                MessageBox.Show("Enter Weight !", "Error!");
                return false;
            }

            return flag;
        }




        private void clearButton_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }
    }
}
