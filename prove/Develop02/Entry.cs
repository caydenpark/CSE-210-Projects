using System;
//Prompts user
class Entry
{
    // List of prompts.
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day? ", 
        "What was the weirdest part of your day? ", 
        "Which side of the bed did you wake up on today? ", 
        "Did you have any regrets today? ", 
        "Would you call today a good day? "
    };

    public string prompt = string.Empty;
    public string date = string.Empty;
    public string text = string.Empty;
    public string entryText = string.Empty;

    public Entry()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        prompt = _prompts[randomIndex];
    }

    public void DisplayPrompts()
    {
        // List of prompts.
        List<string> prompts = new List<string>
        {"What was the best part of your day? ", 
        "What was the weirdest part of your day? ", 
        "Which side of the bed did you wake up on today? ", 
        "Did you have any regrets today? ", 
        "Would you call today a good day? "};
    
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        // Convert int to string for the loop to work better.
        string randomPrompt = prompts[randomIndex];
    }

    public void DisplayEntry()
    {
        if (entryText == string.Empty)
        {
            entryText = $"Date: {date} - Prompt: {prompt}\n{text}\n";
        }
        Console.WriteLine(entryText);
    }
}