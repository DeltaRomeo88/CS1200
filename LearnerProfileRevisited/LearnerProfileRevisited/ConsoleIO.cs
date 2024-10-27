namespace LearnerProfile
{
    public class ConsoleIO
    {
        public string GetRequiredString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public bool GetYesNoBoolean(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine().ToUpper();

                switch(input)
                {
                    case "Y":
                        return true;
                    case "N":
                        return false;
                    default:
                        Console.WriteLine("Please enter 'Y' or 'N'");
                        break;
                }
            } while (true);
        }

        public decimal GetPositiveDecimal(string prompt)
        {
            decimal input;
            do
            {
                Console.Write(prompt);
            } while (!decimal.TryParse(Console.ReadLine(), out input) || input <= 0);
            return input;
        }

        public int GetPositiveInt(string prompt)
        {
            int input;
            do
            {
                Console.Write(prompt);
            } while (!int.TryParse(Console.ReadLine(), out input) || input <= 0);
            return input;
        }

        public void DisplayProfile(Profile profile)
        {
            Console.WriteLine($"Name: {profile.FirstName} {profile.LastName}");
            Console.WriteLine($"Email: {profile.Email}");
            Console.WriteLine($"Age: {profile.Age}");
            Console.WriteLine($"Height: {profile.Height}");
            Console.WriteLine($"Weight: {profile.Weight}");
            Console.WriteLine($"Marketing Opt-In: {profile.MarketingOptIn}");
        }
    }
}