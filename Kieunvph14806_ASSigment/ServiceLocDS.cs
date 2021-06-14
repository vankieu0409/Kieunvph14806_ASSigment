using System;
using System.Collections.Generic;
using System.Linq;

namespace Kieunvph14806_ASSigment
{
    partial class Service
    {
      //  public List<DanhBa> _lstXuat;
        public void LocDanhSach()
        {
            do
            {
                Console.Write(" 1. lọc theo nhà mạng.\n" +
                              " 2. lọc theo tên\n" +
                              " 3. lọc theo giới tính\n" +
                              " 4. LỌc theo chữ cái bắt đầy" +
                              " 0. thoát" +
                              " Mời bạn chọn CT: ");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        theoNHaMang();
                        break;
                    case "2":
                        SapXepTheoten();
                        break;
                    case "3":
                        SAPxeptheoGioiTinh();
                        break;
                    case "4":
                        ChuCaiBatDau();
                        break;

                    case "0":
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine(" chương trình không có. MỜi chọn lại");
                        break;

                }
                Console.WriteLine("                     *");
            } while (!(_input == "0"));
        }

        private void theoNHaMang()
        {
            Console.WriteLine(" Những người dùng nhà mạng Việttel");
            var temp1 = _lstDanhBas.Where(c =>
                c.Sdt1.StartsWith("098") && c.Ssdt2.StartsWith("098") && c.Sdt1.StartsWith("03") &&
                c.Ssdt2.StartsWith("03")).ToList();
            if (temp1.Count==0)  Console.WriteLine("Ko có người dùng");
            foreach (var x in temp1)
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }
            
            Console.WriteLine(" \n" +
                              "\n" +
                              " Người dùng nhà  VInaphone");
            var temp2 = _lstDanhBas.Where(c => c.Sdt1.StartsWith("08") && c.Ssdt2.StartsWith("08")).ToList();
            if (temp2.Count==0) Console.WriteLine("Ko có người dùng ");
            foreach (var x in temp2)
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }

        }

        private void ChuCaiBatDau()
        {
            string k = Mess(" chữ cái đầu: ");
            var temp2 = _lstDanhBas.Where(c => c.Ten.StartsWith(k)).ToList();
            if (temp2.Count == 0) Console.WriteLine("Ko có người nào có tên bắt đầu bằng chữ "+ k);
            Console.WriteLine("danh sách người có tên bắt đầu bằng "+k);
            foreach (var x in temp2)
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }
        }
        private void SapXepTheoten()
        {
            flag = 4;
            _lstDanhBas=_lstDanhBas.OrderBy(c => c.Ten).ToList();
            Console.WriteLine(" DS SẮP xếp theo tên theo A => Z");
            foreach (var x in _lstDanhBas.OrderBy(c => c.Ten).ToList())
            {
                x.InRaManHinh();
                
            }
        }

        private void SAPxeptheoGioiTinh()
        {
            Console.WriteLine(" Danh Bạ  liên lạc là Nam");
            foreach (var x in _lstDanhBas.Where(c => c.GioiTinh == 1).ToList())
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }

            Console.WriteLine("\n");
            Console.WriteLine(" Danh Bạ  liên lạc là Nữ");
            foreach (var x in _lstDanhBas.Where(c => c.GioiTinh == 1).ToList())
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }
        }
    }
}
