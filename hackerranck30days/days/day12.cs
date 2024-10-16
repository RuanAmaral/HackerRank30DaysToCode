using System;
using System.Linq;
using System.Linq.Expressions;

class Persons
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Persons() { }
    public Persons(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Persons
{
    private int[] testScores;
    private int[] scores;

    public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
    {
        this.scores = scores;
    }

    internal string Calculate()
    {
        int average = (int)this.scores.Average();

        if (average < 40)
        {
            return ("T");
        }
        else if (average < 55)
        {
            return ("D");
        }
        else if (average < 70)
        {
            return ("P");
        }
        else if (average < 80)
        {
            return ("A");
        }
        else if (average < 90)
        {
            return ("E");
        }
        else
        {
            return ("O");
        }


    }

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
}


class day12
{
    public static void day12Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }

}