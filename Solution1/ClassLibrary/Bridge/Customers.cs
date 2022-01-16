using System.Text;

namespace ClassLibrary.Bridge;

public class Customers : CustomersBase
{
    public override string ShowAll()
    {
        var sb = new StringBuilder();


        sb.AppendLine();
        sb.AppendLine("--");
        sb.Append(base.ShowAll());
        sb.AppendLine("--");

        return sb.ToString();
    }
}