<<<<<<< HEAD
<<<<<<< HEAD
﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream


// TODO: Determine if a file exists
=======
=======
>>>>>>> decc36c (first commit)
﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
using (StreamWriter sw = File.CreateText(filename)) { 
sw.WriteLine("This is a text file."); 
}

// TODO: Determine if a file exists
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> decc36c (first commit)
=======
>>>>>>> decc36c (first commit)
=======
Console.WriteLine(File.Exists(filename)); 
if (File.Exists(filename)) { 
// The Delete function deletes a file 
File.Delete(filename); 
} 
else { 
using (StreamWriter sw = File.CreateText(filename)) { 
sw.WriteLine("This is a text file."); 
} 
} 
Console.WriteLine(File.Exists(filename)); 
>>>>>>> 7f5cbc7 (dd)
