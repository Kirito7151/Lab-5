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

foreach(string n in names);


string[] userNames = MakeUserNameList(names);


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