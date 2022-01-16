namespace ClassLibrary.Bridge;

public class CustomersBase
{
    public DataObject Data { set; get; }

    public virtual void Next()
    {
        Data.NextRecord();
    }

    public virtual void Prior()
    {
        Data.PriorRecord();
    }

    public virtual void Add(string customer)
    {
        Data.AddRecord(customer);
    }

    public virtual void Delete(string customer)
    {
        Data.DeleteRecord(customer);
    }

    public virtual string Show()
    {
        return Data.ShowRecord();
    }

    public virtual string ShowAll()
    {
        return Data.ShowAllRecords();
    }
}