using System.IO;
using System;
using System.Runtime.ExceptionServices;
using System.Diagnostics;

string filePath;
string fileType;
int fileAmount;
string fileText;

//ask user where to create files and set filePath to the answer
Console.WriteLine("Where do you want to create your files? For example: C:\\Users\\Username\\Desktop\\filename  (it is not recommended to create files on your desktop)");
filePath = Console.ReadLine();

//ask user what type of file to create and set fileType to answrt
Console.WriteLine("What type of file do you want to create? For example: .txt");
fileType = Console.ReadLine();

//ask user how many files to create and set fileAmount to answer
Console.WriteLine("How many files do you want to create? For example: 10");
fileAmount = int.Parse(Console.ReadLine());


//ask user what the files say and set fileText to answer
Console.WriteLine("What text should the files Say? For example: Hello World");
fileText = Console.ReadLine();

//create i and run if i < fileAmount. also add 1 to i everytime this runs
for (int i = 0; i < fileAmount; i++)
{
    //paste: "Creating and Writing" + filePath + "\\" + i + fileType + "," + fileText to console
    Console.WriteLine("Creating and Writing " + filePath + "\\" + i + fileType + " , " + fileText);
    //create and write: filePath + "\\" + i + fileType, fileText < Writing that
    File.WriteAllText(filePath + "\\" + i + fileType, fileText);
}

//open explorer.exe at filePath
Process.Start("explorer.exe", filePath);

//sleep 1 second then close
Thread.Sleep(1000);