/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary;


/// <summary>
/// Various extension methods for string manipulation.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// string extension used to perform string.IsNullOrWhiteSpace(...) equivalent
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static bool IsNullOrWhiteSpace(this string? content)
    {
        return string.IsNullOrWhiteSpace(content);
    }

    /// <summary>
    /// string extension used to perform string.IsNullOrEmpty(...) equivalent
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static bool IsNullOrEmpty(this string? content)
    {
        return string.IsNullOrEmpty(content);
    }

    public static string Left(this string? content, int numCharacters)
    {
        if (content == null) return string.Empty;

        if (content.Length < numCharacters) return content;

        return content[..numCharacters];
    }

    public static string Right(this string? content, int numCharacters)
    {
        if (content == null) return string.Empty;

        if (content.Length < numCharacters) return content;

        return content[^numCharacters..];
    }
}
