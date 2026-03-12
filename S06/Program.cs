using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
//Part1 Q1: Day of the Week
Console.WriteLine("Please input the value between (1-7):");
var day = Console.ReadLine();
Enum.TryParse(day, out DayOfWeek dayOfWeek);
Console.WriteLine($"Day: {dayOfWeek}");

switch (dayOfWeek)
{
    case DayOfWeek.Sunday:
    case DayOfWeek.Monday:
    case DayOfWeek.Tuesday:
    case DayOfWeek.Wednesday:
    case DayOfWeek.Thursday:
        Console.WriteLine("It's a Workday.");
        break;
    case DayOfWeek.Friday:
    case DayOfWeek.Saturday:
        Console.WriteLine("It's the Weekend.");
        break;
    default:
        break;
}




//Part2 Q1: Array Statistics
Console.WriteLine("Please Input the array size:");
var size = Console.ReadLine();
var arrSize = int.Parse(size);
var arr = new double[arrSize];
while (true)
{
    var counter = 0;
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write($"Enter element [{i}]:");
        double element = 0;
        if (double.TryParse(Console.ReadLine(), out element))
        {
            arr[i] = element;
        }
        counter++;

    }
    if (counter == arrSize)
    {
        break;
    }
}
double sum = 0;
double average = 0;
double min = double.MaxValue;
double max = double.MinValue;
var arrReverse = new double[arrSize];
foreach (var item in arr)
{
    sum += item;
    if (item < min)
    {
        min = item;
    }
    if (item > max)
    {
        max = item;
    }
    arrReverse[arrSize - 1 - Array.IndexOf(arr, item)] = item;
}
average = sum / arrSize;
Console.WriteLine($"The Sum Value is: {sum}");
Console.WriteLine($"The Average Value is: {average}");
Console.WriteLine($"The Minimum Value is: {min}");
Console.WriteLine($"The Maximum Value is: {max}");
Console.WriteLine($"Reverse:");
for (int i = 0; i < arrSize; i++)
{
    Console.Write($"{arrReverse[i]},");
}



//Part2 Q2: Student Grades Matrix
int numStudents = 3;
int numSubjects = 4;
int[,] grades = new int[numStudents, numSubjects];
for (int i = 0; i < numStudents; i++)
{
    Console.WriteLine($"\n--- Enter grades for Student {i + 1} ---");
    for (int j = 0;  j < numSubjects;  j++)
    {
        Console.Write($"Subject {j + 1}: ");
        int grade = 0;
        if (int.TryParse(Console.ReadLine(), out grade))
        {
            grades[i, j] = grade;
        }
    }
}

for (int i = 0; i < numStudents; i++)
{
    Console.WriteLine($"\nGrades for Student {i + 1}:");
    var averageValue = 0;

    for (int j = 0; j < numSubjects; j++)
    {
        Console.Write($"{grades[i, j]} ");
        averageValue += grades[i, j];

    }
    Console.WriteLine("Average Grade for Student {0} is: {1}", i + 1, averageValue / numSubjects);

}
foreach (var grade in grades)
{

    Console.Write($"{grade} ");
}


//Part3 Functions Q1: Basci Calculator
static double Add(double a, double b)
{
    return a + b;
}
static double Subtract(double a, double b)
{
    return a - b;
}
static double Multiply(double a, double b)
{
    return a * b;
}
static double Divide(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
        return double.NaN; // Return Not-a-Number to indicate an error
    }
    return a / b;
}
Console.WriteLine("\n=== Basic Calculator (+ - * /) ===");
var operation = Console.ReadLine();
switch (operation)
{
    case "+":
        Console.WriteLine("Enter the first number:");
        var num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        var num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {Add(num1, num2)}");
        break;
        case "-":
            Console.WriteLine("Enter the first number:");
            var num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            var num4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {Subtract(num3, num4)}");
            break;
        case "*":
            Console.WriteLine("Enter the first number:");
            var num5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            var num6 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {Multiply(num5, num6)}");
            break;
        case "/":
            Console.WriteLine("Enter the first number:");
            var num7 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            var num8 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {Divide(num7, num8)}");
            break;
    default:
        Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
        break;
}
Console.WriteLine("\n=== Circle Area and Circumference ===");
Console.WriteLine
    ("Enter the radius of the circle:");    
var radiousStr = Console.ReadLine();
if (double.TryParse(radiousStr, out double radious))
{
    var area = CalculateCircle(radious, out double circumference);
    Console.WriteLine($"\nArea: {area:F2}");
    Console.WriteLine($"Circumference: {circumference:F2}");
}





// minim program for Students 
var arrStudents = new double[5];
for (int i = 0; i < arrStudents.Length; i++)
{
    Console.Write($"Enter the score for Student {i + 1}: ");
    if (double.TryParse(Console.ReadLine(), out double score))
    {
        arrStudents[i] = score;
    }
}
Console.WriteLine("Report");
for (int i = 0; i < arrStudents.Length; i++)
{
    Console.WriteLine($"Student {i + 1}: Score = {arrStudents[i]}, Grade = {GetScore(arrStudents[i])}");
}
Console.WriteLine("Class Average: {0:F2}", CalcAverage(arrStudents));
GetMinMax(arrStudents, out double minScore, out double maxScore);
Console.WriteLine("Class Minimum Score: {0:F2}", minScore);
Console.WriteLine("Class Maximum Score: {0:F2}", maxScore);

static string GetScore(double grade)
{
    if (grade >= 90)
    {
        return Grade.A.ToString();
    }
    else if (grade >= 80)
    {
        return Grade.B.ToString();
    }
    else if (grade >= 70)
    {
        return Grade.C.ToString();
    }
    else if (grade >= 60)
    {
        return Grade.D.ToString();
    }
    else
    {
        return Grade.F.ToString();
    }
}

static double CalcAverage(double[] arrScores)
{
    var sum = 0.0;
    for (int i = 0; i < arrScores.Length; i++)
    {
        sum += arrScores[i];
    }
    return sum / arrScores.Length;
}
static void GetMinMax(double[] arrScores, out double min, out double max)
{
    min = double.MaxValue;
    max = double.MinValue;
    for (int i = 0; i < arrScores.Length; i++)
    {
        if (arrScores[i] < min)
        {
            min = arrScores[i];
        }
        if (arrScores[i] > max)
        {
            max = arrScores[i];
        }
    }
}

static double CalculateCircle(double radious,out double circumference )
{
    var area = Math.PI * radious * radious;
    circumference = 2 * Math.PI * radious;
    return area;
}

public enum DayOfWeek
{
    Sunday = 2,
    Monday = 3,
    Tuesday = 4,
    Wednesday = 5,
    Thursday = 6,
    Friday = 7,
    Saturday = 1
};
public enum Grade
{
    A = 90,
    B = 80,
    C = 70,
    D = 60,
    F = 0
}
