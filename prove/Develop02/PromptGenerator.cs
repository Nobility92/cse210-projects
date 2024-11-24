public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
         "Who was the most interesting person I interacted with today?",
         "What was the best part of my day",
         "How did I see the hand of the Lord in my life today?",
         "What was the strongest emotion I felt today?",
         "What did you achieve today?",
         "What would you love to do tomorrow?",
         "Who inspired me today?",
         "What positive impact did i made in someone's life today?",

         
   };
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}