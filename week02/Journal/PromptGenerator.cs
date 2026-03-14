using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How did I remember the Savior today?",
        "Who did I help today?",
        "What tender mercy did I experience or witness today?",
        "How did I feel appreciated today?",
        "What was your favorite part of today?",
        "How did I ask for help today?",
        "Is there someone you are especially grateful for today?"
        
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}