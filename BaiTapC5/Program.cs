using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml;

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
//bai4
public class Book
{
    private string Tieu_de;
    private string Tac_gia;
    private double gia;

    public Book(string tieude, string tacgia, double gia) {
        this.Tieu_de = tieude;
        this.Tac_gia = tacgia;
        this.gia = gia;
    }
    public Book()
    {
        NhapTT();
    }
    public void DS()
    {
        Console.WriteLine(Tieu_de);
        Console.WriteLine(Tac_gia);
        Console.WriteLine(gia);
    }
    public void NhapTT() {
        Console.WriteLine("Nhap tieu de: ");
        Tieu_de = Console.ReadLine();
        Console.WriteLine("Nhap tac gia: ");
        Tac_gia = Console.ReadLine();
        Console.WriteLine("Nhap gia tien: ");
        gia = double.Parse(Console.ReadLine());
    }
}
public class ListBook 
{
    private List<Book> listbook = new List<Book>();
    public void ThemSach(Book book)
    {
        listbook.Add(book);
    }
    public void XoaSach()
    {
        Console.WriteLine("Nhap quyen sach muon xoa (VD: 1,2,3...)");
        int n = int.Parse(Console.ReadLine());
        listbook.RemoveAt(n-1);
    }
    public void DSsach()
    {
        foreach(Book book in listbook)
        {
            book.DS();
        }
    }
}
//bai6
class SinhVien
{
    public string Hoten;
    public string Mssv;
    public double Diem_Toan;
    public double Diem_Van;
    public double Diem_Net;

    public SinhVien(string hoten, string mssv, double diem_Toan, double diem_Van, double diem_Net)
    {
        Hoten = hoten;
        Mssv = mssv;
        Diem_Toan = diem_Toan;
        Diem_Van = diem_Van;
        Diem_Net = diem_Net;
    }
    public void TTSinhVien()
    {
        Console.WriteLine("Sinh vien: " + Hoten+ ", mssv: " + Mssv+", diem Toan: " + Diem_Toan + ", diem Van: " + Diem_Van + ", diem Net: " + Diem_Net);
    }
    public void TongDiem()
    {
        double tong = Diem_Toan + Diem_Net + Diem_Van;
        Console.WriteLine("Tong diem: "+tong);
    }
    public double DiemTB()
    {
        double Diemtb = (Diem_Toan + Diem_Net + Diem_Van) / 3;
        return Diemtb; 
    }
    public void XepLoai()
    {
        
        var xl = DiemTB();
        Console.WriteLine("Diem tb:" + DiemTB());
        if (xl >= 8)
        {
            Console.WriteLine("Gioi");
        }
        else if(xl >= 5) {
            Console.WriteLine("Kha");
        }
        else
        {
            Console.WriteLine("Yeu");
        }

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
        ListBook book = new ListBook();
        Book b1= new Book("Sach Toan", "Tac gia Toan", 12.5);
        Book b2 = new Book();
        Book b3 = new Book();
        book.ThemSach(b1);
        book.ThemSach(b2);
        book.ThemSach(b3);
        Console.WriteLine("Thong tin cac sach: ");
        book.DSsach();
        book.XoaSach();
        Console.WriteLine("Thong tin cac sach: ");
        book.DSsach();
    }
    static void Bai6()
    {
        SinhVien sv1 = new SinhVien("D H G", "21012054", 7, 7.5, 8);
        sv1.TTSinhVien();
        sv1.TongDiem();
        sv1.DiemTB();
        sv1.XepLoai();
    }

    static void Main(string[] args)
    {
        int n;
        string yn;
        do
        {
            Console.WriteLine("Nhap vao bai muon chay(1,2,3,4,6): ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Bai1();
                    break;
                case 2:
                    Bai2();
                    break;
                case 3:
                    Bai3();
                    break;
                case 4:
                    Bai4();
                    break;
                case 6:
                    Bai6();
                    break;
                default:
                    Console.WriteLine("Nhap sai!");
                    break;
            }
            Console.WriteLine("Ban co muon chay tiep chuong trinh ko(y/n)");
            yn = Console.ReadLine();    
            if(yn == "y") { 
                Console.WriteLine("Chon bai: ");
            }
            else
            {
                Console.WriteLine("Ket thuc chuong trinh");
                break;
            }
            
            } while (yn == "y");
    }
}
    
