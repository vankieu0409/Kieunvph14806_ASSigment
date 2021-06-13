using System;
using System.Text;

namespace Kieunvph14806_ASSigment
{/*
  * Viết 1 chương trình quản lý danh bạ điện thoại FPOLY dựa theo các yêu cầu sau
    Cấu trúc Project bao gồm:
    Program.Class(Bao gồm hàm, menu)
    -- Nguoi.Class(Lớp cha - Bao gồm các thuộc tính: Ho, Ten, TenDem, NamSinh, GioITinh - inRaManHinh())
    -- DanhBa.Class(Lớp con - Kế thừa các thuộc tính của lớp cha Bao gồm các thuộc tính riêng của
     đối tượng như:  Sdt1, Sdt2, Email, GhiChu, - Hàm ToString() và kế thừa hàm inRaManHinh() từ lớp cha)
    -- DanhBaService.Class(Bao gồm các chức năng của bài toán)
    Các chức năng chương trình cần có:
    Quản lý danh bạ(FAKE 10 NGƯỜI -THÊM - SỬA - XÓA - IN ĐỐI TƯỢNG - Sắp xếp tăng hoặc giảm)
    Lọc danh bạ(THEO NHÀ MẠNG - THEO BẢNG CHỮ CÁI - THEO TÊN - THEO GIỚI TÍNH sử dụng LINQ)
    Tìm kiếm(Tìm kiếm theo tên và số điện thoại gần đúng sử dụng LINQ)
    Lưu trữ danh bạ(Mở file load data, Lưu File save data)
    Thoát chương trình(Cảnh báo được cho người dùng nếu người dùng quên chưa lưu file trong trường hợp data bị thay đổi)
    Cách thức lấy điểm
    Hoàn thành mức độ cơ bản của bài toán không á dụng các kiến thức được học đạt tối đa 7 điểm.
    Có áp dụng được các kiến thức sau:
    Sử dụng LINQ + 1 Điểm
    Sử dụng Delegate + 1 Điểm
    Check lỗi nhập vào người dùng hoặc Generic + 1 điểm
    */
    

    class Program
    {
        public static IService pt = new Service();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            DelegateCallBack delegateCallback = new DelegateCallBack(DelegateMain);

            do
            {
                CallBack(delegateCallback);

            } while (true);

        }

        public delegate void DelegateCallBack(string lenh); // khai báo delegate


        public static void DelegateMain(string lenh)
        {

            switch (lenh)
            {
                case "1":
                    pt.QuanLyDnhBa(); Console.WriteLine(""); ; break;
                case "2":
                    pt.LocDanhSach(); Console.WriteLine(""); break;
                case "3":
                     pt.TimKiemGanDung();Console.WriteLine(""); break;
                case "4":
                    pt.QLDocGhi();
                    Console.WriteLine(); break;
                case "0":
                    pt.MessSaveFile(); break;
                default: Console.WriteLine(" CT đang phát triển"); break;
            }
            Console.WriteLine("");


        }

        public static void CallBack(DelegateCallBack delegateCallback)
        {
            Console.Write("----------- Danh sách ct ----------\n" +
                                        " 1. Quản lý danh bạ\n" +
                                        " 2. LỌc Danh bạ\n" +
                                        " 3. Tìm Kiếm danh bạ\n" +
                                        " 4. Đọc ghi file\n"+
                                        " 0. THoát CT\n" +
                                        " MỜi bạn chọ CT: ");

            var lenh = Console.ReadLine();
            delegateCallback(lenh);// gọi qua delegate

        }
    }
}
