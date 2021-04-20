namespace BMIForms.Exercise
{
    class MetricCalculator : BMICalculator
    {
        private Employee Calculator;

        public MetricCalculator(Employee calculator)
        {
            this.Calculator = calculator;
            Type = UnitTypes.Metric;
            unit = "kg";
        }

        public override double CalculateBMI() =>
        BMI = Calculator.Weight / (Calculator.Height * Calculator.Height);


        public override double CalculateWeight(double bmi) =>
        bmi * (Calculator.Height * Calculator.Height);
    }
}

