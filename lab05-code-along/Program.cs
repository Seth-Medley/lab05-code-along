using System.Runtime.ExceptionServices;

//string[] name= {"Mathew Desjardins", "Sally Fields", "Joe Smith", "Susan Rice"};


static string MakeUserName(string firstName, string lastName) {
    string userName = firstName.ToLower().Trim()[0].ToString();
    userName += lastName.ToLower().Trim();

    return userName;
}