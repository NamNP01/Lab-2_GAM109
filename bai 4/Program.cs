using System;
using System.Collections.Generic;

static class ListExtensions
{
    // hien thi
    public static void ShowList<T>(this List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {list[i]}");
        }
    }

    // tong nguyen
    public static float SumIntegers(this List<float> list)
    {
        float sum = 0;
        foreach (var item in list)
        {
            if (IsInteger(item))
            {
                sum += item;
            }
        }
        return sum;
    }

    // tong nguyen to
    public static float SumPrimes(this List<float> list)
    {
        float sum = 0;
        foreach (var item in list)
        {
            if (IsPrime(item))
            {
                sum += item;
            }
        }
        return sum;
    }

    // tong so chan o vi tri le
    public static float SumEvenAtOddIndices(this List<float> list)
    {
        float sum = 0;
        for (int i = 0; i < list.Count; i += 2)
        {
            if (IsInteger(list[i]) && list[i] % 2 == 0)
            {
                sum += list[i];
            }
        }
        return sum;
    }

    // kiem tra so nguyen
    private static bool IsInteger(float number)
    {
        return number == (int)number;
    }

    // kiemtra so nguyen to
    private static bool IsPrime(float number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        List<float> numberList = new List<float>(); // Khai báo một danh sách số nguyên
        // Thêm các số nguyên vào danh sách
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);
        // nhap them
        Console.WriteLine("Nhap them so: ");
        Console.WriteLine("So Luong them: ");
        int soLuong = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine("Nhap so: ");
            String so = Console.ReadLine();
            numberList.Add(Convert.ToInt32(so));
        }

        // Yêu cầu 1. Hiển thị danh sách các số nguyên
        Console.WriteLine("Danh sach so nguyen:");
        numberList.ShowList();

        // Yêu cầu 2. Tính tổng các số nguyên trong danh sách
        Console.WriteLine("Tong cac so nguyen trong danh sach: " + numberList.SumIntegers());

        // Yêu cầu 3. Tính tổng các số nguyên tố trong danh sách trong danh sách
        Console.WriteLine("Tong cac so nguyen to trong danh sach: " + numberList.SumPrimes());

        // Yêu cầu 4. Tính tổng các số chẵn ở vị trí lẻ trong danh sách
        Console.WriteLine("Tong cac so chan o vi tri le trong danh sach: " + numberList.SumEvenAtOddIndices());
        Console.ReadLine();
    }
}
