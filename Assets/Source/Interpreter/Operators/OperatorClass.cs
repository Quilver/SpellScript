using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Operators
{
    public enum OperatorType
    {
        Unary,
        Binary
    }
    public enum ReturnType
    {
        Error,
        Null,
        Number,
        String,
        Boolean
    }
    public class typeClass
    {
        public ReturnType pointer;
        public double number;
        public string word;
        public bool toggle;
        public typeClass(double number) { this.number = number; pointer = ReturnType.Number; }
        public typeClass(string word) { this.word = word; pointer = ReturnType.String; }
        public typeClass(bool toggle) { this.toggle = toggle; pointer = ReturnType.Boolean; }
        public typeClass() { pointer = ReturnType.Error; }
    }
    public abstract class OperatorClass
    {
        public abstract string GetToken();
        public abstract int GetPriority();

        public virtual typeClass Unary(typeClass argument1) { return new typeClass(); }
        public virtual typeClass Binary(typeClass argument1, typeClass argument2) { return  new typeClass(); }
    }
}

