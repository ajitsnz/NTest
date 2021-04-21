using BMIForms.Exercise;
using NUnit.Framework;

namespace BMIForms.Test
{
    public class BMICalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(6, 1, 176, 23.22)]
        [TestCase(6, 0, 176, 23.87)]
        [TestCase(1, 11, 200, 265.78)]
        public void AmericanCalculator_Test(double height, double hinches, double weight, double expectedBmi)
        {
            Employee emp = new Employee();
            emp.Name = "Test";
            emp.Height = height;
            emp.HeightInInches = hinches;
            emp.Weight = weight;
            BMICalculator calculator = new AmericanCalculator(emp);

            string bmi = calculator.CalculateBMI().ToString("f2");
            calculator.CalculateWeight(calculator.BMI);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(calculator.unit, "lbs", "Check unit");
                Assert.AreEqual(calculator.Type, UnitTypes.American, "Check unit Type");
                Assert.AreEqual(bmi, expectedBmi.ToString("f2"), "Check BMI");
            });
        }

        [TestCase(180, 80, 24.69)]
        [TestCase(150, 70, 31.11)]
        [TestCase(130, 60, 35.5)]
        [TestCase(111, 50, 40.58)]
        public void MetricCalculator_Test(double height, double weight, double expectedBmi)
        {
            Employee emp = new Employee();
            emp.Name = "Test";
            emp.Height = height;
            emp.Weight = weight;
            BMICalculator calculator = new MetricCalculator(emp);

            string bmi = calculator.CalculateBMI().ToString("f2");
            calculator.CalculateWeight(calculator.BMI);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(calculator.unit, "kg", "Check unit");
                Assert.AreEqual(calculator.Type, UnitTypes.Metric, "Check unit Type");
                Assert.AreEqual(bmi, expectedBmi.ToString("f2"), "Check BMI");

            });

        }
    }
}