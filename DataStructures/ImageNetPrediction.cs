using Microsoft.ML.Data;

namespace DataStructures;

public class ImageNetPrediction
{
    /// <summary>
    /// Prediction results class. Model returns a flat tensor as a float[]
    ///     Contains the dimensions, objectness score, and class probabilities for each of the bounding boxes
    /// </summary>
    [ColumnName("grid")]
    public float[] PredictedLabels;
}