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
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
