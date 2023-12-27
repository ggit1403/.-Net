using System;
using System.Threading.Tasks.Dataflow;

class Bai4
{
    struct SinhVien
    {
        public int MSSV;
        public string HoTen;
        public double diemToan;
        public double diemTriet;
        public double diemNet;
    }
    static SinhVien NhapDL()
    {
        // Nhap MSSV
        SinhVien infoStudent;
        Console.WriteLine("Nhap MSSV: ");
        infoStudent.MSSV = int.Parse(Console.ReadLine());
        //Nhap ho ten
        Console.WriteLine("Nhap Ho va Ten: ");
        infoStudent.HoTen = Console.ReadLine();
        infoStudent.HoTen = infoStudent.HoTen.Trim();

        string[] names = infoStudent.HoTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] != null)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1).ToLower();
            }
        }

        string name = string.Join(" ", names);
        infoStudent.HoTen = name;
        // Nhap diem toan
        Console.WriteLine("Nhap diem Toan: ");
        infoStudent.diemToan = double.Parse(Console.ReadLine());
        while(infoStudent.diemToan < 0 || infoStudent.diemToan > 10) {
            Console.WriteLine("Ban nhap sai vui long nhap lai: ");
            infoStudent.diemToan = double.Parse(Console.ReadLine());
        }
        //Nhap diem Triet
        Console.WriteLine("Nhap diem Triet: ");
        infoStudent.diemTriet = double.Parse(Console.ReadLine());
        while (infoStudent.diemTriet < 0 || infoStudent.diemTriet > 10)
        {
            Console.WriteLine("Ban nhap sai vui long nhap lai: ");
            infoStudent.diemTriet = double.Parse(Console.ReadLine());
        }
        // Nhap diem Net
        Console.WriteLine("Nhap diem Net: ");
        infoStudent.diemNet = double.Parse(Console.ReadLine());
        while (infoStudent.diemNet < 0 || infoStudent.diemNet > 10)
        {
            Console.WriteLine("Ban nhap sai vui long nhap lai: ");
            infoStudent.diemNet= double.Parse(Console.ReadLine());
        }

        double diemTB = (infoStudent.diemToan + infoStudent.diemTriet + infoStudent.diemNet) / 3;

        Console.WriteLine("MSSV: " + infoStudent.MSSV);
        Console.WriteLine("Ho va ten: " + infoStudent.HoTen);
        Console.WriteLine("Diem Toan: " + infoStudent.diemToan);
        Console.WriteLine("Diem Triet: " + infoStudent.diemTriet);
        Console.WriteLine("Diem Net: " + infoStudent.diemNet);
        Console.WriteLine("Diem trung binh: " +diemTB);
        Console.WriteLine();
        return infoStudent;
    }
    static void bai3()
    {
        Console.WriteLine("Bai 3:");
        Console.WriteLine("Nhap mot chuoi ky tu: ");
        string list = Console.ReadLine();
        string[] listtext = new string[list.Length];
        int n = list.Length;
        for (int i = 0; i < n; i++)
        {
            listtext[i] = list.Substring(i,1);
        }
        Array.Reverse(listtext);
        string text = string.Join("", listtext);
        
        Console.WriteLine(text);
    }

    static void bai4() {
        Console.WriteLine("Bai 4:");
        Console.WriteLine("Nhap xau ngay thang nam dang dd/mm/yyyy: ");
        string day = Console.ReadLine();
        string[] cut = day.Split('/');
        while (cut.Length != 3) {
            Console.WriteLine("Ban nhap sai, vui long nhap dung dinh dang");
            day = Console.ReadLine();
            cut = day.Split('/');
        }
        
        Console.WriteLine("Ngay thang nam da nhap: " + day);
        if (cut[0].Length == 1)
        {
            Console.WriteLine("Xau ngay: 0" + cut[0]);
        }
        else
        {
            Console.WriteLine("Xau ngay: " + cut[0]);
        }

        if (cut[1].Length == 1)
        {
            Console.WriteLine("Xau thang: 0" + cut[1]);
        }
        else
        {
            Console.WriteLine("Xau thang: " + cut[1]);
        }
        
        Console.WriteLine("Xau nam: " + cut[2]);
    }

    static void bai5()
    {
        Console.WriteLine("Bai 5:");
        Console.WriteLine("Nhap xau: ");
        string xau = Console.ReadLine();
        string[] list = new string[xau.Length];
        for (int i = 0;i < list.Length;i++)
        {
            list[i] = xau.Substring(i,1);
        }
        string list_reverse;
        int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == list[list.Length-i-1])
                {
                    sum++;
                }
                
            }
        if(sum == list.Length)
        {
            Console.WriteLine("Xau doi xung");
        }
        else
        {
            Console.WriteLine("Xau ko doi xung");
            Console.WriteLine("Tien hanh dao nguoc xau");
            Array.Reverse(list);
            list_reverse = string.Join("", list);
            Console.WriteLine(list_reverse);
        }
    }

    static void Main(string[] args)
    {

        int n;
        string yn;
        do
        {
            Console.Write("Nhap bai muon chay(1,3,4,5): ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    SinhVien infoST = NhapDL();
                    break;
                case 3:
                    bai3();
                    break;
                case 4:
                    bai4();
                    break;
                case 5:
                    bai5();
                    break;
                default: Console.WriteLine("Lua chon ko hop le");
                    break;
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
        } while (yn != "n");
        
    }

}
