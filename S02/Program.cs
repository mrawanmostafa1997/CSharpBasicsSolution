Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
Console.WriteLine("║                      20 Questions                                  ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



#region Question 1: Regions
// ══════════════════════════════════════════════════════════════════════
// QUESTION 2: REGIONS
// ══════════════════════════════════════════════════════════════════════
//
// Q: What is the purpose of #region and #endregion directives in C#? 
//    How do they help in code organization?
//
// ══════════════════════════════════════════════════════════════════════

//Nested Region Example
//it helps to organize code into collapsible sections in VS, making it easier to navigate large files
#region Nested Region Example
Console.WriteLine("\n" + new string('-', 70) + "\n");
#endregion

#region Question 2: Variable Declaration - Explicit vs Implicit
// ══════════════════════════════════════════════════════════════════════
// QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
// ══════════════════════════════════════════════════════════════════════
//
// Q: What is the difference between explicit and implicit variable 
//    declaration in C#? Provide examples of both.
//
// ══════════════════════════════════════════════════════════════════════



// EXPLICIT DECLARATION 
// Explicit declaration requires specifying the data type of the variable at the time of declaration.
// Example: string name = "Marwan"; // Explicitly declaring a string variable

// IMPLICIT DECLARATION 
// Implicit declaration uses the 'var' keyword, allowing the compiler to infer the data type based on the assigned value.
// Example: var age = 29; // Implicitly declaring an integer variable
#endregion

#region Question 3: Constants
// ══════════════════════════════════════════════════════════════════════
// QUESTION 4: CONSTANTS
// ══════════════════════════════════════════════════════════════════════
//
// Q: Write the syntax for declaring a constant in C#. Why would you use 
//    a constant instead of a regular variable?
//
// ══════════════════════════════════════════════════════════════════════



// Constant examples
// A constant is declared using the 'const' keyword and must be initialized at the time of declaration.
// Example: const double Pi = 3.14159; // Declaring a constant for Pi
// Constants are used when you have a value that should not change throughout the program, providing safety and clarity.
#endregion

#region Question 4: Class-level vs Method-level Scope
// ══════════════════════════════════════════════════════════════════════
// QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
// ══════════════════════════════════════════════════════════════════════
//
// Q: Explain the difference between class-level scope and method-level 
//    scope with examples.
//
// ══════════════════════════════════════════════════════════════════════
// Class-level scope refers to variables that are declared within a class but outside
// of any method. These variables are accessible to all methods within the class.
// Example: static int classField = 100; // This variable has class-level scope


// Method-level scope refers to variables that are declared within a method. These variables are only accessible within that method.
// Example:
// void ExampleMethod() {
//     int methodVariable = 50; // This variable has method-level scope
//     Console.WriteLine(methodVariable); // Accessible here
// }

#endregion

#region Question 5: Block-level Scope
// ══════════════════════════════════════════════════════════════════════
// QUESTION 5: BLOCK-LEVEL SCOPE
// ══════════════════════════════════════════════════════════════════════
//
// Q: What is block-level scope? Give an example showing a variable that 
//    is only accessible within a specific block.
//
// ══════════════════════════════════════════════════════════════════════
// Block-level scope refers to variables that are declared within a specific block of code, such as within an if statement, loop, or any set of curly braces. These variables are only accessible within that block.
// Example:
// if (true) {
//     int blockVariable = 10; // This variable has block-level scope
//     Console.WriteLine(blockVariable); // Accessible here
// }
#endregion

#region Question 6: Variable Lifetime - Local vs Static
// ══════════════════════════════════════════════════════════════════════
// QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
// ══════════════════════════════════════════════════════════════════════
//
// Q: What is variable lifetime? Explain the lifetime of local variables 
//    vs static variables.
//
// ══════════════════════════════════════════════════════════════════════

// Variable lifetime refers to the duration for which a variable exists in memory during the execution of a program.
// Local variables are created when a method is called and destroyed when the method exits. They only exist during the execution of that method.
// Static variables, on the other hand, are associated with the class rather than any instance. They are created when the class is first loaded and exist for the entire duration of the program.

#endregion

#region Question 7: Garbage Collector
// ══════════════════════════════════════════════════════════════════════
// QUESTION 7: GARBAGE COLLECTOR
// ══════════════════════════════════════════════════════════════════════
//
// Q: What is the Garbage Collector in C#? How does it affect the 
//    lifetime of objects?
//
// ══════════════════════════════════════════════════════════════════════
// The Garbage Collector (GC) in C# is an automatic memory management system that handles the allocation and deallocation of memory for objects.
// It periodically checks for objects that are no longer referenced by the program and frees up the memory they occupy.
// This means that the lifetime of objects is not determined by the programmer but by the GC, which can lead to more efficient memory usage and reduced chances of memory leaks.

#endregion

#region Question 8: Variable Shadowing
// ══════════════════════════════════════════════════════════════════════
// QUESTION 8: VARIABLE SHADOWING
// ══════════════════════════════════════════════════════════════════════
//
// Q: What is variable shadowing in C#? Does C# allow shadowing in 
//    nested blocks within the same method?
//
// ══════════════════════════════════════════════════════════════════════
// Variable shadowing occurs when a variable declared within a certain scope (e.g., a method or block) has the same name as a variable declared in an outer scope.
// The inner variable "shadows" the outer variable, making it inaccessible within the inner scope.
#endregion

#region Question 9: C# Naming Rules
// ══════════════════════════════════════════════════════════════════════
// QUESTION 9: C# NAMING RULES
// ══════════════════════════════════════════════════════════════════════
//
// Q: List five rules that must be followed when naming variables in C#.
//
// ══════════════════════════════════════════════════════════════════════
// 1. Variable names must start with a letter or an underscore (_).
// 2. Variable names cannot start with a number.
// 3. Variable names can only contain letters, digits, and underscores.
// 4. Variable names cannot be the same as C# reserved keywords (e.g., int, class, etc.).
// 5. Variable names are case-sensitive (e.g., 'myVariable' and 'MyVariable' are different).

#endregion

#region Question 10: Naming Conventions
// ══════════════════════════════════════════════════════════════════════
// QUESTION 10: NAMING CONVENTIONS
// ══════════════════════════════════════════════════════════════════════
//
// Q: What naming conventions are recommended for: (a) local variables, 
//    (b) class names, (c) constants?
//
// ══════════════════════════════════════════════════════════════════════
// a) Local variables: camelCase (e.g., myVariable)
// b) Class names: PascalCase (e.g., MyClass)
// c) Constants: UPPERCASE with underscores (e.g., MAX_VALUE)
#endregion

#region Question 11: Error Types
// ══════════════════════════════════════════════════════════════════════
// QUESTION 11: ERROR TYPES
// ══════════════════════════════════════════════════════════════════════
//
// Q: Compare and contrast syntax errors, runtime errors, and logical 
//    errors. Provide an example of each.
//
// ══════════════════════════════════════════════════════════════════════
// Syntax errors occur when the code violates the rules of the C# language, such as missing semicolons or mismatched parentheses.
// These errors are caught by the compiler before the program runs.
// Runtime errors occur during the execution of the program, such as dividing by zero or accessing an array out of bounds.
// These errors can cause the program to crash if not handled properly.
// Logical errors occur when the code runs without crashing but produces incorrect results due to a flaw in the logic of the program, such as using the wrong operator or incorrect conditions in an if statement.
// Example of syntax error: int x = 10 // Missing semicolon
// Example of runtime error: int y = 10 / 0; // Division by zero
// Example of logical error: int sum = 5 + 5; // Intended to calculate product but used addition instead
#endregion

#region Question 12: Exception Handling Importance
// ══════════════════════════════════════════════════════════════════════
// QUESTION 12: EXCEPTION HANDLING IMPORTANCE
// ══════════════════════════════════════════════════════════════════════
//
// Q: Why is exception handling important in C#? What would happen if 
//    you don't handle exceptions?
//
// ══════════════════════════════════════════════════════════════════════
// Exception handling is important in C# because it allows developers to manage and respond to runtime errors gracefully, preventing the application from crashing and providing a better user experience.
// If exceptions are not handled, the program will terminate abruptly when an error occurs, which can lead to data loss, a poor user experience, and potential security vulnerabilities.

#endregion

#region Question 13: try-catch-finally
// ══════════════════════════════════════════════════════════════════════
// QUESTION 13: TRY-CATCH-FINALLY
// ══════════════════════════════════════════════════════════════════════
//
// Q: Write a code example demonstrating try-catch-finally. Explain when 
//    the finally block executes.
//
// ══════════════════════════════════════════════════════════════════════
try
{
    //var x = 10 / 0;
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
    throw;
}
finally
{
    Console.WriteLine("This block executes regardless of whether an exception was thrown or caught.");
}
#endregion

#region Question 14: Common Built-in Exceptions
// ══════════════════════════════════════════════════════════════════════
// QUESTION 14: COMMON BUILT-IN EXCEPTIONS
// ══════════════════════════════════════════════════════════════════════
//
// Q: List and explain five common built-in exceptions in C# with 
//    scenarios when each would occur.
//
// ══════════════════════════════════════════════════════════════════════
// 1. NullReferenceException: Occurs when you try to access a member on a null object reference. Example: string str = null; Console.WriteLine(str.Length);
// 2. IndexOutOfRangeException: Occurs when you try to access an index that is outside the bounds of an array or collection. Example: int[] arr = new int[5]; Console.WriteLine(arr[10]);
// 3. DivideByZeroException: Occurs when you attempt to divide an integer by zero. Example: int result = 10 / 0;
// 4. FormatException: Occurs when a string is not in the correct format for parsing. Example: int number = int.Parse("abc");
// 5. InvalidOperationException: Occurs when a method call is invalid for the object's current state. Example: var enumerator = new List<int>().GetEnumerator(); enumerator.MoveNext(); enumerator.Current; 
// Accessing Current without MoveNext() will throw this exception
#endregion

#region Question 15: Multiple catch Blocks
// ══════════════════════════════════════════════════════════════════════
// QUESTION 15: MULTIPLE CATCH BLOCKS
// ══════════════════════════════════════════════════════════════════════
//
// Q: Why is the order of catch blocks important when handling multiple 
//    exceptions? Write code showing correct ordering.
//
// ══════════════════════════════════════════════════════════════════════
// The order of catch blocks is important because C# checks them from top to bottom.
// If a more general exception type (like Exception) is placed before a more specific exception type (like NullReferenceException),
// the specific catch block will never be reached, and the general catch block will handle all exceptions, including those that could have been handled by the specific catch block.
try
{
    // Code that may throw exceptions
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Null reference error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"General error: {ex.Message}");
}
#endregion

