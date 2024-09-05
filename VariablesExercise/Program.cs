namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Rick";
            int age = 52;
            char middleInitial = 'R';
            bool isOver18 = true;
            double currentTemp = 87.5;
            decimal bankAccount = 200150.50m;


            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Over 18: {isOver18}");
            Console.WriteLine($"Current Body Temp: {currentTemp}");
            Console.WriteLine($"BankAccount: {bankAccount}");
        }
    }
}
