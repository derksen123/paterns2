using System.Text;

namespace ClassLibrary.Bridge;

public class CustomersData : DataObject
{
    private readonly List<string> _customers = new();
    private int _current;
    private readonly string _city;

    public CustomersData(string city)
    {
        _city = city;

        _customers.Add("John Jones");
        _customers.Add("Rampage Jackson");
        _customers.Add("Karolina Kawolkewich");
        _customers.Add("Anna Gorbatenko");
        _customers.Add("Joahn Edgenchik");
    }

    public override void NextRecord()
    {
        if (_current <= _customers.Count - 1) _current++;
    }

    public override void PriorRecord()
    {
        if (_current > 0) _current--;
    }

    public override void AddRecord(string customer)
    {
        _customers.Add(customer);
    }

    public override void DeleteRecord(string customer)
    {
        _customers.Remove(customer);
    }

    public override string GetCurrentRecord()
    {
        return _customers[_current];
    }

    public override string ShowRecord()
    {
        return _customers[_current];
    }

    public override string ShowAllRecords()
    {
        var sb = new StringBuilder();

        sb.AppendLine("Customer City: " + _city);
        foreach (var customer in _customers) sb.AppendLine(" " + customer);

        return sb.ToString();
    }
}