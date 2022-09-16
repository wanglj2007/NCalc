using System;
using System.Linq.Expressions;

namespace NCalc.Play
{
	/// <summary>
	/// Summary description for Program.
	/// </summary>
	public class Program
	{
		public static void  Main(string[] args)
		{


			var expressions = new[]
			{
				"2 * (3 + 5)",
				"2 * (2*(2*(2+1)))",
				"10 % 3",
				"false || not (false and true)",
				"3 > 2 and 1 <= (3-2)",
				"3 % 2 != 10 % 3",
                "if( [age] >= 18, 'majeur', 'mineur')",
				//"CalculateBenefits([user]) * [Taxes]"
			};



			foreach (string expression in expressions)
			{
                var exp = new Expression(expression);
				exp.EvaluateParameter += (s,e) => {
					if (s == "age") e.Result = 8;
				};

                Console.WriteLine("{0} = {1}",
					expression,
					exp.Evaluate());
			}

			Console.ReadKey();
		}
	}
}
