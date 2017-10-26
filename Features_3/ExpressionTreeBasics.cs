using System;
using System.Linq.Expressions;

namespace Features_3
{
    class ExpressionTreeBasics
    {
        //Karmasık Lambda Expressionlar olusturabilir. 

        //BinaryExpression
        //ConstantExpression
        //FuncletExpression
        //InvocationExpression
        //LambdaExpression
        //MemberExpression
        //MethodCallExpression
        //NAryExpression
        //NewArrayExpression
        //NewExpression
        //ParameterExpression
        //TernaryExpression
        //TypeBinaryExpression
        //UnaryExpression
        public ExpressionTreeBasics()
        {
            //Sample 1 // the lambda expression num => num < 5.  
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression five = Expression.Constant(5, typeof(int));
            BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);
            Expression<Func<int, bool>> lambda1 =
                Expression.Lambda<Func<int, bool>>(
                    numLessThanFive,
                    new ParameterExpression[] { numParam });

            var result = lambda1.Compile();
            Console.WriteLine(result(4));

            //Sample 2 
            // Creating an expression tree.  
            Expression<Func<int, bool>> expr = num => num < 5;
            Func<int, bool> result2 = expr.Compile();
            Console.WriteLine(result2(4));
            Console.WriteLine(expr.Compile()(4));

        }

    }


}
