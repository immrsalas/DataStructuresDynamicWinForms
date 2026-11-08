using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDynamicWinForms
{
    internal class DynamicStack
    {
        private Node? top;

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = top;
            top = newNode;
        }

        public int? Pop()
        {
            if (top == null) return null;
            int value = top.Value;
            top = top.Next;
            return value;
        }

        public string PrintStack()
        {
            string result = "";
            Node? current = top;
            while (current != null)
            {
                result += $"[{current.Value}] -> ";
                current = current.Next;
            }
            return result + "NULL (Cima)";
        }
    }
}

