using System;

namespace ThaoTacVoiMang
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bước 1: Khai báo mảng kiểu int , kích thước mảng là 5 phần tử

            int[] numbers = new int[5];
            //Bước 2: Sử dụng đoạn mã sau đây để thêm giá trị vào mảng bằng cách chèn vào các vị trí

            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            // Bước 3: Sử dụng đoạn mã sau đây in ra một vài giá trị của mảng

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            //Bước 3: Để tính tổng các phần tử của mảng, chúng ta sử dụng vòng lặp.

            Console.WriteLine("Tong cua mang la : {0}",tongmang(numbers));
        }

        static int tongmang(int []a)
        {
            
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total = total + a[i];
            }
            return total;
        }
    }
}
