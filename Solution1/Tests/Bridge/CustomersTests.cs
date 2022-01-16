using ClassLibrary.Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Bridge;

[TestClass]
public class CustomersTests
{
    [TestMethod]
    public void Test_ShowAll_WorksFine()
    {
        // Assign
        var customers = new Customers();
        customers.Data = new CustomersData("Colorado");

        // Action
        customers.Next();
        customers.Next();
        customers.Add("Thiery Henry");
        var result = customers.ShowAll();

        // Assert
        Assert.AreEqual(result.Replace("\n", "").Replace("\r", ""), "--Customer City: Colorado John Jones Rampage Jackson Karolina Kawolkewich Anna Gorbatenko Joahn Edgenchik Thiery Henry--");
    }
}