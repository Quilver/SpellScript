using System.Collections.Generic;
using NUnit.Framework;

namespace Source.Interpreter.InterpreterTests.LexerTests
{
    public class LexerUnitTest
    {
        private string _input;
        private Lexer _lexer;
        private string _tokens;
        private List<Lexer.Token> _tokenList;
        
        [SetUp]
        public void Setup()
        {
            _input = "1+2";
            _lexer = new Lexer(_input);
            _lexer.Tokenise();
            _tokens = "";
            _tokenList = new List<Lexer.Token>();
            
            for (int i = 0; i < _input.Length; i++)
            {
                var testToken = new Lexer.Token();
                testToken = _lexer.GetFromTokenList(i);
                
                _tokens += testToken.Value;
                _tokenList.Add(testToken);
            }
        }

        [Test]
        public void LexerUnitTestOne()
        {
            Assert.AreEqual(_tokens, _input);
        }
        
        [Test]
        public void LexerUnitTestTwo()
        {
            Assert.AreEqual(_tokenList[0].Type, Lexer.TokenTypes.Num);
            Assert.AreEqual(_tokenList[1].Type, Lexer.TokenTypes.Add);
            Assert.AreEqual(_tokenList[2].Type, Lexer.TokenTypes.Num);
        }
    }
}



