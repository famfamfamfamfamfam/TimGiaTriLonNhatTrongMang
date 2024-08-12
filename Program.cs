using System;

namespace MANGMOTCHIEU
{
    class TimPhanTuLonNhatTrongMang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so ty phu co khoi tai san can so sanh:");
            byte n = byte.Parse(Console.ReadLine());
            if (n>20)
            {
                Console.WriteLine("Vuot qua so luong co the xet");
                return;
            }
            long[] danhsachtaisan = new long[n];
            long max = danhsachtaisan[0];
            int vitri = 1;
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Nhap tai san cua nguoi thu {0}: ", i+1);
                danhsachtaisan[i] = int.Parse(Console.ReadLine());
                if(danhsachtaisan[i]>max)
                {
                    max = danhsachtaisan[i];
                    vitri = i + 1;
                }
            }
            Console.WriteLine("Tai san lon nhat co gia tri {0} thuoc ve vi thu {1}", max, vitri);
        }
    }
}