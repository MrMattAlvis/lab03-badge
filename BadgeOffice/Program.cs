//Part 1
using System.Security;

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

//Part 2

int studentId = rng.Next(100000,1000000);
int locker = rng.Next(1,501);

System.Console.WriteLine("Student ID: " + studentId);
System.Console.WriteLine("Locker: " + locker);
// I dont know wht .gitignore isn't working

//Part 3

Console.Write("Dorm X: ");
double dormX = double.Parse(Console.ReadLine());

Console.Write("Dorm Y: ");
double dormY = double.Parse(Console.ReadLine());

Console.Write("Class X: ");
double classX = double.Parse(Console.ReadLine());

Console.Write("Class Y: ");
double classY = double.Parse(Console.ReadLine());

Console.Write("Walking speed in feet per second: ");
double speed = double.Parse(Console.ReadLine());

double changeInX = classX - dormX;
double changeInY = classY -dormY;

double distance = Math.Sqrt(Math.Pow(changeInX,2) + (Math.Pow(changeInY,2)));

double exactSeconds = distance / speed;
double totalSeconds = (int) exactSeconds;

double minutes = totalSeconds / 60;
double remainingSeconds = totalSeconds % 60;

System.Console.WriteLine("Distance: " + Math.Round(distance,1) + " feet");
System.Console.WriteLine("Walk time: " + Math.Round(minutes,0) + " minutes " + remainingSeconds + " seconds");