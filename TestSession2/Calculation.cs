namespace TestSession2
{
    public class Calculation
    {
        public double SalaryCalculation(string post, double bet)
        {
            double salary = 0;

            post = post.ToLower();
            switch (post)
            {
                case "директор":
                    salary = 30000;
                    break;
                case "мастер":
                    salary = 20000;
                    break;
                case "водитель":
                    salary = 15000;
                    break;
                default:
                    return -1;
            }

            // bet > 3 ограничение в 3 ставки макисмум
            if (bet < 0 || bet > 3) {
                return -1;
            }

            salary = salary * bet * 0.87;

            return salary;
        }
    }
}
