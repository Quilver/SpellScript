using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Operators
{
    public class And : OperatorClass
    {
        public override string GetToken()
        {
            return "and";
        }
        public override int GetPriority()
        {
            return 5;
        }
        public override typeClass Binary(typeClass argument1, typeClass argument2)
        {
            if (argument1.pointer == ReturnType.Boolean && argument1.pointer == ReturnType.Boolean)
            {
                return new typeClass((argument1.toggle && argument2.toggle));
            }
            return new typeClass();
        }
    }
}

