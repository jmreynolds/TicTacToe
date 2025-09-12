/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-26
 */

namespace ProfReynolds.CoreLibrary;

/// <summary>
/// Various extension methods for boolean manipulation.
/// </summary>
public static class BooleanExtensions
{
    /// <summary>
    ///     Safely converts an object into a standard bool, or assigns a default value
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <param name="defaultValue">value to return if not convertible</param>
    /// <returns>either the converted value, or the default</returns>
    public static bool ToBool(this object? content, bool defaultValue = false)
    {
        try
        {
            if (content == null) return defaultValue;

            var conversionSuccessful = (bool.TryParse(content.ToString(), out var boolResult));

            return conversionSuccessful ? boolResult : defaultValue;
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     Safely converts an object into a standard bool, or assigns a null value
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <returns>either the converted value, or the default</returns>
    public static bool? ToNullableBool(this object? content)
    {
        try
        {
            if (content == null) return null;

            if (bool.TryParse(content.ToString(), out bool boolResult)) return boolResult;

            return null;
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    ///     Safely converts an object into a Yes or No
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <param name="defaultValue">value to return if not convertible</param>
    /// <returns>either the converted value, or the default</returns>
    public static string ToYesNo(this object content, string defaultValue = "No")
    {
        try
        {
            if (bool.TryParse(content.ToString(), out bool boolResult))
            {
                return boolResult ? "Yes" : "No";
            }

            return defaultValue;
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     Safely converts an object into a Yes or No
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <returns>either the converted value, or the default</returns>
    public static string? ToNullableYesNo(this object? content)
    {
        try
        {
            if (content == null) return null;

            if (bool.TryParse(content.ToString(), out bool boolResult))
            {
                return boolResult ? "Yes" : "No";
            }

            return null;
        }
        catch
        {
            return null;
        }
    }
}
