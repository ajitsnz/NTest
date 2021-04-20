namespace BMIForms.Exercise
{
    class AmericanCalculator : BMICalculator
    {
        private Employee employee;

        public AmericanCalculator(Employee employee)
        {
            this.employee = employee;
            Type = UnitTypes.American;
            unit = "lbs";
        }
        public override double CalculateBMI() =>
        BMI = 703.0 * employee.Weight / (employee.Height * employee.Height);


        public override double CalculateWeight(double bmi) =>
        bmi * (employee.Height * employee.Height) / 703.0;

    }
}
