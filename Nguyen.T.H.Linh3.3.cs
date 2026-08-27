using System;

class Program
{
    
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

    static void Main()
    {
       
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
}
