using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan4_2001190840_LeHoangNhatThong_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HinhTron ht = new HinhTron();
            ht.Nhap();
            ht.Xuat();
            Console.ReadLine();
        }
    }
}
