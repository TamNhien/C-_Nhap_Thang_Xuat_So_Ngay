using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so thang (tu 1 den 12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam: ");
        int year = int.Parse(Console.ReadLine());

        int days = DateTime.DaysInMonth(year, month);

        Console.WriteLine($"So ngay trong thang {month} nam {year} la: {days}");
    }
    static int DaysInMonth(int month, int year)
    {
        if (month == 2)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? 29 : 28;
        }
            return month == 4 || month == 6 || month == 9 || month == 11 ? 30 : 31;
    }
}

