using System;

/// <summary>
/// Represents a scripture reference and the individual words that make up its text.
/// </summary>
public class Scripture
{
    // Store the scripture's reference.
    private Reference _reference;

    // Store a collection of the scripture's words.
    private List<Word> _words = new List<Word>();

    /// <summary>
    /// Creates a scripture from a reference and a text string.
    /// </summary>
    /// <param name="reference">The reference that identifies the scripture.</param>
    /// <param name="text">The complete scripture text to split into words.</param>
    public Scripture(Reference reference, string text)
    {
        // Split the text into separate words while removing empty entries.
        string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        // Save the supplied scripture reference.
        _reference = reference;

        // Create a Word object for every word in the text.
        foreach (string word in words)
        {
            // Add the new word to the scripture's collection.
            _words.Add(new Word(word));
        }
    }

    /// <summary>
    /// Hides a requested number of visible words selected randomly.
    /// </summary>
    /// <param name="numberToHide">Maximum number of words that should be hidden.</param>
    public void HideRandomWords(int numberToHide)
    {
        // Create a random-number generator.
        Random random = new Random();

        // Repeat once for each word requested for hiding.
        for (int i = 0; i < numberToHide; i++)
        {
            // Select a random position in the word collection.
            int index = random.Next(_words.Count());

            // Hide the word only if it is currently visible.
            if (!_words[index].IsHidden())
            {
                // Replace this word's text with underscores.
                _words[index].Hide();
            }
            else
            {
                // Retry this iteration so the requested count can still be reached.
                numberToHide += 1;
            }
        }
    }

    /// <summary>
    /// Builds the text used to display the reference and scripture.
    /// </summary>
    /// <returns>The reference followed by each word in its current visible or hidden state.</returns>
    public string GetDisplayText()
    {
        // Begin the display text with the scripture reference.
        string displayText = _reference.GetDisplayText() + " ";

        // Append every word to the display text.
        foreach (Word word in _words)
        {
            // Add the word's current display text and a separating space.
            displayText += word.GetDisplayText() + " ";
        }

        // Return the completed scripture display text.
        return displayText;
    }

    /// <summary>
    /// Determines whether every word in the scripture is hidden.
    /// </summary>
    /// <returns>True if every word is hidden; otherwise, false.</returns>
    public bool IsCompletelyHidden()
    {
        // Examine each word in the scripture.
        foreach (Word word in _words)
        {
            // Return false as soon as a visible word is found.
            if (!word.IsHidden())
            {
                return false;
            }
        }

        // Return true because no visible words remain.
        return true;
    }
}