#region Question 16: throw Keyword
// ══════════════════════════════════════════════════════════════════════
// QUESTION 16: THROW KEYWORD
// ══════════════════════════════════════════════════════════════════════
//
// Q: What is the difference between 'throw' and 'throw ex' when 
//    re-throwing an exception? Which one preserves the stack trace?
//
// ══════════════════════════════════════════════════════════════════════
// 'throw' re-throws the current exception while preserving the original stack trace, which is crucial for debugging.
// 'throw ex' creates a new exception instance and resets the stack trace to the point where 'throw ex' is called, which can make it harder to trace the original source of the error.

#endregion

#region Question 17: Stack and Heap Memory
// ══════════════════════════════════════════════════════════════════════
// QUESTION 17: STACK AND HEAP MEMORY
// ══════════════════════════════════════════════════════════════════════
//
// Q: Explain the differences between Stack and Heap memory in C#. 
//    What types of data are stored in each?
//
// ══════════════════════════════════════════════════════════════════════
// Stack memory is used for storing value types (e.g., int, double, struct) and reference type references (e.g., class instances).
// It is a last-in-first-out (LIFO) data structure that is automatically managed by the runtime.
// Heap memory is used for storing reference type objects (e.g., class instances). It is a larger pool of memory that is managed by the Garbage Collector.
#endregion

