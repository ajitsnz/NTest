namespace BMIForms.Exercise
{
    public class MetricCalculator : BMICalculator
    {
        private static Employee employee;
        private static MetricCalculator instance;

        private MetricCalculator(Employee _employee)
        {  
            employee = _employee;
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

        public static MetricCalculator GetInstance(Employee employee)
        {
             if (instance == null) instance = new MetricCalculator(employee);
             return instance;
          
        }
    }
}

