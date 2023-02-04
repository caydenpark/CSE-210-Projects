using System;
//Save and Load entries into the file that the user gives
class Journal
{
    public List<Entry> entriesList = new List<Entry>();
    public void Load()
    {
        Console.WriteLine("What is the name of the file that you would like to load? ");
        string fileName = Console.ReadLine();

        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, $"{fileName}.txt");
        Console.Write(filePath);

        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");

        for (int i = 0; i < lines.Length; i += 3)
        {
            Entry entry = new Entry();   
            entry.entryText = $"{lines[i]}\n{lines[i + 1]}\n";   
            entriesList.Add(entry);
        }
    }

    public void Save()
    {
        Console.Write("What is the file name you would like to save under? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
        {
            foreach (Entry entry in entriesList)
            {
                outputFile.WriteLine(entry.entryText);
            }
        }
    }
}