using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
// _prompts is a list of prompts
// GetRandomPrompt returns a single random prompt from the _prompts list

{
    public List<string> _prompts = new List<string>() 
        {
            "How did you show love to someone else today? ",
            "When did you feel appriciated today? ",
            "Was there anyone in your day that needed help? ",
            "How were your prayers answered? ",
            "Did you cry or laugh today? Why? ",
            "Did you have an ay ha moment? ",
            "Was there a moment where you felt the hand of the Lord? "
        };

    public string prompt = ""; 
    Random rand = new System.Random();
    
    
    public string GetRandomPrompt()
    // https://stackoverflow.com/questions/19318430/c-sharp-select-random-element-from-list
    // 

    {
        while (_prompts.Count > 0)
            {
                int index = rand.Next(0, _prompts.Count);
                prompt = _prompts[index];
                _prompts.RemoveAt(index);
            }
            
        return prompt;
    }
}