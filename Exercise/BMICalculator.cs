namespace BMIForms.Exercise
{
    public abstract class BMICalculator
    {
        public abstract double CalculateBMI();
        public abstract double CalculateWeight(double bmi);

        //https://www.heartfoundation.org.nz/wellbeing/bmi-calculator
        public string BMIWeightCategory()
        {
            if (BMI > 30) return "Obesity";
            if (BMI >= 24.9) return "Overweight";
            if (BMI >= 18.5) return "Normal weight";
            return "Underweight";
        }

        public UnitTypes Type { get; set; }

        public string unit = "lbs"; //Default unit

        public double BMI;

        public string normalBMIMessage = "Normal BMI is between 18.50 and 24.9";
        public string GetMessage()
        {
            return "Normal weight should be between " + CalculateWeight(18.50).ToString("f2") + " and " + CalculateWeight(24.9).ToString("f2") + $" {unit}";
        }
    }
}
