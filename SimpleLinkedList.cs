using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDynamicWinForms
{
    internal class SimpleLinkedList
    {
        public Node? Head { get; set; }

        public SimpleLinkedList()
        {
            Head = null;
        }

        // Agregar al inicio o final (Inserción dinámica)
        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Eliminar un nodo por valor
        public void Remove(int value)
        {
            if (Head == null) return;

            if (Head.Value == value)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Value != value)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        // Método para buscar si un valor existe en la lista dinámica
        public bool Search(int value)
        {
            Node? current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true; // ¡Lo encontró!
                }
                current = current.Next;
            }
            return false; // Llegó al final y no está
        }

        // Convertir la lista a texto para mostrarla en el ListBox
        public string PrintList()
        {
            string result = "";
            Node? current = Head;
            while (current != null)
            {
                result += $"[{current.Value}] -> ";
                current = current.Next;
            }
            return result + "NULL";
        }

    }
}
