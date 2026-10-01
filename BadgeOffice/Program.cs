//Part 1
Random rng = new Random();

System.Console.Write("Full name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string nameOnBadge = fullName.ToUpper();
string userName = (firstName.Substring(0,1) + lastName).ToLower();
string initials = firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(0,1).ToUpper() + ".";

System.Console.WriteLine("Name on badge: " + nameOnBadge);
System.Console.WriteLine("UserName: " + userName);
System.Console.WriteLine("Initials: " + initials);
System.Console.WriteLine("Letteres in last name: " + lastName.Length);

