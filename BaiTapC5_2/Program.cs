using System;
class Program
{

    static void Main(string[] args)
    {
        string yn;
        do
        {
            Console.WriteLine("Nhap vao phan muon chay (1,2,3,4):");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Phan1();
                    break;
                case 2:
                    Phan2();
                    break;
                case 3:
                    Phan3();
                    break;
                default:
                    Console.WriteLine("Nhap sai");
                    break;
            }
            Console.WriteLine("Ban co muon chay tiep chuong trinh ko (y/n?)");
            yn = Console.ReadLine();
            if (yn == "y")
            {
                Console.WriteLine("Chay tiep ");
            }
            else {
                Console.WriteLine("Dung CT");
                break; }
        } while (yn != "n");
    }

    static void Phan1()
    {
        Bai1_Phan1();
        Bai2_Phan1();
        Bai3_Phan1();
        Bai4_Phan1();
        Bai5_Phan1();
        Bai6_Phan1();
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
            Console.WriteLine("S = " + sum);
        }
        static void Bai2_Phan1()
        {
            Console.WriteLine("Bai2 Phan1: Tính tổng S(n) = 1^2 + 2^2 + … + n^2");
            Console.Write("Nhap phan tu n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
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
                sum += 1 / (i * 2);
            }
            Console.WriteLine("S = " + sum);
        }
        static void Bai4_Phan1()
        {
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
                    if (a % j == 0 && b % j == 0)
                    {
                        UCLN = j;
                    }
                }
            }
            Console.WriteLine("Uoc chung lon nhat = " + UCLN);
            for (int i = 1; i <= c; i++)
            {
                if (i % a == 0 && i % b == 0)
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
        static void Bai6_Phan1()
        {
            Console.WriteLine("Bai6 Phan1: Kiểm tra số N có phải là số nguyên tố không?");
            Console.WriteLine("Nhap vao 1 so nguyen n = ");
            int n = int.Parse(Console.ReadLine());
            int score = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    score++;
                }
            }
            if (score == 2)
            {
                Console.WriteLine(n + " Co la so nguyen to.");
            }
            else { Console.WriteLine(n + " Khong la so nguyen to."); }
            Console.WriteLine();
            Console.WriteLine("Bai7 Phan1: Liệt kê các số nguyên tố nhỏ hơn N.");
            if (n == 2)
            {
                Console.WriteLine("Khong co so nguyen to nao nho hon 2.");
            }
            else
            {
                for (int i = 2; i < n; i++) // Cho i chạy từ 2 và nhỏ hơn n để xét số nguyên tố nhỏ hơn 3
                {
                    int score_2 = 0;
                    for (int j = 1; j <= i; j++) // Tạo 1 vòng for chạy j = 1 để tìm ra số nguyên tố i
                    {
                        if (i % j == 0)
                        {
                            score_2++;

                        }
                    }
                    if (score_2 == 2)
                    { // Nếu score_2 == 2 thì là số nguyên tố và nhỏ hơn n
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
    static void Phan2()
    {
        Bai1_Phan2();
        static void Bai1_Phan2()
        {
            Console.WriteLine("Nhap vao so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap list[" + i + "]: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang vua nhap: ");
            PrintArray(list);
            /*
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(list[i]);
            }
            */
            Console.WriteLine("Cac phan tu chan va nho hon 20: ");
            for (int i = 0; i < n; i++)
            {
                if (list[i] % 2 == 0 && list[i] < 20)
                {
                    Console.WriteLine(list[i]);
                }
            }
            static void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
    static void Phan3()
    {
        Bai1_Phan3();
        static void Bai1_Phan3()
        {
            Console.WriteLine("Phan III: Bai tap xu li chuoi");
            Console.Write("Nhap vao mot chuoi: ");
            string chuoi = Console.ReadLine();
            Console.WriteLine("Chuoi vua nhap: " + chuoi);
            string[] list = chuoi.Split(" ");
            chuoi = string.Join("", list);
            int score = chuoi.Length;
            Console.WriteLine("So tu trong chuoi: " + score);
            Console.WriteLine("Remove Space trong chuoi: " + chuoi);

            Console.Write("Nhap vao chuoi moi: ");
            string abc = Console.ReadLine();
            Console.WriteLine("Chuoi vua nhap: " + abc);
            string[] listabc = new string[abc.Length];
            for (int i = 0; i < abc.Length; i++)
            {
                listabc[i] = abc.Substring(i, 1);
            }
            for (int i = 0; i < abc.Length; i++)
            {
                if (listabc[i] != " ")
                {
                    Console.WriteLine("Ki tu dau tien xuat hien tai vi tri " + (i + 1));
                    break;
                }
            }
            Console.Write("nhap vao 1 ki tu: ");
            string x = Console.ReadLine();

            for (int i = 0; i < abc.Length; i++)
            {
                if (x == listabc[i])
                {
                    Console.WriteLine("Ki tu " + x + " xuat hien tai vi tri " + (i + 1));
                }

            }
        }
    }
    static void Phan4()
    {

    }
}

