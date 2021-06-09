using System.Linq;
using System.Xml.Serialization;

namespace Kieunvph14806_ASSigment
{
    //Tìm kiếm(Tìm kiếm theo tên và số điện thoại gần đúng sử dụng LINQ)
    partial class Service
    {
        public void TimKiemGanDung()
        {
            
        }

        public void Ten()
        {
            _input = Mess(" các ký tự để tìm tên: ");
            foreach (var x in _lstDanhBas.Where(c=>c.Ten.Contains(_input)))
            {
                x.InRaManHinh();
            }
        }

        public void Sodt()
        {
            _input = Mess(" chuỗi số để tìm Liên lạc bạn cần: ");
            foreach (var x in _lstDanhBas.Where(c=>c.Sdt1.Contains(_input)).ToList())
            {
                x.InRaManHinh();
            }
            foreach (var x in _lstDanhBas.Where(c=>c.Ssdt2.Contains(_input)).ToList())
            {
                x.InRaManHinh();
            }
        }

    }
}