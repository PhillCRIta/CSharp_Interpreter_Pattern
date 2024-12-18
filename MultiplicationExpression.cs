using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Interpreter
{
	internal class MultiplicationExpression : IExpression
	{
		private IExpression _leftExpression;
		private IExpression _rightExpression;

		public MultiplicationExpression(IExpression leftExpression, IExpression rightExpression)
		{
			_leftExpression = leftExpression;
			_rightExpression = rightExpression;
		}

		public int Interpret(Context context)
		{
			return _leftExpression.Interpret(context) * _rightExpression.Interpret(context);
		}
	}
}
