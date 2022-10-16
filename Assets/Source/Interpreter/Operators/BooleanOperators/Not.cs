using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Operators
{
    public class Not : OperatorClass
    {
        public override string GetToken()
        {
            return "not";
        }
        public override int GetPriority()
        {
            return 5;
        }
        public override typeClass Unary(typeClass argument1) 
        {
            if (argument1.pointer == ReturnType.Boolean)
                return new typeClass(!argument1.toggle);
            return new typeClass(); 
        }
    }
}
