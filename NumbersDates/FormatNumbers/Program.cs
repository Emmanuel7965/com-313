<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting numerical data in .NET

int[] quarters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)


// TODO: Add a number after the format to specify precision


// TODO: Formatting with alignment and spacing
// Console.WriteLine("Sales by Quarter:");
// Console.WriteLine($"{quarters[0]} {quarters[1]} {quarters[2]} {quarters[3]}");
// Console.WriteLine($"{sales[0]} {sales[1]} {sales[2]} {sales[3]}");
// Console.WriteLine("International Sales:");
// Console.WriteLine($"{intlMixPct[0]} {intlMixPct[1]} {intlMixPct[2]} {intlMixPct[3]}");
=======
=======
>>>>>>> decc36c (first commit)
﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
=======
﻿
// Application Programming .NET Programming with C# by Abdullahi Tijjani
>>>>>>> 9fce8a0 (number)
// Example file for formatting numerical data in .NET

int[] quarters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;



// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");

// TODO: Add a number after the format to specify precision
Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G3}");

// TODO: Formatting with alignment and spacing
<<<<<<< HEAD
// Console.WriteLine("Sales by Quarter:");
// Console.WriteLine($"{quarters[0]} {quarters[1]} {quarters[2]} {quarters[3]}");
// Console.WriteLine($"{sales[0]} {sales[1]} {sales[2]} {sales[3]}");
// Console.WriteLine("International Sales:");
// Console.WriteLine($"{intlMixPct[0]} {intlMixPct[1]} {intlMixPct[2]} {intlMixPct[3]}");
<<<<<<< HEAD
>>>>>>> decc36c (first commit)
=======
>>>>>>> decc36c (first commit)
=======
 Console.WriteLine("Sales by Quarter:");
 Console.WriteLine($"{quarters[0]} {quarters[1]} {quarters[2]} {quarters[3]}");
 Console.WriteLine($"{sales[0]} {sales[1]} {sales[2]} {sales[3]}");
 Console.WriteLine("International Sales:");
 Console.WriteLine($"{intlMixPct[0]} {intlMixPct[1]} {intlMixPct[2]} {intlMixPct[3]}");






>>>>>>> 9fce8a0 (number)
