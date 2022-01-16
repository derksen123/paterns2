using ClassLibrary.Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Bridge;

[TestClass]
public class CustomersDataTests
{
    [TestMethod]
    public void Test_GetCurrentRecord_WorksFine()
    {
        // Assign
        var cd = new CustomersData("NY");

        // Action
        // Assert
        Assert.AreEqual(cd.GetCurrentRecord(), "John Jones");
    }

    [TestMethod]
    public void Test_ShowRecord_WorksFine()
    {
        // Assign
        var cd = new CustomersData("NY");

        // Action
        // Assert
        Assert.AreEqual(cd.ShowRecord(), "John Jones");
    }

    [TestMethod]
    public void Test_ShowAllRecords_WorksFine()
    {
        // Assign
        var cd = new CustomersData("NY");

        // Action
        // Assert
        Assert.AreEqual(cd.ShowAllRecords().Replace("\n", "").Replace("\r", ""), "Customer City: NY John Jones Rampage Jackson Karolina Kawolkewich Anna Gorbatenko Joahn Edgenchik");
    }

    [TestMethod]
    public void Test_DeleteRecord_WorksFine()
    {
        // Assign
        var cd = new CustomersData("NY");

        // Action
        cd.DeleteRecord("John Jones");
        // Assert
        Assert.AreEqual(cd.ShowRecord(), "Rampage Jackson");


        // Assign
        var cd2 = new CustomersData("NY");

        // Action
        cd2.DeleteRecord("111");
        // Assert
        Assert.AreEqual(cd2.ShowRecord(), "John Jones");
    }

    [TestMethod]
    public void Test_AddRecord_WorksFine()
    {
        // Assign
        var cd = new CustomersData("NY");

        // Action
        cd.AddRecord("111");

        // Assert
        Assert.AreEqual(cd.ShowAllRecords().Replace("\n", "").Replace("\r", ""), "Customer City: NY John Jones Rampage Jackson Karolina Kawolkewich Anna Gorbatenko Joahn Edgenchik 111");
    }

    [TestMethod]
    public void Test_PriorRecord_NextRecord_WorksFine()
    {
        // Assign
        var cd = new CustomersData("NY");

        // Action
        cd.PriorRecord();
        // Assert
        Assert.AreEqual(cd.ShowRecord(), "John Jones");

        // Assign
        var cd2 = new CustomersData("NY");

        // Action
        cd2.NextRecord();
        cd2.PriorRecord();
        // Assert
        Assert.AreEqual(cd2.ShowRecord(), "John Jones");

        // Assign
        var cd3 = new CustomersData("NY");

        // Action
        cd3.NextRecord();
        // Assert
        Assert.AreEqual(cd3.ShowRecord(), "Rampage Jackson");

        // Assign
        var cd4 = new CustomersData("NY");

        // Action
        cd4.NextRecord();
        cd4.NextRecord();
        cd4.PriorRecord();
        // Assert
        Assert.AreEqual(cd4.ShowRecord(), "Rampage Jackson");
    }
}