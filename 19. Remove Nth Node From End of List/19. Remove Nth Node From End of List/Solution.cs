using System;

namespace _19._Remove_Nth_Node_From_End_of_List
{
    public static class Solution
    {
        class Node
        {
            public int data;
            public Node next;
        }
        static Node create(Node head, int x)
        {
            Node temp, ptr = head;
            temp = new Node();
            temp.data = x;
            temp.next = null;
            if (head == null)
                head = temp;
            else
            {
                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = temp;
            }
            return head;
        }
        static Node removeNthFromEnd(Node head, int B)
        {
            // To store length of the linked list
            int len = 0;
            Node tmp = head;
            while (tmp != null)
            {
                len++;
                tmp = tmp.next;
            }

            // B > length, then we can't remove node
            if (B > len)
            {
                Console.Write("Length of the linked list is " + len);
                Console.Write(" we can't remove " + B +
                                   "th node from the");
                Console.Write(" linked list\n");
                return head;
            }

            // We need to remove head node
            else if (B == len)
            {

                // Return head.next
                return head.next;

            }
            else
            {
                // Remove len - B th node from starting
                int diff = len - B;
                Node prev = null;
                Node curr = head;
                for (int i = 0; i < diff; i++)
                {
                    prev = curr;
                    curr = curr.next;
                }
                prev.next = curr.next;
                return head;
            }

        }
        static void display(Node head)
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            //LinkedList llist = new LinkedList();

            //llist.push(7);
            //llist.push(1);
            //llist.push(3);
            //llist.push(2);

            //Console.WriteLine("\nCreated Linked list is:");
            //llist.printList();

            //int N = 1;
            //llist.deleteNode(N);

            //Console.WriteLine("\nLinked List after Deletion is:");
            //llist.printList();

            Node head = null;

            head = create(head, 1);
            head = create(head, 2);
            head = create(head, 3);
            head = create(head, 4);
            head = create(head, 5);

            Console.Write("Linked list before modification: \n");
            display(head);

            head = removeNthFromEnd(head, 2);
            Console.Write("Linked list after modification: \n");
            display(head);
        }
    }
}
