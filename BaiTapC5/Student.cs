using System;

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }
    public void ShowAge()
    {
        
        Console.WriteLine("My age is: " + Age + " year old");
    }

}
