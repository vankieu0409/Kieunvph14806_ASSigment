
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kieunvph14806_ASSigment
{//Nguoi.Class(Lớp cha - Bao gồm các thuộc tính: Ho, Ten, TenDem, NamSinh, GioITinh - inRaManHinh())
    class Nguoi
    {
        private string ho;
        private string tenDem;
        private string ten;
        private int namSinh;
        private string gioiTinh;

        public Nguoi()
        {

        }

        public Nguoi(string ho, string tenDem, string ten, int namSinh, string gioiTinh)
        {
            this.ho = ho;
            this.tenDem = tenDem;
            this.ten = ten;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public string TenDem
        {
            get => tenDem;
            set => tenDem = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public virtual void InRaManHinh()
        {
            Console.WriteLine("  {0}\n" +
                              " Năm Sinh: {1}\n" +
                              " Giới Tính: {2}", ho + " " + tenDem + " " + ten, namSinh, gioiTinh);
        }
    }
}
