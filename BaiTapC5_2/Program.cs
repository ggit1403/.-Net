using System;

class Program
{

    static void Main(string[] args)
    {
        Phan1();
    }

    static void Phan1()
    {
        //Bai1_Phan1();
        //Bai2_Phan1();
        //Bai3_Phan1();
        //Bai4_Phan1();
        //Bai5_Phan1();
        //Bai6_Phan1();
    }

    static void Bai1_Phan1()
    {
        Console.WriteLine("Bai1 Phan1: Tính tổng S(n) = 1+2+3+4+ … +n");
        Console.Write("Nhap phan tu n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += i + 1;
        }
        Console.WriteLine("S = "+sum);
    }
    static void Bai2_Phan1()
    {
        Console.WriteLine("Bai2 Phan1: Tính tổng S(n) = 1^2 + 2^2 + … + n^2");
        Console.Write("Nhap phan tu n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i*i;
        }
        Console.WriteLine("S = " + sum);
    }
    static void Bai3_Phan1()
    {
        Console.WriteLine("Bai3 Phan1: Tính tổng S(n) = 1/2 + 1/4 + 1/6 + 1/8 + 1/2n");
        Console.Write("Nhap phan tu n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (double i = 1; i <= n; i++)
        {
            sum += 1/(i*2);
        }
        Console.WriteLine("S = " + sum);
    }
    static void Bai4_Phan1() {
        Console.WriteLine("Bai4 Phan1: Tìm ước số chung lớn nhất và bội số chung nhỏ nhất của 2 số a,b");
        Console.WriteLine("Nhap 2 so a va b = ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int UCLN = 0, BCNN = 0;
        int c = a * b;
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= b; j++)
            {
                if(a%j == 0 && b%j == 0)
                {
                    UCLN = j;
                }
            }
        }
        Console.WriteLine("Uoc chung lon nhat = "+UCLN);
        for (int i = 1;i <= c; i++)
        {
            if(i%a == 0 && i%b == 0)
            {
                BCNN = i;
                break;
            }
        }
        Console.WriteLine("Boi chung nho nhat = " + BCNN);
    }
    static void Bai5_Phan1()
    {
        Console.WriteLine("Bai5 Phan1: Tính giai thừa số nguyên dương");
        Console.WriteLine("Nhap vao 1 so nguyen duong n = ");
        int n = int.Parse(Console.ReadLine());
        int x = 1;
        for (int i = 1; i <= n; i++)
        {
            x *= i;
        }
        Console.WriteLine("Giai thua cua " + n + " la: " + x);
    }
    static void Bai6_Phan1() {
        Console.WriteLine("Bai6 Phan1: Kiểm tra số N có phải là số nguyên tố không?");
        Console.WriteLine("Nhap vao 1 so nguyen n = ");
        int n = int.Parse(Console.ReadLine());
        int score = 0;
        for (int i = 1;i<= n; i++)
        {
            if(n % i == 0)
            {
                score++;
            }
        }
        if(score==2)
        {
            Console.WriteLine(n + " Co la so nguyen to.");
        }
        else { Console.WriteLine(n + " Khong la so nguyen to."); }
        Console.WriteLine();
        Console.WriteLine("Bai7 Phan1: Liệt kê các số nguyên tố nhỏ hơn N.");
        if(n == 2)
        {
            Console.WriteLine("Khong co so nguyen to nao nho hon 2.");
        }
        else
        {
            for (int i = 2; i < n; i++) // Cho i chạy từ 2 và nhỏ hơn n để xét số nguyên tố nhỏ hơn 3
            {
                int score_2 = 0;
                for(int j = 1;  j <= i; j++) // Tạo 1 vòng for chạy j = 1 để tìm ra số nguyên tố i
                {
                    if(i%j == 0)
                    {
                        score_2++;  

                    }
                }
                if( score_2==2) { // Nếu score_2 == 2 thì là số nguyên tố và nhỏ hơn n
                    Console.WriteLine(i);
                }
            }
        }

    }
}

