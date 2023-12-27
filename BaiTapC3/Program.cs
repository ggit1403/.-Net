using System;

class BaitapC3{ 
   static void Main(string[] args){
        int n;
        string yn;
        do
        {
            Console.WriteLine("Nhap vao bai tap (tu 1 - 5): ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Bai1();
                        break;
                    }
                case 2:
                    {
                        Bai2();
                        break;
                    }
                case 3:
                    {
                        Bai3();
                        break;
                    }
                case 4:
                    {
                        Bai4();
                        break;
                    }
                case 5:
                    {
                        Bai5();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                    }
            }
            Console.WriteLine("Ban co muon chay tiep chuong trinh khong (y/n): ");
            yn = Console.ReadLine();
            if (yn == "y")
            {
                Console.WriteLine("Vui long nhap so bai: ");
            }
            else
            {
                Console.WriteLine("Dung chuong trinh!");
                break;
            }
        } while (yn == "y");
        
    
        void Bai1(){

            double a1, b1, c1, a2, b2, c2;
            Console.WriteLine("Nhap cac he so cua he pt bac nhat 2 an: ");
            Console.WriteLine("Nhap a1, b1, c1: ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap a2, b2, c2:");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());
            Console.WriteLine("He pt da nhap: ");
            Console.WriteLine(a1 + "x + " + b1 + "y = " + c1);
            Console.WriteLine(a2 + "x + " + b2 + "y = " + c2);
            if (a1 / a2 == b1 / b2 && b1 / b2 == c1 / c2)
            {
                Console.WriteLine("He pt co vo so nghiem");
            }
            else if (a1 / a2 == b1 / b2 && b1 / b2 != c1 / c2)
            {
                Console.WriteLine("He pt vo ngiem");
            }
            else if (a1 / a2 != b1 / b2)
            {
                Console.WriteLine("Pt co nghiem la: ");
                Console.WriteLine("x = " + ((c2 - b2 * c1) / (a2 - a1 * b2)));
                Console.WriteLine("y = " + ((c1 - a1 * c2) / (a2 - a1 * b2)));
            }
        }

        void Bai2()
        {
            //Bai2:

            Console.WriteLine("Bai 2:");
            Console.WriteLine("Nhap vao 2 gia tri cua pt bac nhat: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Phuong trinh bac nhat: " + x + "x + " + y + " = 0");
            if (x != 0 && y != 0)
            {
                Console.WriteLine("Phuong trinh co nghiem x = " + (-y / x));
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Phuong trinh co ngiem x = 0");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        void Bai3()
        {
            //Bai3:
            Console.WriteLine("Bai3:");
            Console.WriteLine("Nhap 3 gia tri cua pt bac 2: ");
            double u = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Phuong trinh bac 2: " + u + "x^2 + " + v + "x + " + w + " = 0");

            double deltar = v * v - 4 * u * w;
            Console.WriteLine(deltar);
            if (u == 0 && v == 0 && w != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (deltar > 0)
            {
                Console.WriteLine("PT co 2 nghiem phan biet: ");
                Console.WriteLine("Nghiem thu nhat x = " + (-v + Math.Sqrt(deltar) / (2 * u)));
                Console.WriteLine("Nghiem thu hai x = " + (-v - Math.Sqrt(deltar) / (2 * u)));
            }
            else if (deltar == 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem kep x = " + (-v / (2 * u)));
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }

        void Bai4()
        {
            // Bai4:
            Console.WriteLine("Bai 4:");
            Console.WriteLine("Nhap vao 10 gia tri bat ki cua mang: ");
            int[] number = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Nhap k = ");
            int k = int.Parse(Console.ReadLine());
            int value = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == k)
                {
                    value++;
                }
            }
            if (value == 0)
            {
                Console.WriteLine("k ko co trong mang");
            }
            else if (value > 0)
            {
                Console.WriteLine("k xuat hien " + value + " lan");
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == k)
                {
                    Console.WriteLine("k xuat hien tren vi tri so " + (i + 1));
                }
            }
        }
        void Bai5()
        {
            //Bai5:
            Console.WriteLine("Bai 5:");
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            //max

            int max = numbers[1];
            for (int i = 0; i < numbers.Length; i++)
            {

                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("So lon nhat trong mang la : " + max);
            // min
            int min = numbers[1];
            for (int i = 0; i < numbers.Length; i++)
            {

                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("So nho nhat trong mang la : " + min);
            //Sap xep tang dan giam dan c1
            Console.WriteLine("Sap xep giam dan va tang dan theo Sort() va Reverse() --test--");
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");

            }
            Console.WriteLine();
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            //Sap xep tang dan giam dan c2
            // tang dan
            Console.WriteLine();
            Console.WriteLine("Sap xep theo thuat toan: ");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int gan = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = gan;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            //giam dan
            Console.WriteLine();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int gan = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = gan;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
