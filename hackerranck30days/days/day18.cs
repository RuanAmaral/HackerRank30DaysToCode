

class day18
{
    Queue<char> MyQueue = new Queue<char>();
    Stack<Char> MyStack = new Stack<char>();

    void pushCharacter(char ch)
    {
        this.MyStack.Push(ch);
    }
    void enqueueCharacter(char ch)
    {
        this.MyQueue.Enqueue(ch);
    }

    char popCharacter()
    {
        char x = this.MyStack.Pop();
        return x;
    }

    char dequeueCharacter()
    {
        char x = this.MyQueue.Dequeue();
        return x;
    }


    public static void day18Main()
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        day18 obj = new day18();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}

