using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
////////////////////////////////////////////////////////////////
/// PART 1: Name Array
/// //////////////////////////////////
string[] names1= {"Mathew Desjardins", "Sally Fields", "Joe Smith", "Susan Rice"};
string userNames = MakeUserNameList(names1);

 static string[] MakeUserNameList(string v, string[] names) {

    string[] userNames = new string[names.Length];

for(int i = 0; i < names.Length; i++) {
    string[] splitUpName = names[1].Split(' ');
    userNames[i] = MakeUserNameList(splitUpName[0], splitUpName[1]);
}}
////////////////////////////////////////////////////////////////
/// PART 2: Nesting IF Loops
/// //////////////////////////////////
/// 
System.Console.Write("How many students do you want to enter? ");
int numStudents = Convert.ToInt32(Console.ReadLine());

if (numStudents > 20)
{
    numStudents = 20;
}

string[] names = new string[numStudents];

for(int i = 0; i < numStudents; i++)
{
    // The first student to be 1st
    if (i == 0) {
     Console.Write($"Please enter the {i+1} students full name: ");
    }
     // The second student to be 2nd
        else if (i==1) {
        Console.Write($"Please enter the {i+1}nd students full name: ");
    }
     // The third student to be 3rd
         else if (i==2) {
        Console.Write($"Please enter the {i+1}rd students full name: ");
    }
     // The fourth student to be nth
         else {
        Console.Write($"Please enter the {i+1}nd students full name: ");
    }

    names[i] = Console.ReadLine();
}

string[] userNames = MakeUserNamesList(names);
int[] studentId = MakeStudentIds(names.Length);
int[] studentLocker = MakeStudentLocker();

for(int i = 0; i < names.Length, i++)
{
    
}