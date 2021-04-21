namespace BMIForms.Exercise
{
    public class MetricCalculator : BMICalculator
    {
        private Employee employee;

        public MetricCalculator(Employee employee)
        {
            this.employee = employee;
            Type = UnitTypes.Metric;
            unit = "kg";
        }

        public override double CalculateBMI()
        {
            employee.Height = employee.Height / 100;
            return BMI = employee.Weight / (employee.Height * employee.Height);
        }

        public override double CalculateWeight(double bmi) =>
        bmi * (employee.Height * employee.Height);
    }
}

