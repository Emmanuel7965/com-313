<<<<<<< HEAD
<<<<<<< HEAD
﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {

}

// TODO 3: AppendAllText adds text to an existing file


// TODO 4: A FileStream can be opened and written to until closed


// TODO 2: ReadAllText reads all the content from a file

=======
=======
>>>>>>> decc36c (first commit)
﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
    File.WriteAllText(filename, "This is a text file. ");

}

// TODO 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, "This text gets appended to the file. ");


// TODO 4: A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename)) { 
    sw.WriteLine("Line 1"); 
    sw.WriteLine("Line 2"); 
    sw.WriteLine("Line 3"); 
} 

// TODO 2: ReadAllText reads all the content from a file

<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> decc36c (first commit)
=======
>>>>>>> decc36c (first commit)
=======
string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);
>>>>>>> 7f5cbc7 (dd)
