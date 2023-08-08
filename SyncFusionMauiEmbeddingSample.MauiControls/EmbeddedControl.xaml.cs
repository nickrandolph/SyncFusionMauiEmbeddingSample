using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SyncFusionMauiEmbeddingSample.MauiControls;

public partial class EmbeddedControl : ContentView
{
	public EmbeddedControl()
	{
		InitializeComponent();

        this.BindingContext = new LineSeriesViewModel();
	}
}


public class LineSeriesViewModel : ObservableObject
{
    public ObservableCollection<ChartDataModel> LineData1 { get; set; }

    public ObservableCollection<ChartDataModel> LineData2 { get; set; }

    public ObservableCollection<ChartDataModel> DashedLine { get; set; }

    public LineSeriesViewModel()
    {

        LineData1 = new ObservableCollection<ChartDataModel>
        {
            new ChartDataModel("2005", 21),
            new ChartDataModel("2006", 24),
            new ChartDataModel("2007", 36),
            new ChartDataModel("2008", 38),
            new ChartDataModel("2009", 54),
            new ChartDataModel("2010", 57),
            new ChartDataModel("2011", 70)
        };

        LineData2 = new ObservableCollection<ChartDataModel>
        {
            new ChartDataModel("2005", 28),
            new ChartDataModel("2006", 44),
            new ChartDataModel("2007", 48),
            new ChartDataModel("2008", 50),
            new ChartDataModel("2009", 66),
            new ChartDataModel("2010", 78),
            new ChartDataModel("2011", 84)
        };

        DashedLine = new ObservableCollection<ChartDataModel>()
        {
            new ChartDataModel(2010, 6.6, 9.0, 15.1, 18.8),
            new ChartDataModel(2011, 6.3, 9.3, 15.5, 18.5),
            new ChartDataModel(2012, 6.7, 10.2, 14.5, 17.6),
            new ChartDataModel(2013, 6.7, 10.2, 13.9, 16.1),
            new ChartDataModel(2014, 6.4, 10.9, 13, 17.2),
            new ChartDataModel(2015, 6.8, 9.3, 13.4, 18.9),
            new ChartDataModel(2016, 7.7, 10.1, 14.2, 19.4),
        };
    }
}

public class ChartDataModel
{
    public string? Name { get; set; }

    public double Data { get; set; }

    public string? Label { get; set; }
    public DateTime Date { get; set; }

    public double Value { get; set; }

    public double Value1 { get; set; }

    public double Size { get; set; }

    public double High { get; set; }

    public double Low { get; set; }

    public bool IsSummary { get; set; }

    public string? Levels { get; set; }
    public string? Department { get; set; }

    public List<double>? Energy { get; set; }

    public ChartDataModel() { }

    public ChartDataModel(string department, List<double> employeeAges)
    {
        Levels = department;
        Energy = employeeAges;
    }

    public ChartDataModel(string name, double value)
    {
        Name = name;
        Value = value;
    }

    public ChartDataModel(string name, double value, double high, double low)
    {
        Name = name;
        Value = value;
        High = high;
        Low = low;
    }

    public ChartDataModel(string name, double value, double size)
    {
        Name = name;
        Value = value;
        Size = size;
    }

    public ChartDataModel(DateTime date, double value, double size)
    {
        Date = date;
        Value = value;
        Size = size;
    }

    public ChartDataModel(double value, double value1, double size)
    {
        Value1 = value;
        Value = value1;
        Size = size;
    }

    public ChartDataModel(double value1, double value, double size, string label)
    {
        Value1 = value1;
        Value = value;
        Size = size;
        Label = label;
    }

    public ChartDataModel(string name, double high, double low, double open, double close)
    {
        Name = name;
        High = high;
        Low = low;
        Value = open;
        Size = close;
    }

    public ChartDataModel(double name, double high, double low, double open, double close)
    {
        Data = name;
        High = high;
        Low = low;
        Value = open;
        Size = close;
    }

    public ChartDataModel(DateTime date, double high, double low, double open, double close)
    {
        Date = date;
        High = high;
        Low = low;
        Value = open;
        Size = close;
    }
    public ChartDataModel(double value, double size)
    {
        Value = value;
        Size = size;
    }
    public ChartDataModel(DateTime dateTime, double value)
    {
        Date = dateTime;
        Value = value;
    }

    public ChartDataModel(string name, double value, bool isSummary)
    {
        Name = name;
        Value = value;
        IsSummary = isSummary;
    }

    public ChartDataModel(DateTime date, double value, double value1, double value2)
    {
        Date = date;
        Value = value;
        High = value1;
        Low = value2;
    }
}