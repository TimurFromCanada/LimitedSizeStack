using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApplication
{
    public class LimitedSizeStack<T>
    {
        readonly int limit;

        LinkedList<T> stack = new LinkedList<T>();

        public LimitedSizeStack(int limit)
        {
            this.limit = limit;
        }

        public void Push(T item)
        {
            if (stack.Count >= limit)
            {
                stack.RemoveFirst();
            }
                
            stack.AddLast(item);
        }

        public T Pop()
        {
            var result = stack.Last.Value;
            stack.RemoveLast();
            return result;
        }

        public int Count
        {
            get
            {
                return stack.Count;
            }
        }
    }
}

