using System;
using System.IO;

class DirectoryFileLister
{
    static void Main()
    {
        Console.WriteLine("Enter the full path of the directory:");
        string directoryPath = Console.ReadLine();

        if (Directory.Exists(directoryPath))
        {
            Console.WriteLine($"\nFiles in '{directoryPath}':\n");

            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
        else
        {
            Console.WriteLine("The specified directory does not exist.");
        }
    }
}

