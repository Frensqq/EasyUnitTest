using TestSession2;


namespace Test
{
   
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test_sapary_postDirector_bet08_return20880()
        {
            string post = "Директор";
            double bet = 0.8;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(20880));
        }

        [Test]
        public void Test_sapary_postMaster_bet05_return10000()
        {
            string post = "Мастер";
            double bet = 0.5;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(8700));
        }


    }
}
