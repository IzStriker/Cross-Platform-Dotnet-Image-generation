using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.SKCharts;
using SkiaSharp;

var cartesianChart = new SKCartesianChart
{
    Width = 900,
    Height = 600,
    Series = new ISeries[]
    {
        new LineSeries<int> { Values = new int[] { 1, 5, 4, 6 } },
        new ColumnSeries<int> { Values = new int[] { 4, 8, 2, 4 } }
    },
    LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
    Background = SKColor.Empty,
    LegendTextPaint = new SolidColorPaint(SKColors.White),
    LegendTextSize = 30,
    XAxes = new Axis[]
    {
        new Axis
        {
            LabelsPaint = new SolidColorPaint(SKColors.White),
        }
    },
    YAxes = new Axis[]
    {
        new Axis
        {
            LabelsPaint = new SolidColorPaint(SKColors.White),
        }
    }
};

// you can save the image to png (by default)
// or use the second argument to specify another format.
cartesianChart.SaveImage("cartesianChart.png");
Console.WriteLine("Images saved at the root folder!");