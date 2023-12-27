using System;

class bai2
{


    static void Main(string[] args)
    {
        int nam;
        string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh",
            "Dinh", "Mau", "Ky" };
        string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao",
            "Thin", "Ty", "Ngo", "Mui" };
        Console.Write("Nhap nam duong lich: ");
        nam = int.Parse(Console.ReadLine());

        Console.WriteLine(nam+" co ten am lich la: {0} {1}", can[nam % 10], chi[nam % 12]);
        

    }

    
}
