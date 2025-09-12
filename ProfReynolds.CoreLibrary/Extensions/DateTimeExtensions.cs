/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-26
 */

namespace ProfReynolds.CoreLibrary;


public static class DateTimeExtensions
{
    /// <summary>
    /// returns the DateTime equivalent of an object, else, the default
    /// </summary>
    /// <param name="content"></param>
    /// <returns>resulting DateTime</returns>
    public static DateTime ToDateTime(this object? content, DateTime defaultValue = default)
    {
        try
        {
            if (content == null) return defaultValue;

            var strContent = content.ToString();

            if (strContent == null) return defaultValue;

            if (strContent.Length > 5 && strContent.Left(1) == "\"")
                strContent = strContent.Substring(1);
            if (strContent.Length > 5 && strContent.Right(1) == "\"")
                strContent = strContent.Left(strContent.Length - 1);

            if (DateTime.TryParse(strContent, out DateTime datetimeResult)) return datetimeResult;

            return defaultValue;
        }
        catch
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// returns the DateTime equivalent of an object, if possible
    /// </summary>
    /// <param name="content"></param>
    /// <returns>resulting DateTime, or null</returns>
    public static DateTime? ToNullableDateTime(this object? content)
    {
        try
        {
            var strContent = content?.ToString();

            if (strContent == null) return null;

            if (strContent.Length > 5 && strContent.Left(1) == "\"")
                strContent = strContent.Substring(1);
            if (strContent.Length > 5 && strContent.Right(1) == "\"")
                strContent = strContent.Left(strContent.Length - 1);

            if (DateTime.TryParse(strContent, out DateTime datetimeResult)) return datetimeResult;

            return null;
        }
        catch
        {
            return null;
        }
    }
}
