/*
* Name: Matthew Alan Alvis
* Course: CSCI 1250, Section 201
* Assignment: Lab 03, The Badge Office
* Date: October 4, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
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
System.Console.WriteLine(" ");
//Part 2

int studentId = rng.Next(100000,1000000);
int locker = rng.Next(1,501);

System.Console.WriteLine("Student ID: " + studentId);
System.Console.WriteLine("Locker: " + locker);
System.Console.WriteLine(" ");
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

System.Console.WriteLine(" ");
System.Console.WriteLine("Distance: " + Math.Round(distance,1) + " feet");
System.Console.WriteLine("Walk time: " + Math.Round(minutes,0) + " minutes " + remainingSeconds + " seconds");
System.Console.WriteLine(" ");

System.Console.WriteLine("==================================");
System.Console.WriteLine("        ETSU STUDENT BADGE");
System.Console.WriteLine("==================================");
System.Console.WriteLine("NAME      " + fullName);
System.Console.WriteLine("USERNAME  " + userName);
System.Console.WriteLine("ID        " + studentId);
System.Console.WriteLine("LOCKER    " + locker);
System.Console.WriteLine("WALK      " + Math.Round(minutes,0) + " min " + remainingSeconds + " sec");
System.Console.WriteLine("==================================");

// Sorry I couldn't get the .gitignore work properly, I don'tknow what I did wrong their.
//any feedback would be great. I feel like I got most of this down pat, but is their an area I should work to improve on.