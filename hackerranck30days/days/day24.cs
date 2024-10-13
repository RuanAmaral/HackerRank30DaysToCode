using System;
using System.Collections.Generic;
class day24Node
{
    public int data;
    public day24Node next;
    public day24Node(int d)
    {
        data = d;
        next = null;
    }

}
class day24Solution
{

    public static day24Node day24removeDuplicates(day24Node head)
    {
        //Write your code here
        //My answer
        if (head.next is not null)
        {
            day24Node next = head.next;
            while (next.next is not null)
            {
                day24Node next2 = next.next;
                if (next.data == next2.data)
                {
                    next.next = next2.next;
                }
                else
                {
                    next = next.next;
                }
            }

            next = head.next;
            if (head.data == next.data)
            {
                head.next = next.next;
            }

        }

        return head;
    }

    public static day24Node day24insert(day24Node head, int data)
    {
        day24Node p = new day24Node(data);


        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            day24Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;

        }
        return head;
    }
    public static void display(day24Node head)
    {
        day24Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    static void day24Main()
    {

        day24Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = day24insert(head, data);
        }
        head = day24removeDuplicates(head);
        display(head);
    }
}
