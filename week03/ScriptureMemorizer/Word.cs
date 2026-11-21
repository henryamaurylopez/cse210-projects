using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        string hiddenWord = "";

        foreach (char letter in _text)
        {
            hiddenWord += "_";
        }
        _text = hiddenWord;
        _isHidden = true;
    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}