﻿using System;

namespace ReverseSLL
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int a)
            {
                this.data = a;
                this.next = null;
            }

        }
        static void printList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
            Console.Write("\n");
        }
        static Node Reverse(Node head)
        {
            Node prev = null;
            Node next = null;
            Node current = head;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
               
            }
            return prev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements of linked list in line1, the numbers in line 2");
            string[] element = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(element[0]);
            string elements = Console.ReadLine().Trim();
            string[] s = elements.Split(' ');
            int[] arr1 = new int[n];
            arr1 = Array.ConvertAll(elements.Split(), int.Parse);

            Node head = new Node(arr1[0]);
            Node tail = head;

            for (int i = 1; i < n; i++)
            {
                tail.next = new Node(arr1[i]);
                tail = tail.next;
            }
            //int x = Convert.ToInt32(Console.ReadLine());

            Node res = Reverse(head);
            Console.WriteLine("The reversed list is: ");
            printList(res);
        }
    }
}
