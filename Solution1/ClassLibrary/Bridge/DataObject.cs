namespace ClassLibrary.Bridge;

public abstract class DataObject
{
    public abstract void NextRecord();
    public abstract void PriorRecord();
    public abstract void AddRecord(string name);
    public abstract void DeleteRecord(string name);
    public abstract string GetCurrentRecord();
    public abstract string ShowRecord();
    public abstract string ShowAllRecords();
}