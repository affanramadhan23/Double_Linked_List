using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    class Node
    {
        //* Node class represent the node of doubly linked list
        //* It consist of the information part and links to
        //* Its succeding and preceeding
        //* i terms of next and previous 
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the preceeding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;

        //constructor

        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEngter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //Check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
            //*if the node is to be insderted at between two node
            Node previous, current;
            for (current = previous = START;
                 current != null && nim >= current.noMhs;
                 previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }
            }
            //* On the execution of the above for loop, prev and
            //* current will point to the nodes
            //* between which the new Node is to be inserted
            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be inserted at the end of the list
            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous = current = START;
            while (current != null && rollNo != current.noMhs)
            {
                previous = current;
                current = current.next;
            }
            return (current != null);
        }

        public bool dellNode(int rollNo)
        {
            Node Previous, current;
            Previous = current = null;
            if (Search(rollNo, ref Previous, ref current) == false)
                return false;
            // the beginning of data
            if (current.next == null)
            {
                Previous.next = null;
                return true;
            }
            //Node between two nodes in the list
            if(current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }

            //* if the to be deleted is in between the list then following lines is executed.
            Previous.next = current.next;
            current.next.prev = Previous;
            return true;
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
