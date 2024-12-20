using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.ML.Data;

/// <summary>
/// ImageNetData is the input image data class
///     [ImagePath] is the path to the image
///     [Label] is the name of the file
///     ReadFromFile() is for collections of ImageNetData objects
/// </summary>

namespace DataStructures;

public class ImageNetData
{
    [LoadColumn(0)]
    public string ImagePath;

    [LoadColumn(1)]
    public string Label;

    public static IEnumerable<ImageNetData> ReadFromFile(string imageFolder)
    {
        return Directory
            .GetFiles(imageFolder)
            .Where(filePath => Path.GetExtension(filePath) != ".md")
            .Select(filePath => new ImageNetData { ImagePath = filePath, Label = Path.GetFileName(filePath) });
    }
}


