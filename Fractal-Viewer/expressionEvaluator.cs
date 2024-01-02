using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fractal_Viewer
{
    static class expressionEvaluator
    {

        public static Func<float, float, float, float, float> GetUserDefinedFunction(string inputEquation)
        {
            // Define parameters x and y
            ParameterExpression cReParam = Expression.Parameter(typeof(float), "cRe");
            ParameterExpression cImParam = Expression.Parameter(typeof(float), "cIm");
            ParameterExpression zReParam = Expression.Parameter(typeof(float), "zRe");
            ParameterExpression zImParam = Expression.Parameter(typeof(float), "zIm");

            // Parse user input as a Lambda expression
            Expression<Func<float, float, float, float, float>> lambda = (Expression<Func<float, float, float, float, float>>)System.Linq.Dynamic.DynamicExpression.ParseLambda(
                new[] { cReParam, cImParam, zReParam, zImParam }, typeof(float), inputEquation);

            // Compile the Lambda expression to a Func<float, float, float>
            Func<float, float, float, float, float> customFunction = lambda.Compile();

            return customFunction;
        }
    }
}
