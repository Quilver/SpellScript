using System;
using System.Collections.Generic;

namespace Source.Interpreter
{
    public class Execution
    {
        //TODO: Remove temporary static variables when Lex class is implemented
        public struct Token
        {
            public Token(TokenType type, int value = 0)
            {
                this.type = type;
                this.value = value;
            }
            public TokenType type { get; set; }
            public int value { get; set; }
        }
        public Token[] Tokens = { };
        public enum TokenType //will be replaced by an enumerator created by the work on lex
        {
            PLUS,
            STAR,
            L_PAR,
            R_PAR,
            NUMBER,
        }
        
        private Stack<TokenType> OpStack = new Stack<TokenType>();
        private Stack<int> OutStack = new Stack<int>();
        private int op1, op2;
        private TokenType opType;
        
        
        public int ShuntYard()
        {
            var count = 0;
            while (count < Tokens.Length)
            {
                switch (Tokens[count].type)
                {
                    case TokenType.NUMBER:
                        OutStack.Push(Tokens[count].value); //Put numbers straight into out stack
                        Console.Out.WriteLine($"pushed {OutStack.Peek()} to output stack");
                        break;
                    case TokenType.PLUS:
                        while (OpStack.Count > 0 && OpStack.Peek() != TokenType.L_PAR) //assert stack is not empty and top is not (
                            Evaluate();
                        OpStack.Push(TokenType.PLUS); //push + to op stack
                        Console.Out.WriteLine($"Pushed {OpStack.Peek()} to operator stack");
                        break;
                    case TokenType.STAR:
                        while (OpStack.Count > 0 && (OpStack.Peek() != TokenType.L_PAR && OpStack.Peek() != TokenType.PLUS)) //assert stack is not empty and top is not ( or +
                            Evaluate();
                        OpStack.Push(TokenType.STAR); //push * to op stack
                        Console.Out.WriteLine($"Pushed {OpStack.Peek()} to operator stack");
                        break;
                    case TokenType.L_PAR:
                        OpStack.Push(TokenType.L_PAR); //push ( to op stack
                        Console.Out.WriteLine($"Pushed {OpStack.Peek()} to operator stack");
                        break;
                    case TokenType.R_PAR:
                        while (OpStack.Count > 0 && OpStack.Peek() != TokenType.L_PAR) //assert stack is not empty and top is not (
                            Evaluate();
                        if (OpStack.Peek() == TokenType.L_PAR) //check if top of stack is ( and pop it
                            OpStack.Pop();
                        break;
                }
                count++;
            }
            while(OpStack.Count > 0) //evaluate until op stack is empty
                Evaluate();
            
            return OutStack.Pop(); //return final out stack value
        }
        public void Evaluate()
        {
            opType = OpStack.Pop();
            op1 = OutStack.Pop();
            op2 = OutStack.Pop();
            switch (opType) //perform evaluation based on operator
            {
                case TokenType.PLUS: //if plus add op1 and op2
                    Console.Out.WriteLine($"adding {op1} and {op2}");
                    OutStack.Push(op1+op2);
                    break;
                case TokenType.STAR: //if star multiply op1 and op2
                    Console.Out.WriteLine($"multiplying {op1} and {op2}");
                    OutStack.Push(op1 * op2);
                    break;
            }
            Console.Out.WriteLine($"Pushed result {OutStack.Peek()} to output stack");
        }
    }
}