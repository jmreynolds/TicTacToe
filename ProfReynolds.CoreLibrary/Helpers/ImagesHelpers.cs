/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2023
 */

namespace ProfReynolds.CoreLibrary.Helpers;

public static class ImagesHelpers
{
    public static byte[] GetImagesAsByteArray(string imageFilePath)
    {
        var fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
        var binaryReader = new BinaryReader(fileStream);
        return binaryReader.ReadBytes((int)fileStream.Length);
    }

    public static Stream GetImagesAsStream(string imageFilePath) =>
        File.OpenRead(imageFilePath);
}
