using System;

/// <summary>
/// Represents one word in a scripture and whether its text is currently hidden.
/// </summary>
public class Word
{
    // Store the word's current text.
    private string _text;

    // Track whether the word is hidden.
    private bool _isHidden;

    /// <summary>
    /// Creates a visible word.
    /// </summary>
    /// <param name="text">The original text of the word.</param>
    public Word(string text)
    {
        // Save the original word text.
        _text = text;

        // Start with the word visible.
        _isHidden = false;
    }

    /// <summary>
    /// Replaces the word text with underscores and marks it as hidden.
    /// </summary>
    public void Hide()
    {
        // Start with an empty string for the hidden representation.
        string hiddenWord = "";

        // Replace each original letter with an underscore.
        foreach (char letter in _text)
        {
            // Add one underscore for the current letter.
            hiddenWord += "_";
        }

        // Save the hidden representation as the word's text.
        _text = hiddenWord;

        // Mark the word as hidden.
        _isHidden = true;
    }

    /// <summary>
    /// Writes the current word text to the console.
    /// </summary>
    public void Show()
    {
        // Print the word without a line break.
        Console.Write(_text);
    }

    /// <summary>
    /// Reports whether this word is hidden.
    /// </summary>
    /// <returns>True if the word is hidden; otherwise, false.</returns>
    public bool IsHidden()
    {
        // Return the stored hidden-state flag.
        return _isHidden;
    }

    /// <summary>
    /// Gets the text currently used to display this word.
    /// </summary>
    /// <returns>The original word or a string of underscores if hidden.</returns>
    public string GetDisplayText()
    {
        // Return the current word text.
        return _text;
    }
}