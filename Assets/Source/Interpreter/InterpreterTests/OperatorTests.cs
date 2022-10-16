using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class OperatorTests
{
    
    OperatorFactory operatorManager = OperatorFactory.OperatorManager;
    Operators.typeClass number = new Operators.typeClass(5);
    Operators.typeClass boolean = new Operators.typeClass(false);
    bool OperatorBoolTests()
    {
        if (operatorManager.GetOperator("and") != null)
        {
            if (operatorManager.GetOperator("and").Binary(boolean, boolean).toggle)
                return false;
        }
        else return false;
        if (operatorManager.GetOperator("or") != null)
        {
            if (operatorManager.GetOperator("or").Binary(boolean, boolean).toggle)
                return false;
        }
        else return false;
        return true;
    }
    bool OperatorMathTests()
    {
        if (operatorManager.GetOperator("+") != null)
        {
            if (operatorManager.GetOperator("and").Binary(number, number).number != 10)
                return false;
        }
        else return false;
        if (operatorManager.GetOperator("-") != null)
        {
            if (operatorManager.GetOperator("and").Binary(number, number).number != 0)
                return false;
        }
        else return false;
        if (operatorManager.GetOperator("*") != null)
        {
            if (operatorManager.GetOperator("and").Binary(number, number).number != 25)
                return false;
        }
        else return false;
        if (operatorManager.GetOperator("/") != null)
        {
            if (operatorManager.GetOperator("and").Binary(number, number).number != 1)
                return false;
        }
        else return false;
        return true;
    }
    // A Test behaves as an ordinary method
    [Test]
    public void OperatorTester()
    {
        // Use the Assert class to test conditions
        Assert.That(OperatorBoolTests());
        Assert.That(OperatorMathTests());

    }
}