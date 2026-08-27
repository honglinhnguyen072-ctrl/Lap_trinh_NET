using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Nhap so a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap so b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap phep toan (+, -, *, /, %): ");
        char op = char.Parse(Console.ReadLine()!);

       
        string result = (op, b) switch
        {
            ('+', _) => (a + b).ToString("F2"),
            ('-', _) => (a - b).ToString("F2"),
            ('*', _) => (a * b).ToString("F2"),
            ('/', 0) => "Loi: Khong the chia cho 0!",
            ('/', _) => (a / b).ToString("F2"),
            ('%', 0) => "Loi: Khong the chia cho 0!",
            ('%', _) => (a % b).ToString("F2"),
            _ => "Loi: Phep toan khong hop le!"
        };

        
        Console.WriteLine($"Ket qua: {result}");
    }
}