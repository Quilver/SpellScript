using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Operators
{
    public class Divide : OperatorClass
    {
        public override string GetToken()
        {
            return "/";
        }
        public override int GetPriority()
        {
            return 2;
        }
        public override typeClass Binary(typeClass argument1, typeClass argument2)
        {
            if (argument1.pointer == ReturnType.Number && argument1.pointer == ReturnType.Number)
            {
                return new typeClass((argument1.number / argument2.number));
            }
            return new typeClass();
        }
    }
}