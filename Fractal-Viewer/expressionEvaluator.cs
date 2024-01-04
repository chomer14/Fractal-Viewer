using System;
using System.Linq.Expressions;

namespace Fractal_Viewer
{
    static class expressionEvaluator
    {

        public static Func<float, float, float, float, float> GetUserDefinedFunction(string inputEquation)
        {
            // define parameters
            ParameterExpression cReParam = Expression.Parameter(typeof(float), "cRe");
            ParameterExpression cImParam = Expression.Parameter(typeof(float), "cIm");
            ParameterExpression zReParam = Expression.Parameter(typeof(float), "zRe");
            ParameterExpression zImParam = Expression.Parameter(typeof(float), "zIm");

            // parse user input as lambda
            Expression<Func<float, float, float, float, float>> lambda = (Expression<Func<float, float, float, float, float>>)System.Linq.Dynamic.DynamicExpression.ParseLambda(
                new[] { cReParam, cImParam, zReParam, zImParam }, typeof(float), inputEquation);

            // compile
            Func<float, float, float, float, float> customFunction = lambda.Compile();

            return customFunction;
        }
    }
}
