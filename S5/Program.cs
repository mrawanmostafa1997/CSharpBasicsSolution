// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Text;

//Part 1: Enums
//Q1: Day of the Week



Console.WriteLine("Please input the value between (1-7)");
var inputDay = Console.ReadLine();


var day = Enum.GetName(typeof(DayOfWeek),int.Parse(inputDay)-1);
Console.WriteLine(day);
switch (inputDay)
{
    case "1":
    case "7":
        Console.WriteLine("It's the Weekend.");
        break;
    case "2":
    case "3":
    case "4":
    case "5":
    case "6":
        Console.WriteLine("It's a Workday.");
        break;
    default:
        break;
}


//Part 2: Arrays
//Q1: Array Statistics
Console.WriteLine("Please Input the array size");
var arrSize = int.Parse(Console.ReadLine());

var array = new double[arrSize];
double min = double.MaxValue;
double max = double.MinValue;
double sum = 0;
StringBuilder reverse = new StringBuilder();
for (int i = 0; i < arrSize; i++)
{
    Console.WriteLine($"Enter Elmeent [{i}]:");
    var element = double.Parse(Console.ReadLine().ToString());
    array[i] = element;
    if (element < min)
    {
        min = element;
    }
    if (element > max)
    {
        max = element;
    }
    sum += element;
}
Console.WriteLine($"The Sum Value is: {sum}");
Console.WriteLine($"The Average Value is: {sum/arrSize}");
Console.WriteLine($"The Min Value is: {min}");
Console.WriteLine($"The Max Value is: {max}");

for (int i = arrSize-1; i >= 0; i--)
{
    string.Format("Element [{0}] = {1}", i, array[i]);
    reverse.Append(array[i]).Append(',');
}

Console.WriteLine($"Reverse is: {reverse.ToString()}");












//part3


int numStudents = 3;
int numSubjects = 4;
int[,] grades = new int[numStudents, numSubjects];

for (int i = 0; i < numStudents; i++)
{
    Console.WriteLine($"\n--- Enter grades for Student {i + 1} ---");
    for (int j = 0; j < numSubjects; j++)
    {
        Console.Write($"Grade for Subject {j + 1}: ");

        // Read the input and convert it to an integer
        string input = Console.ReadLine();
        grades[i, j] = int.Parse(input);
    }
}

Console.WriteLine("\n=== Results ===");

// 3. Process and Print Averages
double classTotalSum = 0;
int totalGradesCount = numStudents * numSubjects;

for (int i = 0; i < numStudents; i++)
{
    double studentSum = 0;

    for (int j = 0; j < numSubjects; j++)
    {
        studentSum += grades[i, j];
    }

    // Calculate student average
    double studentAverage = studentSum / numSubjects;
    Console.WriteLine($"Student {i + 1} Average: {studentAverage:F2}");

    // Add this student's total to the overall class total
    classTotalSum += studentSum;
}

// Calculate and print overall class average
double classAverage = classTotalSum / totalGradesCount;
Console.WriteLine($"\nOverall Class Average: {classAverage:F2}");

// Keep console window open
Console.ReadLine();








Console.Write("Enter the first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter an operator (+, -, *, /): ");
string op = Console.ReadLine();

Console.Write("Enter the second number: ");
double num2 = double.Parse(Console.ReadLine());

double result = 0;
bool validOperation = true;

switch (op)
{
    case "+": result = Add(num1, num2); break;
    case "-": result = Subtract(num1, num2); break;
    case "*": result = Multiply(num1, num2); break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            validOperation = false;
        }
        else
        {
            result = Divide(num1, num2);
        }
        break;
    default:
        Console.WriteLine("Invalid operator.");
        validOperation = false;
        break;
}

if (validOperation)
{
    Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
}






Console.Write("Enter the radius of the circle: ");
double radius = double.Parse(Console.ReadLine());

// The variables 'area' and 'circumference' don't need values yet. 
// The method will assign them.
CalculateCircle(radius, out double area, out double circumference);

Console.WriteLine($"\nArea: {area:F2}");
Console.WriteLine($"Circumference: {circumference:F2}");




// 2. Array to store 5 student scores
int[] scores = new int[5];

Console.WriteLine("--- Student Grade Manager ---");

// Read 5 scores from the user
for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Enter score for Student {i + 1}: ");
    scores[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n--- Grade Report ---");

// Print each score and corresponding letter grade
for (int i = 0; i < scores.Length; i++)
{
    Grade letterGrade = GetGrade(scores[i]);
    Console.WriteLine($"Student {i + 1}: Score = {scores[i]}, Grade = {letterGrade}");
}

// Calculate and print average, min, and max
double average = CalculateAverage(scores);
GetMinMax(scores, out int minScore, out int maxScore);

Console.WriteLine("\n--- Class Statistics ---");
Console.WriteLine($"Class Average: {average:F1}");
Console.WriteLine($"Highest Score: {maxScore}");
Console.WriteLine($"Lowest Score:  {minScore}");
    

    // Method a) Get Enum Grade based on integer score
    static Grade GetGrade(int score)
{
    if (score >= 90) return Grade.A;
    if (score >= 80) return Grade.B;
    if (score >= 70) return Grade.C;
    if (score >= 60) return Grade.D;
    return Grade.F;
}

// Method b) Calculate Average



static void CalculateCircle(double radius, out double area, out double circumference)
{
    area = Math.PI * radius * radius;
    circumference = 2 * Math.PI * radius;
}
static double CalculateAverage(int[] scores)
{
    double sum = 0;
    for (int i = 0; i < scores.Length; i++)
    {
        sum += scores[i];
    }
    return sum / scores.Length;
}

// Method c) Get Min and Max using 'out'
static void GetMinMax(int[] scores, out int min, out int max)
{
    // Assume the first score is both the min and the max to start
    min = scores[0];
    max = scores[0];

    // Loop through the rest of the array to find true min/max
    for (int i = 1; i < scores.Length; i++)
    {
        if (scores[i] < min) min = scores[i];
        if (scores[i] > max) max = scores[i];
    }
}



static double Add(double a, double b) => a + b;
static double Subtract(double a, double b) => a - b;
static double Multiply(double a, double b) => a * b;
static double Divide(double a, double b) => a / b;


enum DayOfWeek
{
    Sunday = 1,
    Monday = 2,
    Tuesday = 3,
    Wednesday = 4,
    Thursday = 5,
    Friday = 6,
    Saturday = 0
}
enum Grade { A, B, C, D, F }
