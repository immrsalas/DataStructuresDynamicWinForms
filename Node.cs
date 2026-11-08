using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDynamicWinForms
{
    internal class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return $"Dato: {Value}";
        }
    }
}
