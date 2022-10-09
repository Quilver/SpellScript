﻿using System.Collections.Generic;

/*
Assumptions - only one line can be entered. Each character is a new token

This will be changed but is assumed now in order to create a simple starting lexer
*/

/*
 * List of things to add in future
 * TODO - Create Token class and move over token stuff
 * TODO - Find out if I need to count the number of tokens (maybe just for testing)
 * TODO - Finalise enum names
 * TODO - Use our own language
 * TODO - Consider multi-digit numbers
 * TODO - Other operators (divide, power, root etc)
 */

namespace Source.Interpreter
{
    public class Lexer
    {
        private readonly string _input;
        private readonly List<Token> _tokens = new List<Token>(); //TODO - define max with the group
        private int _tokenCount = 0;
        
        ////////// Token setup here //////////
        public enum TokenTypes { //will be added to later, names not final
            Add,
            Multi,
            LeftParam,
            RightParam,
            Num		
        }
        
        public struct Token
        {
            public TokenTypes Type;
            public char Value;
        }
        
        ////////// End of Token Setup //////////
        
        //constructor
        public Lexer(string input)
        {
            _input = input;
        }

        //TODO - might be needed for tests, otherwise get rid of this
        public string GetInput()
        {
            return _input;
        }

        public Token GetFromTokenList(int placeToSearch)
        {
            return _tokens[placeToSearch];
        }

        public int Tokenise() //TODO - think about if this needs to return an int
        {
            var newToken = new Token();
            foreach(char c in _input)
            {
                switch(c)
                {
                    case ' ' :
                        //ignore
                        return 0;
                    case '+' :
                        _tokenCount++; //todo - do I need this?
                        newToken.Type = TokenTypes.Add;
                        newToken.Value = c;
                        break;
                    case '*' :
                        _tokenCount++; //todo - do I need this?
                        newToken.Type = TokenTypes.Multi;
                        newToken.Value = c;
                        break;
                    case '(' :
                        _tokenCount++; //todo - do I need this?
                        newToken.Type = TokenTypes.LeftParam;
                        newToken.Value = c;
                        break;
                    case ')' :
                        _tokenCount++; //todo - do I need this?
                        newToken.Type = TokenTypes.RightParam;
                        newToken.Value = c;
                        break;
                    default :
                        if (char.IsDigit(c))
                        {
                            _tokenCount++;
                            newToken.Type = TokenTypes.Num;
                            newToken.Value = c;
                        }
                        else
                        {
                            //TODO - need an error message here!
                        }
                        break;
                }
                _tokens.Add(newToken);
            }
            return 0;
        }
    }
}