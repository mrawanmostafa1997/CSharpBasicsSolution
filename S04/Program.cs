using System;
using System.Diagnostics;
using System.Net.Cache;
using System.Text;


Stopwatch stopwatch = new Stopwatch();
string productlist = "";
stopwatch.Start();
for (int i = 1; i <= 5000; i++)
{
    productlist += $"Product {i}\n";
}
stopwatch.Stop();
//(a)Explain why this code is inefficient.Reference what happens in memory.
// for every iteration of the loop, a new string is created in memory to hold the concatenated result of the previous string and the new product string.
// This is because strings in C# are immutable,
// meaning that once a string is created, it cannot be changed.
// Therefore, each time we concatenate a new product string to the existing productlist,
// a new string object is created in memory, and the old one is discarded.
// This leads to increased memory usage and can significantly degrade performance,
// especially as the number of iterations increases.



//(b) Rewrite this code using StringBuilder to be more efficient.
// The StringBuilder class is designed

Stopwatch stopwatchOptimized = new Stopwatch();
StringBuilder newProductList = new StringBuilder();
stopwatchOptimized.Start();
for (int i = 1; i <= 5000; i++)
{
    newProductList.Append($"Product {i}\n");
}
stopwatchOptimized.Stop();



//(c) Add timing code (using Stopwatch) to both versions and report the time difference.

Console.WriteLine($"Time taken for string concatenation: {stopwatch.Elapsed.TotalMicroseconds} ms");
Console.WriteLine($"Time taken for StringBuilder: {stopwatchOptimized.Elapsed.TotalMicroseconds} ms");
//Time taken for string concatenation: 38488.2 ms
//Time taken for StringBuilder: 464.5 ms
// this mean the string builder save 82 times 






//Question 02: Ticket Pricing System 

Console.WriteLine("Please input your age:");
var age = int.Parse(Console.ReadLine());
double ticketPrice = 0.0;

if (age < 5)
{
    ticketPrice = 0;
}
else if (age >= 5 && age <= 12)
{

    ticketPrice = 30;
}
else if (age >= 13 &&  age <= 59)
{
    ticketPrice = 50;
}
else
{
    ticketPrice = 25;
}
Console.WriteLine("Please input your day from 1-7 as 6 friday and 7 saturday.");
var weekend = int.Parse(Console.ReadLine());

Console.WriteLine("Please input your if you have Id by yes or no.");

string hasId = Console.ReadLine();

if (weekend == 6 || weekend == 7)
{
    if (age < 5)
    {
        ticketPrice += 10;
    }
}
else
{
    if (hasId == "yes")
    {
        double discount = ticketPrice * 0.2;
        ticketPrice -= discount;
    }
    else if (hasId != "no")
    {
        Console.WriteLine("Invalid input for ID possession.");
    }
    
}
Console.WriteLine($"your ticket price is {ticketPrice}LE");




// Quesiton 3
// a by traditional way using switch statement
string fileExtension = ".pdf";
string fileType;
switch (fileExtension)
{
    
    case ".pdf":
        fileType = "PDF Document";
        break;
    case ".docx":
    case ".doc":
        fileType = "Word Document";
        break;
    case ".xlsx":
    case ".xls":
        fileType = "Excel Spreadsheet";
        break;
    case ".jpg":
    case ".jpeg":
    case ".gif":
    case ".png":
        fileType = "Image file";
        break;
    default:
        fileType = "Unknown file type";
        break;
}
Console.WriteLine($"The file type is: {fileType}");
//b better way using switch expression
fileType = fileExtension switch
{
    ".pdf" => "PDF Document",
    ".docx" or ".doc" => "Word Document",
    ".xlsx" or ".xls" => "Excel Spreadsheet",
    ".jpg" or ".jpeg" or ".gif" or ".png" => "Image file",
    _ => "Unknown file type"
};
//Is the ternary version more readable? When would you choose one over the other?

// The ternary version can be more concise and readable for simple conditions, especially when there are only a few cases to consider.
// However, for more complex scenarios with multiple conditions or when the logic is not straightforward, a switch statement or switch expression may be more appropriate for better readability and maintainability.
// I would choose the ternary operator for simple, straightforward conditions and the switch statement/expression for more complex logic that involves multiple cases.


int temperature = 35;
var weatherAdvice = temperature<0 ? "Freezing! stay indoors":
    temperature < 15 ? "Cold! wear a jacket":
    temperature < 25 ? "Pleasant the weather":
    temperature < 35 ? "Warm! stay hydrated":
    "Hot! avoid sun exposure";



//Question 05 : Input Validation with Loops
bool isValidInput = false;
bool hasOneUppercase = false;
bool has8Chars = false;
bool hasOneDigit = false;
bool hasSpace = false;
string password = "";
do
{


    password = Console.ReadLine();
    if (password.Length >= 8)
    {
        has8Chars = true;
    }
    
    foreach (var passChar in password)
    {
        if (passChar == ' ')
        {
            hasSpace = true;
            break;
        }
        if (char.IsUpper(passChar))
        {
            hasOneUppercase = true;
        }
        if (char.IsDigit(passChar))
        {
            hasOneDigit = true;
        }
        
    }
    isValidInput = hasOneUppercase && has8Chars && hasOneDigit && !hasSpace;
    if (!isValidInput)
    {
        Console.WriteLine("Please try again.");
    }


}
while (!isValidInput);

Console.WriteLine($"Your {password} Password is valid!");
