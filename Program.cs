
// See https://aka.ms/new-console-template for more information
string studentName = "Sophia Johnson";
string course1Name = "English101";
string course2Name = "Algebra101";
string course3Name = "Biology101";
string course4Name =  "Computer Science I";
string course5Name = "Psychology101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;

int course1GradePoints = course1Grade * course1Credit;
int course2GradePoints = course2Grade * course2Credit;
int course3GradePoints = course3Grade * course3Credit;
int course4GradePoints = course4Grade * course4Credit;
int course5GradePoints = course5Grade * course5Credit;

int totalGradePoints = course1GradePoints + course2GradePoints + course3GradePoints + course4GradePoints + course5GradePoints;

decimal totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
decimal finalGPA = (decimal) totalGradePoints / totalCreditHours;

int leadingDigit = (int) finalGPA;
int firstDigit =  (int) (finalGPA * 10) % 10;
int secondDigit =  (int) (finalGPA * 100) % 10;

Console.WriteLine($"{studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours\tGrade Points\n");
Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}\t\t{course1GradePoints}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}\t\t{course2GradePoints}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}\t\t{course3GradePoints}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}\t\t{course4GradePoints}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}\t\t{course5GradePoints}\n");
Console.WriteLine($"Final GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
Console.ReadKey();
