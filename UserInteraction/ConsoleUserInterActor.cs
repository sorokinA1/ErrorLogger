public class ConsoleUserInterActor : IUserInteractor
{
    public string ReadValidFilePath()
    {
        var fileName = default(string);
        bool isFilePathValid = false;

        do
        {
            Console.Write("Enter the name of file you want to read: ");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("The file name can not be null");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The file name can not be empty");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("The file name does not exist");
            }
            else
            {
                isFilePathValid = true;
            }
        } while (!isFilePathValid);

        return fileName;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }
}