using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        string[] words = text.Split("", StringSplitOptions.RemoveEmptyEntries);

        _reference = reference;
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count());
            _words[index].Hide();
            _words[index].IsHidden();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + "";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}