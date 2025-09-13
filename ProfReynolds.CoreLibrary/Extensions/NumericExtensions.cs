/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary;


/// <summary>
/// Various extension methods for boolean manipulation.
/// </summary>
public static class NumericExtensions
{
    /// <summary>
    ///     Safely converts an object into a standard int, or assigns a default value
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <param name="defaultValue">value to return if not convertible</param>
    /// <returns>either the converted value, or the default</returns>
    public static int ToInt(this object? content, int defaultValue = 0)
    {
        try
        {
            if (content == null) return defaultValue;

            if (int.TryParse(content.ToString(), out var intResult)) return intResult;

            if (double.TryParse(content.ToString(), out var dblResult)) return Convert.ToInt32(dblResult);

            return defaultValue;
        }
        catch
        {
            return defaultValue;
        }
    }

    public static int? ToNullableInt(this object? content)
    {
        try
        {
            if (content == null) return null;

            if (int.TryParse(content.ToString(), out var intResult)) return intResult;

            if (double.TryParse(content.ToString(), out var dblResult)) return Convert.ToInt32(dblResult);

            return null;
        }
        catch
        {
            return null;
        }
    }


    /// <summary>
    ///     Safely converts an object into a standard double, or assigns a default value
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <param name="defaultValue">value to return if not convertible</param>
    /// <returns>either the converted value, or the default</returns>
    public static double ToDouble(this object? content, double defaultValue = 0)
    {
        try
        {
            if (content == null) return defaultValue;

            if (double.TryParse(content.ToString(), out var dblResult)) return dblResult;

            return defaultValue;
        }
        catch
        {
            return defaultValue;
        }
    }

    public static double? ToNullableDouble(this object? content)
    {
        try
        {
            if (content == null) return null;

            if (double.TryParse(content.ToString(), out var dblResult)) return dblResult;

            return null;
        }
        catch
        {
            return null;
        }
    }


    /// <summary>
    ///     Safely converts an object into a standard decimal, or assigns a default value
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <param name="defaultValue">value to return if not convertible</param>
    /// <returns>either the converted value, or the default</returns>
    public static decimal ToDecimal(this object? content, decimal defaultValue = 0)
    {
        try
        {
            if (content == null) return defaultValue;

            if (decimal.TryParse(content.ToString(), out var decResult)) return decResult;

            return defaultValue;
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     Safely converts an object into a standard decimal, or assigns a default value
    /// </summary>
    /// <author>Mark Reynolds</author>
    /// <param name="content">extended object variable</param>
    /// <returns>either the converted value, or the default</returns>
    public static decimal? ToNullableDecimal(this object content)
    {
        try
        {
            if (content == null) return null;

            if (decimal.TryParse(content.ToString(), out var decResult)) return decResult;

            return null;
        }
        catch
        {
            return null;
        }
    }
}
