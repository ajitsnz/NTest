namespace BMIForms.Exercise
{
    class AmericanCalculator : BMICalculator
    {
        private Employee Calculator;

        public AmericanCalculator(Employee calculator)
        {
            this.Calculator = calculator;
            Type = UnitTypes.American;
            unit = "lbs";
        }
        public override double CalculateBMI() =>
        BMI = 703.0 * Calculator.Weight / (Calculator.Height * Calculator.Height);


        public override double CalculateWeight(double bmi) =>
        bmi * (Calculator.Height * Calculator.Height) / 703.0;

    }
}
