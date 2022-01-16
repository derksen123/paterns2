using System.Collections.Generic;
using ClassLibrary.Interpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;


[TestClass]
public class ExpressionTests
{
    [TestMethod]
    public void Test_WhenZeroLength_DoesNothing()
    {
        // Assign
        var context = new Context("")
        {
            Output = 0,
        };
        var expression = new OneExpression();

        // Action
        expression.Interpret(context);

        // Assert
        Assert.AreEqual(context.Output, 0);
        Assert.AreEqual(context.Input, "");
    }

    [TestMethod]
    public void Test_WhenWrongInput_WorksFine()
    {
        // Assign
        var context = new Context("AAB")
        {
            Output = 0,
        };
        var expression = new OneExpression();

        // Action
        expression.Interpret(context);

        // Assert
        Assert.AreEqual(context.Output, 0);
        Assert.AreEqual(context.Input, "AAB");
    }

    [TestMethod]
    public void Test_WhenNineOnly_WorksFine()
    {
        // Assign
        var context = new Context("IX")
        {
            Output = 0,
        };
        var expression = new OneExpression();

        // Action
        expression.Interpret(context);

        // Assert
        Assert.AreEqual(context.Output, 9);
        Assert.AreEqual(context.Input, "");
    }

    [TestMethod]
    public void Test_WhenFourOnly_WorksFine()
    {
        // Assign
        var context = new Context("IV")
        {
            Output = 0,
        };
        var expression = new OneExpression();

        // Action
        expression.Interpret(context);

        // Assert
        Assert.AreEqual(context.Output, 4);
        Assert.AreEqual(context.Input, "");
    }


    [TestMethod]
    public void Test_WhenFiveOnly_WorksFine()
    {
        // Assign
        var context = new Context("V")
        {
            Output = 0,
        };
        var expression = new OneExpression();

        // Action
        expression.Interpret(context);

        // Assert
        Assert.AreEqual(context.Output, 5);
        Assert.AreEqual(context.Input, "");
    }

    [TestMethod]
    public void Test_WhenOneOnly_WorksFine()
    {
        // Assign
        var context = new Context("I")
        {
            Output = 0,
        };
        var expression = new OneExpression();

        // Action
        expression.Interpret(context);

        // Assert
        Assert.AreEqual(context.Output, 1);
        Assert.AreEqual(context.Input, "");
    }

    [TestMethod]
    public void Test_WhenSeveralInstancedChained_WorksFine()
    {
        // Assign
        var context = new Context("MCMXXVIII")
        {
            Output = 0,
        };
        List<Expression> tree = new List<Expression>();
        tree.Add(new ThousandExpression());
        tree.Add(new HundredExpression());
        tree.Add(new TenExpression());
        tree.Add(new OneExpression());


        // Action
        foreach (Expression exp in tree)
        {
            exp.Interpret(context);
        }

        // Assert
        Assert.AreEqual(context.Output, 1928);
        Assert.AreEqual(context.Input, "");
    }
}