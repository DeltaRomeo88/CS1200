// See https://aka.ms/new-console-template for more information
// int startDate = "Start Date";
// int endDate = "End Date";

class appTracker
{
static void Main()
    {
        DateTime startDate, endDate;
        string frequency;
        bool skipWeekends = false;

        // Get start date
        do
        {
            Console.Write("Enter start date (ex:10/10/2024): ");
        } while (!DateTime.TryParse(Console.ReadLine(), out startDate));

        // Get validate end date
        do
        {
            Console.Write("Enter end date: ");
        } while (!DateTime.TryParse(Console.ReadLine(), out endDate) || endDate <= startDate);

        // Get frequency
        do
        {
            Console.Write("Enter Frequency [(D)aily, (W)eekly, (M)onthly, (Y)early]: ");
            frequency = Console.ReadLine().ToUpper();
        } while (!"DWMY".Contains(frequency));

        // Ask about skipping weekends if daily
        if (frequency == "D")
        {
            string skipWeekendsInput;
            do
            {
                Console.Write("Skip Weekends (Y/N): ");
                skipWeekendsInput = Console.ReadLine().ToUpper();
            } while (skipWeekendsInput != "Y" && skipWeekendsInput != "N");

            skipWeekends = (skipWeekendsInput == "Y");
        }

        Console.WriteLine("\nAppointment Dates");
        Console.WriteLine("==============");

        DateTime currentDate = startDate;
        while (currentDate <= endDate)
        {
            if (frequency == "D")
            {
                if (!skipWeekends || (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday))
                {
                    Console.WriteLine(currentDate.ToString("dddd MMM d, yyyy"));
                }
                currentDate = currentDate.AddDays(1);
            }
            else if (frequency == "W")
            {
                Console.WriteLine(currentDate.ToString("dddd MMM d, yyyy"));
                currentDate = currentDate.AddDays(7);
            }
            else if (frequency == "M")
            {
                Console.WriteLine(currentDate.ToString("dddd MMM d, yyyy"));
                currentDate = currentDate.AddMonths(1);
            }
            else if (frequency == "Y")
            {
                Console.WriteLine(currentDate.ToString("dddd MMM d, yyyy"));
                currentDate = currentDate.AddYears(1);
            }
        }
    }
}