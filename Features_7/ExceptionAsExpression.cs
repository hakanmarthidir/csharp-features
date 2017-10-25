using System;

namespace Features_7
{
    class ExceptionAsExpression
    {
        public string Name { get; }
        public ExceptionAsExpression(string name) => Name = name ?? throw new ArgumentNullException();
    }
}
