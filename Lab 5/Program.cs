//string[] = {"Matthew Desjardins", "Sally Fields", "Joe Smith" , "Susan Rice")

System.Console.WriteLine("How many students do you want to enter?");
int numStudents = Convert.ToInt32(System.Console.ReadLine());

string[] names = new string[numStudents];

if(numStudents > 20)
{
   numStudents = 20; 
}


for(int i = 0; i < numStudents; i++)
{
    //the first student to be first
    if(i == 0)
    {
       Console.Write($"Please enter the {i + 1}st students full name; ");
    }
    //the second student to be second
    else if(i == 1)
    {
        Console.Write($"Please enter the {i + 1}nd students full name; ");
    }
    //the third student to be third
    else if(i == 2)
    {
        Console.Write($"Please enter the {i + 1}rd students full name; ");
    }
    //the fourth student to be fourth
    else
    {
        Console.Write($"Please enter the {i + 1}th students full name; ");
    }

    names[i] = Console.ReadLine();
}

string[] userNames = MakeUserNameList(names);
int[] studentID = MakeStudentIDs(names.Length);
int[] studentLockers = MakeStudentLockers(names.Length);

int userChoice;

do{
    DisplayAllStudents(names);
    System.Console.Write("Which student would you like to see more information on? (-1 to exit)");
    userChoice = Convert.ToInt32(Console.ReadLine());

    if(userChoice != -1)
    {
        DisplaySpecificStudentInformation(names, userNames, userChoice);
    }
}while(userChoice != -1);

DisplayAllStudents(names);
System.Console.Write("Which student would you like to see more information on?");
DisplaySpecificStudentInformation(names, userNames, studentID, studentLockers, userChoice);

static void DisplayAllStudents(string[] names)
{
    for(int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine($"{i+1}. {names[i]}");
    }
}

static void DisplayStudentInformation(string[] names, string[] userNames, int[] studentID, int[] studentLockers)
{
    for(int i = 0; i < names.Length; i++)
{
    System.Console.Write(names[i])
}
    {
        System.Console.WriteLine(names[i]);
        System.Console.WriteLine(userNames[i]);
        System.Console.WriteLine(studentID[i]);
        System.Console.WriteLine(studentLockers[i]);
    }
}
static string[] MakeUserNameList(string[] names)
{
    string[] userNames = new string[names.Length];

    for(int i = 0; i < names.Length; i++)
    {
        string[] splitUpName = names[0].Split(' ');
        userNames[i] = MakeUserName(splitUpName[0], splitUpName[1]);
    }

return userNames;

}
static string MakeUserName(string firstName ,string lastName)
{
    string userName = firstName.ToLower().Trim()[0].ToString();
    userName += lastName.ToLower().Trim();

    return userName;
}