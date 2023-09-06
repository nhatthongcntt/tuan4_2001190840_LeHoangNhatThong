using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan4_2001190840_LeHoangNhatThong_7
{
    class HinhTron 
    {
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private float _x;

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        private float _y;

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public HinhTron()
        {

        }
        public HinhTron(string ten , float x, float y, double bankinh)
        {
            this._ten = ten;
            this._x = x;
            this._y = y;
            this.banKinh = bankinh;
        }
        public double TinhChuVi()
        {
            return BanKinh * 2 * Math.PI;
        }
        public double TinhDienTich()
        {
            return Math.Pow(BanKinh, 2) * Math.PI;
        }
        public void Nhap()
        {
            Console.WriteLine("nhập tên tọa độ: ");
            _ten = Console.ReadLine();
            Console.WriteLine("nhập tọa độ x: ");
            _x = float.Parse(Console.ReadLine());
            Console.WriteLine("nhập tọa độ y: ");
            _y = float.Parse(Console.ReadLine());
            Console.WriteLine("nhập bán kính: ");
            banKinh = double.Parse(Console.ReadLine());
        }
        public void Xuat() {
            Console.WriteLine("hình tròn có tọa độ: {0}({1},{2}) có bán kính:{3} có chu vi:{4} có diện tích:{5} ",_ten,_x,_y,banKinh,Math.Round(TinhChuVi(),3),Math.Round(TinhDienTich(),3));
            Console.WriteLine();
        }
    }
}
