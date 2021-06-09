using System;
using System.Collections.Generic;
using System.Linq;

namespace Kieunvph14806_ASSigment
{
    partial class Service
    {
        public void LocDanhSach()
        {
            do
            {
                Console.Write(" 1. lọc theo nhà mạng.\n" +
                              " 2. lọc theo tên\n" +
                              " 3. lọc theo giới tính\n" +
                              " 0. thoát" +
                              " Mời bạn chọn CT: ");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1": theoNHaMang(); break;
                    case "2": SapXepTheoten(); break;
                    case "3": SAPxeptheoGioiTinh(); break;

                    case "0": Console.WriteLine(""); break;
                    default:
                        Console.WriteLine(" chương trình không có. MỜi chọn lại");
                        break;

                }

            } while (!(_input == "0"));
        }

        public void theoNHaMang()
        {
            Console.WriteLine(" Những người dùng Việttel");
            foreach (var x in _lstDanhBas.Where(c => c.Sdt1.StartsWith("098")).ToList())
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }
            foreach (var x in _lstDanhBas.Where(c => c.Ssdt2.StartsWith("098")).ToList())
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }
            Console.WriteLine(" \n" +
                "\n" +
                " Người dùng VInaphone");
            foreach (var x in _lstDanhBas.Where(c => c.Sdt1.StartsWith("085")).ToList())
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }
            foreach (var x in _lstDanhBas.Where(c => c.Ssdt2.StartsWith("085")).ToList())
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }

        }
        public void SapXepTheoten()
        {
            foreach (var x in _lstDanhBas.OrderBy(c => c.Ten).ToList())
            {
                x.InRaManHinh();
                Console.WriteLine("----------");
            }
        }
        public void SAPxeptheoGioiTinh()
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
        }em đi ngủ đây hehe . 
    } không cho đi ngủ
    cứ ngủ haha
    
    mai e gọi 
    nay có bạn ở đây 
    hehe
    đi ngủ không bấm máy tính nó chửi 
    bye bye 
    
    ....
    kệ nó đi
   
    e ngủ mai hk ca 1
    thức đi
    học xong ca1 thì ngủ
    hk cả ca 2
    chiều đi làm
    bye bye a nhá 
    ngủ ngon nà
    
    ngủ ngon nà!!😚😚😚😚😚😚❤❤❤❤❤

}
