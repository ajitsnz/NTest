namespace BMIForms.Exercise
{
    public class AmericanCalculator : BMICalculator
    {
        private static Employee employee;
        private static AmericanCalculator instance;

        private AmericanCalculator(Employee _employee)
        {
            employee = _employee;
            Type = UnitTypes.American;
            unit = "lbs";
        }
               
        public override double CalculateBMI()
        {
            employee.Height = (employee.Height + (employee.HeightInInches / 12)) * 12.00;
            return BMI = 703.0 * employee.Weight / (employee.Height * employee.Height);
        }

        public override double CalculateWeight(double bmi) =>
        bmi * (employee.Height * employee.Height) / 703.0;

        public static AmericanCalculator GetInstance(Employee employee)
        {
               if (instance == null)
                    instance = new AmericanCalculator(employee);
                return instance;
        }

    }
}
