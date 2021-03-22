using System;
using Microcharts;
using SkiaSharp;
namespace OfPost.ViewModel
{
    public class UserStatsViewModel
    {
        public Chart DonutChartSample => new DonutChart()
        {
           //User data
           Entries = new[]
           {
               //Views
                new ChartEntry(100)
                {
                    Color = SKColor.Parse("#004369"),
                    TextColor = SKColor.Parse("#FAFAFA"),
                    Label = "Views",
                    ValueLabel = "100%"
                },
                //Like
                new ChartEntry(75)
                {
                    Color = SKColor.Parse("#FAFAFA"),
                    TextColor = SKColor.Parse("#000000"),
                    Label = "Like",
                    ValueLabel = "75%"
                }, 
            },
            //Custom
            LabelTextSize = 45,
            HoleRadius = 0.20f,
        };
    }
}