using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Operators;
public class OperatorFactory
{
    static OperatorFactory _factory;
    static public OperatorFactory OperatorManager
    {
        get
        {
            if (_factory == null)
            {
                _factory = new OperatorFactory();
                _factory.Initialise();
            }
            return _factory;
        }
    }
    public Dictionary<string, OperatorClass> operators;
    public OperatorClass GetOperator(string token)
    {
        if (!operators.ContainsKey(token))
            return null;
        return operators[token];
    }
    void InitBooleans()
    {
        OperatorClass operatorObj = null;

        operatorObj = new And();
        operators.Add(operatorObj.GetToken(), operatorObj);
        operatorObj = new Or();
        operators.Add(operatorObj.GetToken(), operatorObj);
        operatorObj = new Not();
        operators.Add(operatorObj.GetToken(), operatorObj);
        operatorObj = new IsGreater();
        operators.Add(operatorObj.GetToken(), operatorObj);
        operatorObj = new IsLess();
        operators.Add(operatorObj.GetToken(), operatorObj);
    }
    void InitNumberOperators()
    {
        OperatorClass operatorObj = null;
        operatorObj = new Add();
        operators.Add(operatorObj.GetToken(), operatorObj);
        operatorObj = new Subtract();
        operators.Add(operatorObj.GetToken(), operatorObj);
        operatorObj = new Multiply();
        operators.Add(operatorObj.GetToken(), operatorObj);
        operatorObj = new Divide();
        operators.Add(operatorObj.GetToken(), operatorObj);
        
        //operatorObj = new Root();
        //..operators.Add(operatorObj.GetToken(), operatorObj);
        //operatorObj = new Exponent();
        //operators.Add(operatorObj.GetToken(), operatorObj);
        
    }
    void Initialise()
    {
        operators = new Dictionary<string, OperatorClass>();
        InitBooleans();
        InitNumberOperators();
    }
}
