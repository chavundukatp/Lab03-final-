Console.WriteLine("Hello, World!");
/*
 Lab 3 
* Tinashe chavunduka 
*CSCI 1250
*/

// Part 1 

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("What is your name?"); 
string fullName = Console.ReadLine().ToUpper();
Console.WriteLine($"See me in action, {fullName}"); 

Console.WriteLine("Username?"); 
string Username = Console.ReadLine().ToLower();
Console.WriteLine($"See me in action, {Username}"); 

int space = fullName.IndexOf(""); 

Console.WriteLine("Initial?"); 
string firstInitial = fullName.Substring(0,1).ToUpper(); 
string lastInitial = fullName.Substring(space + 1, 1).ToUpper(); 

Console.WriteLine("Initials; " + firstInitial + "." + lastInitial + "."); 


string LastName = "Lovelace"; 
int letters = LastName.Length; 
Console.WriteLine("Letters in last name: " + letters); 

// Part 2 

int studentID = rng.Next(100000, 1000000); 
int locker = Range.Next(1, 501); 
Console.Write(); 
Console.WriteLine(); 
Console.WriteLine("Student ID: " + studentID); 
Console.WriteLine("Locker: " + locker); 

// part 3 

Console.WriteLine("What is the dorm X coordinate?"); 
double dormX = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("What is the dorm Y coordinate?"); 
double dormY = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("What is the classroom X coordinate?"); 
double classroomX = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("What is the classroom Y coordinate?"); 
double classroomY = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("What is your walking speed?"); 
double speed = Convert.ToDouble(Console.ReadLine()); 

// variables: 

double xDistance = classroomX - dormX; 
double yDistance = classroomY - dormY; 
double yAnswer = Math.Pow(yDistance, 2); 
double xAnswer = Math.Pow(yDistance, 2); 

double totalDistance = xAnswer + yAnswer; 
double distance = Math.Sqrt(totalDistance); 
double time = distance / speed; 

int totalSeconds =(int)time; 
int minutes = totalSeconds / 60; 
int seconds = totalSeconds % 60; 

Console.WriteLine("Distance: " + distance.ToString("F1") + " feet"); 
Console.WriteLine("Walking time: " + (minutes) + " minutes &" + seconds + " seconds"); 

// Part 4 : 

int checkDigit = studentID % 9; 
string completeID = studentID + "-" + (checkDigit); 

Console.WriteLine("==================================="); 
Console.WriteLine("Student Badge"); 
Console.WriteLine("==================================="); 

const int LABEL_WIDTH = 10; 
string nameLabel = "Name"; 
string paddedNameLabel = nameLabel.PadRight(LABEL_WIDTH); 
string nameLine = paddedNameLabel + displayName;
Console.WriteLine(nameLine); 

string UsernameLabel = "Username"; 
string paddedUsernameLabel = UsernameLabel.PadRight(LABEL_WIDTH); 
string paddedUsernameLabel = UsernameLabel + Username; 
Console.WriteLine(usernameLine); 

string initials = firstinitial + "." + lastInitial + "."; 
string initialsLabel = "Initials"; 
string paddedInitialsLabel = initialsLabel.PadRight(LABEL_WIDTH); 
Console.WriteLine(initials); 

string IDlabel = "Student ID"; 
string paddedIDlabel = IDlabel.PadRight(LABEL_WIDTH); 
string idLine = paddedIDlabel + completeID; 
Console.WriteLine(IDlabel); 

string Lockerlabel = "Locker"; 
string paddedIDlabelLockerlabel = IDlabel.PadRight(LABEL_WIDTH); 
string paddedLockerlabel = Lockerlabel + locker; 
Console.WriteLine(Lockerlabel); 

string distanceText = distance.ToString("F1") + "ft"; 
string distanceLabel = "Distance:"; 
string distanceLine = paddedDistanceLabel +.Padright(LABEL_WIDTH); 
string distanceLine = paddedDistanceLabel + distanceText; 
Console.WriteLine(distanceLine); 

string walktext = minutes + " min " + seconds + " sec "; 
string walklabel = "walk:"; 
string paddedWalklabel = walklabel.PadRight(LABEL_WIDTH); 
string walkLine = paddedWalklabel + walktext; 
string walkline = paddedWalklabel + walktext; 
Console.WriteLine(walkline); 

// Tinashe Chavunduka Lab 3
