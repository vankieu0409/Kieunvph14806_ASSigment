using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Serialization;

namespace Kieunvph14806_ASSigment
{
    //Tìm kiếm(Tìm kiếm theo tên và số điện thoại gần đúng sử dụng LINQ)
    partial class Service 
    {
        private string lenh;
        public void TimKiemGanDung()
        {
            do
            {
                Console.WriteLine(" ct tìm kiếm gần đúng\n" +
                                  " 1. nhập 1 ký tự để tìm Liên lạc có ký tự đó." +
                                  " 2. nhập 1 chuỗi số để  tìm liên lạc có chuỗi số đó.");
                lenh = Console.ReadLine();
                switch (lenh)
                {
                    case "1":Ten();break;
                    case "2":Sodt();break;
                    case "0": Console.WriteLine(" bai bai");break;
                    default: Console.WriteLine(" chương trinh đang pất triển");
                        break;
                }
                Console.WriteLine("                     *");
            } while (!(lenh=="0"));
            Console.WriteLine("\n");

        }

        private void Ten()
        {
            _input = Mess(" các ký tự để tìm tên: ");
            foreach (var x in _lstDanhBas.Where(c=>c.Ten.Contains(_input)))
            {
              x.InRaManHinh();
            }

            
        }

        private void Sodt()
        {
            _input = Mess(" chuỗi số để tìm Liên lạc bạn cần: ");
            foreach (var x in _lstDanhBas.Where(c => c.Sdt1.Contains(_input) && c.Ssdt2.Contains(_input)).ToList())
            {
                x.InRaManHinh();
            }
            
        }
        
    }
}