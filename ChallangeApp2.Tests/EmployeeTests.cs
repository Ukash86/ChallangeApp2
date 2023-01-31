namespace ChallengeApp2.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void MinMaxAndAverageGardeAreCorrects()
        {
            // arrange

            var employee = new Employee("Donald", "Trump");
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(12);

            // act

            var statistics = employee.GetStatistics();

            // assert

            Assert.AreEqual(1, statistics.Min);
            Assert.AreEqual(12, statistics.Max);
            Assert.AreEqual(6, statistics.Average);
        }
    }
}