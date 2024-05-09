using System;
using Bai3;

public class Program
{
    public static int Main(string[] args)
    {
        caculator caculator = new caculator(3,7);
        int resultCong = caculator.Cong();
        Console.WriteLine("cong: " + resultCong);
        int resultTru = caculator.Tru();
        Console.WriteLine("cong: " + resultTru);
        int resultNhan = caculator.Nhan();
        Console.WriteLine("cong: " + resultNhan);
        return 0;
    }
}