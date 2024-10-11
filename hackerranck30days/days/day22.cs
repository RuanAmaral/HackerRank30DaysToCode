using System;
class Day22Node
{
    public Day22Node left, right;
    public int data;
    public Day22Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Day22Solution
{

    static int getHeight(Day22Node root)
    {

        //How to get how much lines i have in binary tree

        //this must be more better

    //     if (root == null)
    //         return -1;
    //     else
    //         return Math.Max(getHeight(root.left), getHeight(root.right)) + 1;
    // }


    int lCount = 0;
    int rCount = 0;

        if (root.left != null)
            lCount = getHeight(root.left) + 1;

        if (root.right != null)
            rCount = getHeight(root.right) + 1;

        return Math.Max(lCount, rCount);


    }

static Day22Node insert(Day22Node root, int data)
{
    if (root == null)
    {
        return new Day22Node(data);
    }
    else
    {
        Day22Node cur;
        if (data <= root.data)
        {
            cur = insert(root.left, data);
            root.left = cur;
        }
        else
        {
            cur = insert(root.right, data);
            root.right = cur;
        }
        return root;
    }
}
static void Day22Main()
{
    Day22Node root = null;
    int T = Int32.Parse(Console.ReadLine());
    while (T-- > 0)
    {
        int data = Int32.Parse(Console.ReadLine());
        root = insert(root, data);
    }
    int height = getHeight(root);
    Console.WriteLine(height);

}
}