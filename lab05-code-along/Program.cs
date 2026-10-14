using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;

// string[] names= {"Mathew Desjardins", "Sally Fields", "Joe Smith", "Susan Rice"};
// string userNames = MakeUserNameList(names);

// static string[] MakeUserNameList(string v, string[] names) {

//     string[] userNames = new string[names.Length];

// for(int i = 0; i < names.Length; i++) {
//     string[] splitUpName = names[1].Split(' ');
//     userNames[i] = MakeUserNameList(splitUpName[0], splitUpName[1]);
//     //splitUpName[0] = Mathew
//     //splitUpName[0] = Desjardins
// }}

System.Console.Write("How many students do you want to enter? ");
int numStudents = Convert.ToInt32(Console.ReadLine());

string[] names = new string[numStudents];
if (numStudents > 20)
{
    numStudents = 20;
}

for(int i = 0; i < numStudents; i++)
{
    // The first student to be 1st
     Console.Write($"Please enter the {i} students name: ");

     // The second student to be 2nd

     // The third student to be 3rd

     // The fourth student to be nth
}