/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary.Helpers;

public static class StringHelpers
{
    public static string ConcatenateFullName(string? firstName, string? lastName)
    {
        var result = string.Empty;
        if (!firstName.IsNullOrEmpty() && !lastName.IsNullOrEmpty())
            result = firstName + " " + lastName;
        else if (firstName.IsNullOrEmpty())
            result = lastName!;
        else if (lastName.IsNullOrEmpty())
            result = firstName!;
        return result;
    }
}