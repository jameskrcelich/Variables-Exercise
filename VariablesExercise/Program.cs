namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "James";
            int principal = 5000;
            char middleInitial = 'P';
            bool isWorking = true;
            double  interestRate = 4.25;
            decimal interestRateMonthly = 354167;
            double  interestAmount = 0.0;
            
            Console.WriteLine($"My first name is {myName}, my middle initial is {middleInitial}");
            if (isWorking == true)
            {
                Console.WriteLine($"I am currently employed");
            }
            else
            {
                Console.WriteLine($"I am unemployed");
            }
            Console.WriteLine($"My savings account is equal to ${principal}");
            Console.WriteLine($"My yearly interest is equal to ${interestRate}%");
            
            interestAmount = (((double)principal) * ((double)(interestRateMonthly/100000000)));
            Console.WriteLine($"My first monthly interest amount is equal to ${Math.Round(interestAmount, 2)}");
            
        }
    }
}
