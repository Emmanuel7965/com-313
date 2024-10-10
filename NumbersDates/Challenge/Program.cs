using System.Globalization;

while (true) { 
llk
Console.WriteLine("Enter Date (MM/DD/YYYY)  ");
Console.WriteLine("Enter 'exit' to quit code ");

string userinput = Console.ReadLine();

if(userinput == "exit"){
    break;
}

DateTime b;
 if(DateTime.TryParse(userinput, out b)){
    DateTime curdate = DateTime.Now;
    TimeSpan dateDifference = b - curdate;
    if(dateDifference.TotalDays > 0 ){
        Console.WriteLine($"There are {Math.Ceiling(dateDifference.TotalDays)} days remaining till we reach {b}.");
    }
    else if(dateDifference.TotalDays < 0 ){
        Console.WriteLine($" There are {Math.Abs(Math.Floor(dateDifference.TotalDays)) } days until we reach {curdate}.");

    }

 }
}