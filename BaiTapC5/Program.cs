using System;

class Person
{
    public int Age;
    public string name;
    public void Hello() {
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello, i'm "+name);
    }
    public void SetAge()
    {
        Console.Write("Dat tuoi: ");
        Age = int.Parse(Console.ReadLine());
    }
    static void Bai1()
    {
       //Person p1 = new Person(); khởi tạo thông qua toán tử New
        //p1.Hello();
        //p1.SetAge(20);
        Student student = new Student();
        student.Hello();
        student.Study();
        student.SetAge();
        student.ShowAge();
        
        Teacher teacher = new Teacher();
        teacher.Teach();    
    }
    static void Main(string[] args)
    {
        Bai1();
    }
}

/*
    class Student : Person
{
    public void Study()
    {
        Console.WriteLine("T'm studying");
    }
    public void ShowAge()
    {
        Console.Write("Dat tuoi: ");
        Age = int.Parse(Console.ReadLine());
        Console.WriteLine("My age is: " + Age + "year old");
    }
}
*/

/*
   class Teacher : Person
{
    public void Teach()
    {
        Console.WriteLine("I'm Teaching");
    }
    public void AgeTeach()
    {
        Console.Write("Dat tuoi: ");
        Age = int.Parse(Console.ReadLine());
        Console.WriteLine("I'm " + Age + " years old");
    }
}
*/


