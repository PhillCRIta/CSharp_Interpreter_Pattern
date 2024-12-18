using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Interpreter
{
	internal class Interpreter
	{
		private Context _context;

		public Interpreter(Context context)
		{
			_context = context;
		}

		public int Interpret(string expression)
		{
			//create a expression tree
			IExpression expressionTree = BuildExpressionTree(expression);
			//interpret() traverse the expression tree and interprete each individual expression or node
			return expressionTree.Interpret(_context);
		}

		private IExpression BuildExpressionTreeWITHLOGIC(string input)
		{
			string[] token = input.Split(" ");//operator symbol
			var output = new Queue<string>();
			var operators = new Stack<string>();

			//Use Shunting Yard Algorithms

			IExpression expressionTree = new AdditionExpression(
				new MultiplicationExpression(
					new NumberExpression("2"),
					new NumberExpression("3")
					),
				new NumberExpression("1")
			);
			return expressionTree;
		}

		//
		private IExpression BuildExpressionTree(string input)
		{
			//GO4 said The Interpreter pattern doesn't explain how to create an abstract syntax tree.
			//turn your language into an Abstract Syntax Tree(AST)
			//parser function is very complex 1 + 2 * 3
			//exixts many type of parser inside a package
			//in this case i haven't use a parser logic, i create directly the expression tree
			input = "1 + 2 * 3";
			//operand is the numbers >> NumberExpression
			//operator is a operation to do >> Addition, Substraction, Multiplication Expression (termiinal expression)
			IExpression expressionTree = new AdditionExpression(
				new MultiplicationExpression(
					new NumberExpression("2"),
					new NumberExpression("3")
					),
				new NumberExpression("1")
			);
			return expressionTree;
		}
	}
}
