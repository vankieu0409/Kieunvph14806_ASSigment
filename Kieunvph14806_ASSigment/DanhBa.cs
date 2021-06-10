using System;

namespace Kieunvph14806_ASSigment
{
    [Serializable]
    //{DanhBa.Class(Lớp con - Kế thừa các thuộc tính của lớp cha Bao gồm các thuộc tính riêng của đối
    //    tượng như: Sdt1, Sdt2, Email, GhiChu, - Hàm ToString() và kế thừa hàm inRaManHinh() từ lớp cha)
    class DanhBa : Nguoi
    {
        private string sdt1;
        private string ssdt2;
        private string email;
        private string ghiChu;

        public DanhBa()
        {

        }

        public DanhBa(string sdt1, string ssdt2, string email, string ghiChu)
        {
            this.sdt1 = sdt1;
            this.ssdt2 = ssdt2;
            this.email = email;
            this.ghiChu = ghiChu;
        }

        public DanhBa(string ho, string tenDem, string ten, int namSinh, int gioiTinh, string sdt1, string ssdt2, string email, string ghiChu) : base(ho, tenDem, ten, namSinh, gioiTinh)
        {
            this.sdt1 = sdt1;
            this.ssdt2 = ssdt2;
            this.email = email;
            this.ghiChu = ghiChu;
        }

        public string Sdt1
        {
            get => sdt1;
            set => sdt1 = value;
        }

        public string Ssdt2
        {
            get => ssdt2;
            set => ssdt2 = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string GhiChu
        {
            get => ghiChu;
            set => ghiChu = value;
        }

        public override void InRaManHinh()
        {
            Console.Write((GioiTinh == 1) ? "Anh " : (GioiTinh == 0) ? "Chị" : "");
            Console.WriteLine("  {0}\n" +
                              " Năm Sinh: {1}\n" +
                              " Giới Tính: {2}\n" +
                              " Số điện thoại: {3} - {4}\n" +
                              " Email: {5}\n" +
                              " Ghi Chú: {6}", Ho + " " + TenDem + " " + Ten, NamSinh, GioiTinh == 1 ? "Nam" : GioiTinh == 0 ? "Nữ" : "", Sdt1, Ssdt2, Email, GhiChu);

        }
    }
}
