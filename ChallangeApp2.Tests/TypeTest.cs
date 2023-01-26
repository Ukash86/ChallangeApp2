namespace ChallengeApp2.Tests
{
    public class TypeTest
    {
        [Test]
        public void AllNumbersAreTheSame()
        {
            // arrange
            int number1 = 5;
            int number2 = 5;
            int number3 = 5;

            // act

            // assert
            Assert.AreEqual(number1, number2, number3);
        }

        [Test]
        public void LettersAreDifferent()
        {
            // arrange
            char letter1 = 'w';
            char letter2 = 'd';

            // act

            // assert
            Assert.AreNotEqual(letter1, letter2);
        }

        [Test]
        public void AllTheSameNames()
        {
            // arrange
            string name1 = "Leon";
            string name2 = "Leon";
            string name3 = "Leon";
            string name4 = "Leon";

            // act

            // assert
            Assert.AreEqual(name1, name2, name3, name4);
        }

        [Test]
        public void GetEmployeeShowAllDifferentEmployee()
        {
            // arrange
            var employee1 = GetEmployee("Leon");
            var employee2 = GetEmployee("Leon");

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name, "Tesla", 30);
        }

    }
}