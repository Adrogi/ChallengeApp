

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]

        public void GetIntValues_ShouldReturnEqual()
        {
            int number1 = 7;
            int number2 = 7;

            Assert.AreEqual(number1, number2);

        }

        [Test]

        public void GetFloatValues_ShouldReturnEqual()
        {
            float firstFloat = 3.44f;
            float secondFloat = 3.44f;

            Assert.AreEqual(firstFloat, secondFloat);

        }

        [Test]

        public void GetStringValues_ShouldReturnDifferent()
        {
            string name1 ="Bartek";
            string name2 = "Igor";

            Assert.AreNotEqual(name1, name2);

        }

        [Test]

        public void GetTwoEmployess_ShouldReturnTwoDifferentObjects()
        {
            var employee1 = GetEmployee("Michał", "Kowalski", "22");
            var employee2 = GetEmployee("Michał", "Kowalski", "22");

            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee(name, surname, age);
        }

    }
}
