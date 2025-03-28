namespace RadzenDropdownSample.Pages;

public partial class Index
{
    Dictionary<string, int ?> items = new Dictionary<string, int?>()
    {
        { "",null},
        { "A", 1 },
        { "B", 2 },
        { "C", 3 },
        { "D", 4 },
        { "E", 5 },
        { "F", 6 },
        { "G", 7 },
        { "H", 8 },
        { "I", 9 },
        { "J", 10 },
        { "K", 11 },
        { "L", 12 },
        { "M", 13 },
        { "N", 14 },
        { "O", 15 },
        { "P", 16 },
        { "Q", 17 },
        { "R", 18 },
        { "S", 19 },
        { "T", 20 },
        { "U", 21 },
        { "V", 22 },
        { "W", 23 },
        { "X", 24 },
        { "Y", 25 },
        { "Z", 26 }
    };
    
    int? selectedItem;
    public DateTime? Value { get; set; }
    public DateTime? Value2 { get; set; }
    public DateTime? Value3 { get; set; }

    private void Callback(object obj)
    {
        Console.WriteLine(selectedItem);
    }

    private void OnChangeInner(DateTime? obj)
    {
        Value = obj;
        Console.WriteLine(obj);
    }
    
    private void OnChangeInner2(DateTime? obj)
    {
        Value2 = obj;
        Console.WriteLine(obj);
    }
    
    private void OnChangeInner3(DateTime? obj)
    {
        Value3 = obj;
        Console.WriteLine(obj);
    }
}