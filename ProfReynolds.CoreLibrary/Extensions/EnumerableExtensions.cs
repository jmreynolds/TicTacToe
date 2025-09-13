/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-26
 */

namespace ProfReynolds.CoreLibrary;

/// <summary>
/// Various extension methods for IEnumerable manipulation.
/// </summary>
public static class EnumerableExtensions
{
    /// <summary>
    /// evaluates whether an IEnumerable contains elements
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <returns></returns>
    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? collection)
    {
        return collection == null || !collection.Any();
    }
}