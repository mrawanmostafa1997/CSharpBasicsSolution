// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Xml.Linq;

Console.WriteLine("Session 03");

// Q1 Implicit conversion (no casting needed)
double d = 9.99;
int x = (int)d; // Explicit conversion (casting)
Console.WriteLine(x);
// the value will be truncated, not rounded, so x will be 9, not 10
// Implicit conversion (no casting needed)


// Q2; This code doesn’t compile. Fix it with the smallest change?
int n = 5;
double d2 = (double)n / 2;
Console.WriteLine(d2);


// Q3: You read a number from user input .. Write the correct line to get age as int.

var number = Console.ReadLine();
var age = int.Parse(number); // or int.TryParse for safer parsing
Console.WriteLine($"Your age is: {age}");

//Q4: What happens here and why?
//string s = "12a";
//int x = int.Parse(s); // there an error for explicit conversion, because "12a" is not a valid integer string. It will throw a FormatException at runtime.
//Console.WriteLine(x);


//Q5: Complete the code from the previous question so it prints
//Invalid if conversion into int fails, otherwise prints the number
string s2 = "12a";
if (int.TryParse(s2, out int result))
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid");
}


//Q6: What will this print and explain why ?
object o = 10; // This will print 11. The reason is that the object 'o' is unboxed to an integer before the addition operation.
               // The expression (int)o converts the object back to an integer, which is then added to 1, resulting in 11.
int a = (int)o; // The object 'o' is unboxed to an integer and assigned to variable 'a'
Console.WriteLine(a + 1); // The value of 'a' is 10, so adding 1 results in 11, which is printed to the console.


//Q7: What will this print and explain why and if there is a
//problem handle it ?
//object o2 = 10;
//long x2 = (long)o2;
//Console.WriteLine(x2);
// This code will throw an InvalidCastException at runtime.
// The reason is that the object 'o2' is boxed as an integer (int),
// and you cannot directly cast it to a long (long) without unboxing it first.
// To fix this, you should first unbox it to an int and then convert it to a long:


//Q8: Fix this to avoid exceptions and print -1 if conversion isn’t
//possible?
object o3 = 10;
long x3 = (int)o3;
Console.WriteLine(x3);



//Q9: What will this print and explain why ?
string? name = null;
Console.WriteLine(name?.Length); // This will print nothing (or "null") because the null-conditional operator (?.) is used.
                                 // The expression name?.Length checks if 'name' is null before trying to access the Length property.
                                 // Since 'name' is null, the entire expression evaluates to null, and nothing is printed to the console.
                                 // If you want to print -1 instead of null, you can use the null-coalescing operator (??) like this:


//Q10: What will this print and explain the process?
string? name2 = null;
int length = name2?.Length ?? 0;
// This will print 0. The process is as follows:
// The null-conditional operator (?.) checks if 'name2' is null before trying to access the Length property.
// Since 'name2' is null, the expression name2?.Length evaluates to null.
// The null-coalescing operator (??) then checks if the result of name2?.Length is null, and since it is, it returns the value on the right side of the operator, which is 0.
// Therefore, the variable 'length' is assigned the value 0, and that is what gets printed to the console.


//Q11: What’s wrong with this “safe” code and how can we solve it ?
string? s = null;
int x5 = int.Parse(s ?? "0");
Console.WriteLine(x5);
// The code is actually correct and will not throw an exception.
// The null-coalescing operator (??) is used to provide a default value of "0" if 's' is null.


//Q12: What happens here and if there is a problem, handle it

//string? s = null;
//Console.WriteLine(s!.Length);
// This code will throw a NullReferenceException at runtime.
// The null-forgiving operator (!) is used to suppress the compiler's warning about potential null reference,
// but it does not prevent a runtime exception if 's' is actually null.
// To handle this, you should check if 's' is null before trying to access its Length property:



//Q13: What will this print ?
string? s6 = null;
int x6 = Convert.ToInt32(s6);
Console.WriteLine(x6);
// This will print 0. The Convert.ToInt32 method is designed to handle null values gracefully.
// When 's' is null, Convert.ToInt32 returns 0 instead of throwing an exception.


//Q14: Compare results and explain each result :

//string? s = null;
// A
// int a = int.Parse(s);
// B
//int b = Convert.ToInt32(s);
//Console.WriteLine(b);
// A will throw a FormatException at runtime because int.Parse expects a valid string representation of an integer, and null is not a valid input.
// B will print 0 because Convert.ToInt32 is designed to handle null values and returns 0 when the input is null.


//Q15: Complete the line to print "Guest" when user is null,
//otherwise print the user name in uppercase:

string? user = null;
Console.WriteLine(user?.ToUpper() ?? "Guest");
