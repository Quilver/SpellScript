using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Operators
{
    public class IsLess : OperatorClass
    {
        public override string GetToken()
        {
            return "<";
        }
        public override int GetPriority()
        {
            return 5;
        }
    }
}

