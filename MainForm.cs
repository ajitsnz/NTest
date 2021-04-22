using BMIForms.Exercise;
using System;
using System.Windows.Forms;


namespace BMIForms
{
    public partial class MainForm : Form
    {
        private Employee employee = new Employee();
        BMICalculator bmiCalculator ;

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
            bmiCalculator = AmericanCalculator.GetInstance(employee);

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

        //validations
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

                bmiCalculator = MetricCalculator.GetInstance(employee);
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

                bmiCalculator = AmericanCalculator.GetInstance(employee);

                lblHeightFt.Visible = true;
                lblHeightIn.Visible = true;
                txtHeightInches.Visible = true;
            }
        }


        private bool ReadHeight()
        {
            double height = 0;
            double inches = 0;

            bool heightFtCheck = double.TryParse(txtHeightInput.Text.Trim(), out height);
            bool heightInchCheck = double.TryParse(txtHeightInches.Text.Trim(), out inches);


            if (bmiCalculator.Type.Equals(UnitTypes.American))
            {
                if (heightInchCheck && (inches >= 0))
                {
                    employee.HeightInInches = inches;
                }
                else
                {
                    MessageBox.Show("Enter valid Height value (inches)!", "Error!");
                    return false;
                }
            }

            if (heightFtCheck && (height > 0))
            {
                    employee.Height = height;
            }
            else
            {
                MessageBox.Show("Enter valid Enter Height !", "Error!");
                return false;
            }

            return heightFtCheck;
        }


        private bool ReadName()
        {
            if (string.IsNullOrEmpty(txtYourNameInput.Text.Trim()))
            {
                MessageBox.Show("Please enter your name!", "Error!");
                return false;
            }
            employee.Name = txtYourNameInput.Text.Trim();
            return true;
        }
        private bool ReadWeight()
        {
            double outValue = 0;

            bool weightCheck = double.TryParse(txtWeightInput.Text.Trim(), out outValue);

            if (weightCheck && (outValue > 0))
            {
                employee.Weight = outValue;
            }
            else
            {
                MessageBox.Show("Enter valid Weight !", "Error!");
                return false;
            }

            return weightCheck;
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }
    }
}
