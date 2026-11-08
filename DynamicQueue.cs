using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDynamicWinForms
{
    internal class DynamicQueue
    {
        private Node? front;
        private Node? rear;

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (rear == null)
            {
                front = rear = newNode;
                return;
            }
            rear.Next = newNode;
            rear = newNode;
        }

        public int? Dequeue()
        {
            if (front == null) return null;
            int value = front.Value;
            front = front.Next;
            if (front == null) rear = null;
            return value;
        }

        public string PrintQueue()
        {
            string result = "";
            Node? current = front;
            while (current != null)
            {
                result += $"[{current.Value}] -> ";
                current = current.Next;
            }
            return result + "NULL (Final)";
        }

    }
}
