using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("             CHUONG TRINH QUAN LY             ");
            Console.WriteLine("==============================================");
            Console.WriteLine("1. Chay Bai tap 3.1 (Calculator)");
            Console.WriteLine("2. Chay Bai tap 3.2 (Phuong trinh bac 2)");
            Console.WriteLine("3. Chay Bai tap 3.3 (So nguyen to & Fibonacci)");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.WriteLine("==============================================");
            Console.Write("Lựa chon cua ban (0-3): ");

            // Kiem tra dau vào tranh loi khi nhap ky tu khong phai so
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1; // Gan gia tri khong hop le de nhay vao default
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    RunCalculator();
                    Pause();
                    break;
                case 2:
                    RunQuadraticEquation();
                    Pause();
                    break;
                case 3:
                    RunNumberAnalysis();
                    Pause();
                    break;
                case 0:
                    Console.WriteLine("Tam biet! Cam on ban da su dung chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon tu 0 den 3!");
                    Pause();
                    break;
            }

        } while (choice != 0);
    }

   
    static void Pause()
    {
        Console.WriteLine("\nNhan phim bat ky de quay lai Menu...");
        Console.ReadKey();
    }

    
    static void RunCalculator()
    {
        Console.WriteLine("--- BAI TAP 1: CALCULATOR ---");
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

    
    static void RunQuadraticEquation()
    {
        Console.WriteLine("--- BAI TAP 2: GIAI PHUONG TRINH BAC 2 ---");
        Console.Write("Nhap he so a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap he so b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap he so c: ");
        double c = double.Parse(Console.ReadLine()!);

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                else
                    Console.WriteLine("Vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh bac nhat co 1 nghiem x = {x:F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1:F2}, x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Nghiem kep x = {x:F2}");
            }
            else
            {
                Console.WriteLine("Vo nghiem.");
            }
        }
    }

    
    static void RunNumberAnalysis()
    {
        Console.WriteLine("--- BAI TAP 3: SO NGUYEN TO & FIBONACCI ---");
        Console.Write("Nhap N: ");
        int N = int.Parse(Console.ReadLine()!);

        if (N <= 0)
        {
            Console.WriteLine("Vui long nhap so nguyen duong N > 0!");
            return;
        }

        if (IsPerfectNumber(N))
            Console.Write($"{N} la So hoan hao! ");
        else
            Console.Write($"{N} KHONG la So hoan hao! ");

        if (IsPrime(N))
            Console.WriteLine($"{N} la So nguyen to.");
        else
            Console.WriteLine($"{N} KHONG la So nguyen to.");

        PrintFibonacci(N);
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 0) return false;
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0) sum += i;
        }
        return sum == n;
    }

    static void PrintFibonacci(int n)
    {
        if (n <= 0) return;

        long a = 0, b = 1;
        Console.Write($"Day Fibonacci {n} so: ");

        int count = 0;
        while (count < n)
        {
            if (count == n - 1)
                Console.Write(a);
            else
                Console.Write(a + ", ");

            long next = a + b;
            a = b;
            b = next;
            count++;
        }
        Console.WriteLine();
    }
}
