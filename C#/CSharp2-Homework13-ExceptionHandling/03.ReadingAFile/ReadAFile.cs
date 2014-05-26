// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

//http://msdn.microsoft.com/en-us/library/ms143368.aspx

using System;
using System.IO;
using System.Security;

class ReadAFile
{
    static void Main()
    {
        //Input
        Console.Write("Enter the full path of the file you want to read: ");
        string filePath = Console.ReadLine();

        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(fileContent);
        }

        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception: {0}", ex.Message);
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory in the file path cannot be found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine("Exception: {0}", ioe.Message);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }

        catch (SecurityException) // System.Security.SecurityException
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }
        catch (UnauthorizedAccessException uaex)
        {
            Console.WriteLine("Exception: {0}", uaex.Message);
        }
    }
}