#region Question 18: Value Types vs Reference Types
// ══════════════════════════════════════════════════════════════════════
// QUESTION 18: VALUE TYPES VS REFERENCE TYPES
// ══════════════════════════════════════════════════════════════════════
//
// Q: Write a code example showing how value types and reference types 
//    behave differently when assigned to another variable.
//
// ══════════════════════════════════════════════════════════════════════
// Value type example
int a = 10; // 'a' is a value type
int b = a; // 'b' is assigned the value of 'a', creating a copy
b = 20; // Changing 'b' does not affect 'a'
Console.WriteLine(
    $"Value Types: a = {a}, b = {b}"); // Output: a = 10, b = 20
Console.WriteLine(
    $"Reference Types:");
// Output: Reference Types:
//// Reference type example
//MyClass obj1 = new MyClass { Value = 10 }; // 'obj1' is a reference type
//MyClass obj2 = obj1; // 'obj2' is assigned the reference of 'obj1', not a copy
//obj2.Value = 20; // Changing 'obj2' affects 'obj1' because they reference the same object
//Console.WriteLine(
//    $"obj1.Value = {obj1.Value}, obj2.Value = {obj2.Value}"); // Output: obj1.Value = 20, obj2.Value = 20

#endregion

#region Question 19: Object in C#
// ══════════════════════════════════════════════════════════════════════
// QUESTION 19: OBJECT IN C#
// ══════════════════════════════════════════════════════════════════════
//
// Q: Why is 'object' considered the base type of all types in C#? 
//    What methods does every type inherit from System.Object?
//
// ══════════════════════════════════════════════════════════════════════
// 'object' is considered the base type of all types in C# because every type, whether it is a value type or a reference type, ultimately derives from System.Object.
// This means that all types inherit the methods defined in System.Object, such as:
// - ToString(): Returns a string representation of the object.
// - Equals(object obj): Determines whether the specified object is equal to the current object.
// - GetHashCode(): Serves as the default hash function.
// - GetType(): Gets the Type of the current instance.

#endregion

#endregion