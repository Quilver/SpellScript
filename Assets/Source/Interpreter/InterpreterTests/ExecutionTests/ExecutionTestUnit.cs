using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Source.Interpreter.InterpreterTests.ExecutionTests
{
    public class ExecutionTestUnit
    {
        private Execution _execution;
        private List<Execution.Token> _tokens;
        [SetUp]
        public void Setup()
        {
            //generate token test data
            _tokens = new List<Execution.Token>
            {
                new Execution.Token(Execution.TokenType.NUMBER, 1),
                new Execution.Token(Execution.TokenType.PLUS),
                new Execution.Token(Execution.TokenType.NUMBER, 3)
            };
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestSimpleAddition()
        {
            _execution = new Execution
            {
                Tokens = _tokens.ToArray()
            };
            var result = _execution.ShuntYard();
            Assert.That(result == 4);
        }

    }
}