using TestSession2;


namespace Test
{
   
    [TestFixture]
    public class Tests
    {
        //Низкая сложность
        [Test]
        public void Test_salary_postDirector_bet08_return20880()
        {
            string post = "Директор";
            double bet = 0.8;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(20880));
        }

        [Test]
        public void Test_salary_postMaster_bet05_return8700()
        {
            string post = "Мастер";
            double bet = 0.5;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(8700));
        }

        [Test]
        public void Test_salary_postDriver_bet1_return13050()
        {
            string post = "Водитель";
            double bet = 1;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(13050));
        }

        [Test]
        public void Test_salary_postDirector_bet2_return52000()
        {
            string post = "Директор";
            double bet = 2;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(52200));
        }

        [Test]
        public void Test_salary_postMaster_bet01_return1740()
        {
            string post = "Мастер";
            double bet = 0.1;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(1740));
        }

        [Test]
        public void Test_salary_postDriver_bet15_return19575()
        {
            string post = "Водитель";
            double bet = 1.5;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(19575));
        }

        [Test]
        public void Test_salary_postDriver_bet04_return5220()
        {
            string post = "Водитель";
            double bet = 0.4;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(5220));
        }

        [Test]
        public void Test_salary_postDirector_bet025_return6525()
        {
            string post = "Директор";
            double bet = 0.25;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(6525));
        }

        [Test]
        public void Test_salary_postDirector_bet12_return31320()
        {
            string post = "Директор";
            double bet = 1.2;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(31320));
        }

        [Test]
        public void Test_salary_postMaster_bet17_return29580()
        {
            string post = "Мастер";
            double bet = 1.7;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(29580));
        }


        //Высокая сложность
        //Отрицательная ставка
        [Test]
        public void HardTest_salary_postDriver_betNegative04_returnNegative1()
        {
            string post = "Водитель";
            double bet = -0.4;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(-1));
        }

        //пустая должность
        [Test]
        public void HardTest_salary_postNull_bet08_returnNegative1()
        {
            string post = "";
            double bet = 0.8;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(-1));
        }

        //слишком высокая ставка
        [Test]
        public void HardTest_salary_postMaster_bet135_returnNegative1()
        {
            string post = "Мастер";
            double bet = 13.5;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(-1));
        }

        //пустая должность
        [Test]
        public void HardTest_salary_postDIRECRTOR_bet1_return26100()
        {
            string post = "ДИРЕКТОР";
            double bet = 1;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(26100));
        }

        //слишком высокая ставка
        [Test]
        public void HardTest_salary_postmAsTer_bet1_return17400()
        {
            string post = "мАсТер";
            double bet = 1;

            Calculation calculation = new Calculation();
            double salary = calculation.SalaryCalculation(post, bet);

            Assert.That(salary, Is.EqualTo(17400));
        }

    }
}
