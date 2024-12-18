using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Interpreter
{
	//TERMINAL EXPRESSION, the terms on wich execute the functions, like as numbers in this case
	internal class NumberExpression : IExpression
	{
		private int _number;

		public NumberExpression(int number)
		{
			_number = number;
		}
		public NumberExpression(string number)
		{
			_number = Convert.ToInt32(number);
		}
		public int Interpret(Context context)
		{
			return _number;
		}
	}
}
