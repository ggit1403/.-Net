using System;
using System.ComponentModel.DataAnnotations;

// bai1
class Person{
    public int Age;
    public string name;
    public void Hello() {
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello, i'm " + name);
    }
    public void SetAge()
    {
        Console.Write("Nhap tuoi cua ban: ");
        Age = int.Parse(Console.ReadLine());
    }  
}
class Teacher : Person
{
    public void Teach()
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("I'm Teaching");
    }
}
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
//bai2
class Hinh_Hoc
{
    public double chieu_dai, width, r;
    public double pi = 3.14;
}
class HCN : Hinh_Hoc 
{
    
    public void HinhChuNhat()
    {
        Console.WriteLine("Hinh chu nhat, nhap chieu dai va chieu rong:");
        chieu_dai = double.Parse(Console.ReadLine());
        width = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Chu vi: ");
        Chu_vi();
        Console.WriteLine("Dien tich: ");
        Dien_tich();
    }
    
    public void Chu_vi()
    {
        double chuvi = (chieu_dai + width) * 2;
        Console.WriteLine(chuvi);
    }
    public void Dien_tich()
    {
        double dien_tich = chieu_dai * width;
        Console.WriteLine(dien_tich);
    }
}
class Circle : Hinh_Hoc
{

    public void HinhTron()
    {
        Console.WriteLine("Hinh tron, nhap ban kinh:");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine("Chu vi: ");
        Chu_vi();
        Console.WriteLine("Dien tich: ");
        Dien_tich();
    }

    public void Chu_vi()
    {
        double chuvi = pi*r*2;
        Console.WriteLine(chuvi);
    }
    public void Dien_tich()
    {
        double dien_tich = pi*r*r;
        Console.WriteLine(dien_tich);
    }

}
//bai3
class TKNH
{
    private string stk;
    private double sodu;
    public  void  Nhapstk() {
        Console.Write("Nhap so tai khoan: ");
        stk = Console.ReadLine();
        Console.WriteLine("So tai khoan :"+stk);
        sodu = 500.000;
        Console.WriteLine("So du tai khoan: "+sodu);
    }
    public void GuiTien() {
        Console.Write("Nhap so tien muon gui: ");
        double tien_gui = double.Parse(Console.ReadLine());
        if(tien_gui > 0) {
            sodu += tien_gui;
            Console.WriteLine("So du hien tai: " + sodu);
        }
        else { Console.WriteLine("Nhap sai!"); }
    }
    public void RutTien()
    {
        Console.Write("Nhap so tien muon rut: ");
        double tien_rut = double.Parse(Console.ReadLine());
        if (tien_rut > 0 && tien_rut <= sodu)
        {
            sodu -= tien_rut;
            Console.WriteLine("So du hien tai: " + sodu);
        }
        else if(tien_rut == 0)
        {
            Console.WriteLine("Vui long nhap so tien rut lon hon 0");
        }
        else { Console.WriteLine("Nhap sai!"); }
    }
}


class Program
{
    static void Bai1()
    {
        Console.WriteLine("Bai1:");
        Teacher teacher = new Teacher();
        Student student = new Student();

        student.Study();
        student.SetAge();
        student.ShowAge();

        teacher.Teach();
    }
    static void Bai2()
    {
        Console.WriteLine("Bai2:");
        HCN hcn = new HCN();
        hcn.HinhChuNhat();
        Circle circle = new Circle();
        circle.HinhTron();
    }
    static void Bai3()
    {
        Console.WriteLine("Bai3:");
        TKNH taikhoan = new TKNH();
        taikhoan.Nhapstk();
        taikhoan.GuiTien();
        taikhoan.RutTien();
    }
    static void Bai4()
    {

    }

    static void Main(string[] args)
    {
        //Bai1();
        //Bai2();
        //Bai3();

    }
}
    
