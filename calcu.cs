using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RandomFunctions
{
    // 1. Hàm kiểm tra số nguyên tố
    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // 2. Hàm tạo chuỗi ngẫu nhiên
    public static string RandomString(int length = 10)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random rand = new Random();
        return new string(Enumerable.Repeat(chars, length)
                            .Select(s => s[rand.Next(s.Length)]).ToArray());
    }

    // 3. Hàm tính giai thừa đệ quy
    public static long Factorial(int n)
    {
        return (n == 0) ? 1 : n * Factorial(n - 1);
    }

    // 4. Hàm kiểm tra chuỗi có phải palindrome không
    public static bool IsPalindrome(string s)
    {
        string rev = new string(s.Reverse().ToArray());
        return s.Equals(rev, StringComparison.OrdinalIgnoreCase);
    }

    // 5. Hàm tìm số Fibonacci thứ n
    public static int Fibonacci(int n)
    {
        int a = 0, b = 1, temp;
        for (int i = 0; i < n; i++)
        {
            temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    // 6. Hàm đếm số từ trong một chuỗi
    public static int WordCount(string input)
    {
        return input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // 7. Hàm đổi chỗ hai biến mà không cần biến tạm
    public static void Swap(ref int a, ref int b)
    {
        a ^= b;
        b ^= a;
        a ^= b;
    }

    // 8. Hàm tìm số lớn nhất trong danh sách
    public static int MaxInList(List<int> numbers)
    {
        return numbers.Count > 0 ? numbers.Max() : throw new ArgumentException("Danh sách rỗng!");
    }

    // 9. Hàm chuyển đổi nhiệt độ từ Celsius sang Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // 10. Hàm tạo danh sách số ngẫu nhiên
    public static List<int> GenerateRandomNumbers(int count, int min, int max)
    {
        Random random = new Random();
        return Enumerable.Range(0, count).Select(_ => random.Next(min, max)).ToList();
    }

    // Chạy thử nghiệm
    static void Main()
    {
        Console.WriteLine("Số nguyên tố: " + IsPrime(17));
        Console.WriteLine("Chuỗi ngẫu nhiên: " + RandomString());
        Console.WriteLine("Giai thừa của 5: " + Factorial(5));
        Console.WriteLine("Palindrome: " + IsPalindrome("madam"));
        Console.WriteLine("Số Fibonacci thứ 10: " + Fibonacci(10));
        Console.WriteLine("Số từ trong câu: " + WordCount("ChatGPT là AI mạnh mẽ"));
        
        int x = 3, y = 7;
        Swap(ref x, ref y);
        Console.WriteLine($"Hoán đổi: x = {x}, y = {y}");

        List<int> numbers = new List<int> { 1, 9, 3, 7, 5 };
        Console.WriteLine("Số lớn nhất: " + MaxInList(numbers));
        Console.WriteLine("25 độ C -> Fahrenheit: " + CelsiusToFahrenheit(25));
        Console.WriteLine("Danh sách số ngẫu nhiên: " + string.Join(", ", GenerateRandomNumbers(5, 1, 100)));
    }
}
