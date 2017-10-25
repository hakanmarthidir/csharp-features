using System;
using System.Collections.Concurrent;

namespace Features_7
{
    class ExpressionBodiedMembers
    {
        private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();

        public int Length { get; set; }
        public int Area => Length * Length;

        private int id = GetId();

        private static int GetId()
        {
            throw new NotImplementedException();
        }

        public ExpressionBodiedMembers(string name) => names.TryAdd(id, name); // constructors
        ~ExpressionBodiedMembers() => names.TryRemove(id, out _);              // finalizers
        public string Name
        {
            get => names[id];                                 // getters
            set => names[id] = value;                         // setters
        }
    }
}
