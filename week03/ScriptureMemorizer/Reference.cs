using System;
using System.Diagnostics.Tracing;

/// <summary>
/// Represents the location of a scripture, including the book, chapter, and verse range.
/// </summary>
public class Reference
{
    // Store the name of the scripture's book.
    private string _book;

    // Store the chapter number.
    private int _chapter;

    // Store the starting verse number.
    private int _verse;

    // Store the ending verse number, or zero for a single verse.
    private int _endVerse;

    /// <summary>
    /// Creates a reference for one verse.
    /// </summary>
    /// <param name="book">Name of the book containing the scripture.</param>
    /// <param name="chapter">Chapter number containing the verse.</param>
    /// <param name="verse">Starting verse number.</param>
    public Reference(string book, int chapter, int verse)
    {
        // Save the book name.
        _book = book;

        // Save the chapter number.
        _chapter = chapter;

        // Save the verse number.
        _verse = verse;

        // Mark this reference as not having an ending verse.
        _endVerse = 0;
    }

    /// <summary>
    /// Creates a reference for a range of verses.
    /// </summary>
    /// <param name="book">Name of the book containing the scripture.</param>
    /// <param name="chapter">Chapter number containing the verses.</param>
    /// <param name="verse">Starting verse number.</param>
    /// <param name="endVerse">Ending verse number.</param>
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        // Save the book name.
        _book = book;

        // Save the chapter number.
        _chapter = chapter;

        // Save the starting verse number.
        _verse = verse;

        // Save the ending verse number.
        _endVerse = endVerse;
    }

    /// <summary>
    /// Formats the reference as display text.
    /// </summary>
    /// <returns>The reference for a verse range or for a single verse.</returns>
    public string GetDisplayText()
    {
        // Build the text used when an ending verse is present.
        string withEndVerse = $"'{_book} {_chapter}:{_verse}-{_endVerse}' ";

        // Build the text used for a single verse.
        string noEndVerse = $"'{_book} {_chapter}:{_verse}' ";

        // Check whether this reference contains only one verse.
        if (_endVerse == 0)
        {
            // Return the single-verse format.
            return noEndVerse;
        }
        else
        {
            // Return the verse-range format.
            return withEndVerse;
        }
    }
}