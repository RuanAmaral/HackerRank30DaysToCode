abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}
class MyBook : Book
{
    public int price;

    public MyBook(string title, string author, int price) : base(title, author)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Author: " + this.author);
        Console.WriteLine("Price: " + this.price);
    }


}

class day13
{
    public static void day13Main()
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}