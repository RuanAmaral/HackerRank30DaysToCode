class Node
{
	public int data;
	public Node next;
	public Node(int d)
	{
		data = d;
		next = null;
	}

}
class day15
{

	public static Node Insert(Node head, int data)
	{
		if (head == null)
		{
			Node nextNode = new Node(data);
			return nextNode;
		}
		else
		{
			head.next=Insert(head.next,data);
			return head; 
		}

	}

	public static void display(Node head)
	{
		Node start = head;
		while (start != null)
		{
			Console.Write(start.data + " ");
			start = start.next;
		}
	}
	public static void day15Main()
	{

		Node head = null;
		int T = Int32.Parse(Console.ReadLine());
		while (T-- > 0)
		{
			int data = Int32.Parse(Console.ReadLine());
			head = Insert(head, data);
		}
		display(head);
	}
}