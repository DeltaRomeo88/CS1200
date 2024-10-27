// See https://aka.ms/new-console-template for more information
using LearnerProfile;

Profile profile = new();
ConsoleIO io = new();

profile.FirstName = io.GetRequiredString("Enter your first name: ");
profile.LastName = io.GetRequiredString("Enter your lastname: ");
profile.Email = io.GetRequiredString("Enter your email: ");

profile.Age = io.GetPositiveInt("Enter your age: ");
profile.Height = io.GetPositiveDecimal("Enter your height in cm: ");
profile.Weight = io.GetPositiveDecimal("Enter your weight in kg: ");

profile.MarketingOptIn = io.GetYesNoBoolean("Opt-in for marketing? (y/n): ");

io.DisplayProfile(profile);
