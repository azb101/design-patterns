using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interpreter.Canonical;

namespace Interpreter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // canonical
            var context = new Context();

            var list = new ArrayList();

            // populate 'abstract syntax tree'
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());

            // interpret
            foreach (AbstractExpression expression in list)
            {
                expression.Interpret(context);
            }
            Console.WriteLine();

            // live example
            string roman = "MCMXXVIII";
            var context2 = new Live.Context(roman);
            var tree = new List<Live.Expression>();
            tree.Add(new Live.ThousandExpression());
            tree.Add(new Live.HundredExpression());
            tree.Add(new Live.TenExpression());
            tree.Add(new Live.OneExpression());

            foreach (var expression in tree)
            {
                expression.Interpter(context2);
                Console.WriteLine($"{roman} = {context2.Output}");
            }

            Console.WriteLine($"{roman} = {context2.Output}");
            Console.WriteLine();

            // another live example
            // a - b + c
            var context3 = new AnotherLive.Context();
            context3.SetVariable("a", 5);
            context3.SetVariable("b", 1);
            context3.SetVariable("c", 10);

            var subtractExpression = new AnotherLive.SubtractExpression();
            subtractExpression.expression1 = new AnotherLive.NumberExpression("a");
            subtractExpression.expression2 = new AnotherLive.NumberExpression("b");

            var addExpression = new AnotherLive.AddExpression();
            addExpression.expression1 = subtractExpression;
            addExpression.expression2 = new AnotherLive.NumberExpression("c");

            Console.WriteLine(addExpression.Interpret(context3));
        }
    }
}