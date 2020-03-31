using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private List<object> objList = new List<object>();
        public Stack()
        {

        }

        public void Start()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


        }
        private void Push(Object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("There is nothing in the stack");

            objList.Add(obj);

        }

        private object Pop()
        {
            if(objList.Count == 0)
            {
                throw new InvalidOperationException("There is nothing in the stack");
            }

           
            int index = objList.Count-1;
            Object tBack = objList[index];
            objList.RemoveAt(index);
            return (tBack);
        }

        private void Clear()
        {
            objList.Clear();
        }

    }
}
