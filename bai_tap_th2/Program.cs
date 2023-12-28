/*using System;
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
}*/
using System;
using System.Drawing;

class ConCua
{
    public static void Main(string[] args)
    {
        // Khởi tạo đối tượng Graphics
        Graphics g = Graphics.FromHwnd(IntPtr.Zero);

        // Vẽ thân con cua
        g.FillEllipse(Brushes.Red, 100, 100, 200, 200);

        // Vẽ càng cua
        g.DrawLine(Pens.Black, 100, 100, 50, 50);
        g.DrawLine(Pens.Black, 300, 100, 350, 50);

        // Vẽ chân cua
        g.DrawLine(Pens.Black, 100, 200, 50, 250);
        g.DrawLine(Pens.Black, 300, 200, 350, 250);

        // Vẽ mắt cua
        g.FillEllipse(Brushes.Black, 150, 125, 25, 25);
        g.FillEllipse(Brushes.Black, 250, 125, 25, 25);

        // Hiển thị hình con cua
        g.Show();
    }
}

