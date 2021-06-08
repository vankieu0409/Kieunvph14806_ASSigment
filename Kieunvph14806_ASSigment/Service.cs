using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Kieunvph14806_ASSigment
{
    public class Service
    {

        private List<DanhBa> _lstDanhBas;
        private DanhBa nguoi = new DanhBa();// Danh Bạ(): là contructor có tham số
        private string _input;

        public Service()
        {
            _lstDanhBas = new List<DanhBa>();
            DanhBa nguoi1 = new DanhBa("Nguyễn", "Văn", "Kiều", 1998, "Nam", "0382802345", "0857326448",
                " vankieu0409@gmail.com", "Hiền Huynh");
            DanhBa nguoi2 = new DanhBa("Lê", "Thị", "Phương", 1998, "Nữ", "0389062345", "08573209006",
                " hiplee0906@gmail.com", "Honey");
            DanhBa nguoi3 = new DanhBa("Nguyễn", "Văn", "Phương", 2001, "Nam", "0382803456", "0857326848",
                " phuongCsharp@gmail.com", "Tiểu đệ C#");
            DanhBa nguoi4 = new DanhBa("Hoàng", "Thị", "Hải", 2002, "Nữ", "0382804567", "08599885566",
                " haixu2002@gmail.com", "Tiểu Nguội C#");
            DanhBa nguoi5 = new DanhBa("Kiều", "Thị", "Bình", 2001, "Nữ", "0388025345", "0957326448",
                " binhbong@gmail.com", "Tiểu Nguội C#");
            DanhBa nguoi6 = new DanhBa("Liêu", "Long", "Vũ ", 2002, "Nam", "0382801234", "0852346448",
                " vucute2k2@gmail.com", "");
            DanhBa nguoi7 = new DanhBa("Lê", "Đình", "Nghĩa", 2002, "Nam", "0982802345", "0757326448",
                " nghiaxoan2k2@gmail.com", "AE trong Ao Hồ");
            DanhBa nguoi8 = new DanhBa("Hoàng", "Thái", "Sơn", 2002, "Nam", "0828023456", "0987326448",
                " sonHQteam@gmail.com", "team HQ's Gamer ");
            DanhBa nguoi9 = new DanhBa("Đặng", "", "Vũ", 2002, "Nam", "035698471", "0986574321",
                " vudang555@gmail.com", " hàng xóm của hàng xóm");
            DanhBa nguoi10 = new DanhBa("Nguyễn", "Thị", "Hảo", 2003, "Nữ", "0958764321", "0369872541",
                " haohaok98@gmail.com", " Chủ Shop MỸ Phẩm Hàn Quốc");
            DanhBa nguoi11 = new DanhBa("Thiều ", "Đức", "Lâm", 1998, "Nam", "0375423456", "0852346179",
                " thieulam289@gmail.com", "Hiền ĐỆ");
            DanhBa nguoi12 = new DanhBa("Đặng", "Mai", "Lan", 1998, "Nữ", "02113655998", "0986753421",
                " lamdam98@gmail.com", " bà chủ tiệm thuốc  ");
            DanhBa nguoi13 = new DanhBa("Trần", "Thị Bích", "Thủy", 1998, "Nữ", "0986513724", "0356241897",
                " thuybundau@gmail.com", " Chủ Quán Bún đậu AE-5k");
            DanhBa nguoi14 = new DanhBa("Phùng", "Thị ", "Thúy", 1999, "Nữ", "0986513427", "0356249999",
                "thuysell@gmail.com", " CEO- Đồ gia dụng An Phát");
            DanhBa nguoi15 = new DanhBa(" Nguyễn", " Thị", "Thúy", 1999, "Nữ", "0879645213", "0956821473",
                "thuyhiep@gmail.com", "Trưởng phòng Điều hành cty Du Lịch Âu Việt");
            _lstDanhBas.Add(nguoi1);
            _lstDanhBas.Add(nguoi2);
            _lstDanhBas.Add(nguoi3);
            _lstDanhBas.Add(nguoi4);
            _lstDanhBas.Add(nguoi5);
            _lstDanhBas.Add(nguoi6);
            _lstDanhBas.Add(nguoi7);
            _lstDanhBas.Add(nguoi8);
            _lstDanhBas.Add(nguoi9);
            _lstDanhBas.Add(nguoi10);
            _lstDanhBas.Add(nguoi11);
            _lstDanhBas.Add(nguoi12);
            _lstDanhBas.Add(nguoi13);
            _lstDanhBas.Add(nguoi14);
            _lstDanhBas.Add(nguoi15);

        }

        public void themLienHe() //THÊM -  Liên Hệ vào TRONG DANH BẠ
        {
            Console.Write(" mời nhập Số người cần thêm: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                nguoi = new DanhBa();

                Console.Write(" mời bạn nhập Họ: ");
                nguoi.Ho = Console.ReadLine();
                Console.Write(" mời bạn nhập Tên Đệm: ");
                nguoi.TenDem = Console.ReadLine();
                Console.Write(" mời bạn nhập Tên: ");
                nguoi.Ten = Console.ReadLine();
                Console.Write(" mời bạn nhập Năm Sinh: ");
                nguoi.NamSinh = Int32.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhập Giới Tính: ");
                nguoi.GioiTinh = Console.ReadLine();
                Console.Write(" mời bạn nhập SĐT 1: ");
                nguoi.Sdt1 = Console.ReadLine();
                Console.Write(" mời bạn nhập SĐT 2: ");
                nguoi.Ssdt2 = Console.ReadLine();
                Console.Write(" mời bạn nhập Email:");
                nguoi.Email = Console.ReadLine();
                Console.Write(" mời bạn nhập Ghi Chú:");
                nguoi.GhiChu = Console.ReadLine();

                _lstDanhBas.Add(nguoi);

            }

        }
        public void timKiemDB() // tìm kiếm bằng tên hoặc số điện thoại
        {
            Console.Write(" mời bạn Nhập Tên hoặc số điện thoại: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);
            if (temp == -1)
            {
                Console.WriteLine(" Liện hệ Không tồn tại");
                return;
            }
            _lstDanhBas[temp].InRaManHinh();
        }


        public void XoaLienHe() //xóa theo index--  XÓA Liên Hệ TRONG DANH BẠ
        {
            Console.WriteLine(" mời bạn Nhập tên Liên hệ cần tìm: ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);
            if (temp == -1)
            {
                Console.WriteLine("            Liên Hệ không tồn tại,");
                return;
            }

            _lstDanhBas.RemoveAt(temp);
            Console.WriteLine("            Xóa Thành Công");
        }

        public void SuaSV() //sửa theo index //T SỬA Thông tin Liên hệ TRONG DANH BẠ
        {
            Console.WriteLine(" Mời bạn Nhập tên hoặc số điện thoại LIên Hệ mà bạn Muốn sửa:  ");
            _input = Console.ReadLine();
            int temp = getIndex(_input);
            if (temp == -1)
            {
                Console.WriteLine(" Liên hệ không tồn tại,");
                return;
            }

            do
            {
                Console.WriteLine("           Bạn Muốn sửa :\n" +
                                  " 1. họ tên\n" +
                                  " 2. Năm Sinh\n" +
                                  " 3. giới tính\n" +
                                  " 4. SĐT 1\n" +
                                  " 5. SĐT 2\n" +
                                  " 6. Email\n" +
                                  " 7. ghi chú\n" +
                                  " 8. thoát! Không sửa nữa.");
                Console.Write(" mời bạn Chọn:  ");
                _input = Console.ReadLine();
                Console.WriteLine("\n");
                switch (_input)
                {
                    case "1":
                        Console.Write(" Họ tên của " + _lstDanhBas[temp] + ": " + _lstDanhBas[temp].Ho + " " + _lstDanhBas[temp].TenDem + " " + _lstDanhBas[temp].Ten + "\n" +
                                          " Bạn muốn sửa thành: \n " +
                                          " họ: ");
                        _lstDanhBas[temp].Ho = Console.ReadLine();
                        Console.Write(" Tên Đệm: ");
                        _lstDanhBas[temp].TenDem = Console.ReadLine();
                        Console.Write(" Tên: ");
                        _lstDanhBas[temp].Ten = Console.ReadLine();
                        break;

                    case "2":
                        Console.Write(" Năm Sinh cũ của " + _lstDanhBas[temp].Ten + ": " + _lstDanhBas[temp].NamSinh + "\n" +
                                      " Bạn muốn sửa thành: ");
                        _lstDanhBas[temp].NamSinh = Int32.Parse(Console.ReadLine()); break;
                    case "3":
                        Console.Write(" Giới Tính cũ của " + _lstDanhBas[temp].Ten + ": " + _lstDanhBas[temp].GioiTinh + "\n" +
                                      " Bạn muốn sửa thành: ");
                        _lstDanhBas[temp].GioiTinh = Console.ReadLine(); break;
                    case "4":
                        Console.Write(" SĐT1 cũ của " + _lstDanhBas[temp].Ten + ": " + _lstDanhBas[temp].Sdt1 + "\n" +
                                      " Bạn muốn sửa thành: ");
                        _lstDanhBas[temp].Sdt1 = Console.ReadLine(); break;
                    case "5":
                        Console.Write(" SĐT2 cũ của " + _lstDanhBas[temp].Ten + ": " + _lstDanhBas[temp].Ssdt2 + "\n" +
                                      " Bạn muốn sửa thành: ");
                        _lstDanhBas[temp].Ssdt2 = Console.ReadLine(); break;
                    case "6":
                        Console.Write(" Email cũ của " + _lstDanhBas[temp].Ten + ": " + _lstDanhBas[temp].Email + "\n" +
                                      " Bạn muốn sửa thành: ");
                        _lstDanhBas[temp].Email = Console.ReadLine();
                        break;
                    case "7":
                        Console.Write(" Ghi chú cũ của " + _lstDanhBas[temp].Ten + ": " + _lstDanhBas[temp].GhiChu + "\n" +
                                      " Bạn muốn sửa thành: ");
                        _lstDanhBas[temp].GhiChu = Console.ReadLine();
                        ;
                        break;
                    case "8":
                        Console.WriteLine(" oke Tạm biệt "); break;
                    default:
                        Console.WriteLine(" Chức Năng Không có");
                        break;

                }

            } while (!(_input == "8"));// toán tử phủ định. dùng vong do- while
        }
        private void inra(List<DanhBa> _list)
        {
            Console.WriteLine("----------- Danh bạ của bạn ---------- " +
                              "\n");
            foreach (var VARIABLE in _list)
            {
                VARIABLE.InRaManHinh();
            }
        }


        public void sapxepnguoichonDB()//chức năng Sắp Xếp
        {
            Console.Write(" mời bạn chọn cách hiển thị được Sắp xếp theo:\n" +
                              " 1. Tên\n" +
                              " 2. Năm sinh\n" +
                              " Mời bạn chọn: ");
            _input = Console.ReadLine();
            Console.WriteLine("\n");
            switch (_input)
            {
                case "1":
                    Console.Write(" Mời bạn chọn cách sắp xếp Tên theo thứ tự AlphaB: \n" +
                                      " 1. Xuôi\n" +
                                      " 2. Ngược\n" +
                                      " Mời bạn chọn: ");
                    _input = Console.ReadLine();
                    Console.WriteLine("\n");
                    switch (_input)
                    {
                        case "1":
                            inra(_lstDanhBas.OrderBy(c => c.Ten).ToList());
                            break;
                        case "2":
                            inra(_lstDanhBas.OrderByDescending(c => c.Ten).ToList());
                            break;
                    };
                    break;
                case "2":
                    Console.Write(" Mời bạn chọn cách sắp xếp theo tuổi: \n" +
                                      " 1. từ già đến trẻ \n" +
                                      " 2. từ trẻ đến già \n" +
                                      " Mời bạn chọn: ");
                    _input = Console.ReadLine();
                    Console.WriteLine("\n");
                    switch (_input)
                    {
                        case "1":
                            inra(_lstDanhBas.OrderBy(c => c.NamSinh).ToList());
                            break;

                        case "2":
                            inra(_lstDanhBas.OrderByDescending(c => c.NamSinh).ToList());
                            break;
                    };
                    break;

            }

        }
        // phương thức 1: tái sử dụng khị in ra a=màn hình
      

        //PHương thức 2: Lấy Index của đối rượng trong danh sách
        private int getIndex(string msv) // Phương thức trả về số nguyên ---- dùng để tìm vị trí
        {
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                if (_lstDanhBas[i].Ten == msv)
                {
                    return i; //trả về vị trí của đối tượng cần tìm
                }
                else if (_lstDanhBas[i].Sdt1 == msv)
                {
                    return i; //trả về vị trí của đối tượng cần tìm
                }
                else if (_lstDanhBas[i].Ssdt2 == msv)
                {
                    return i; //trả về vị trí của đối tượng cần tìm
                }
            }
            return -1;// Không tìm được mã trùng thì phải trả về số âm để không bị trùng với count_list
        }


        public void TimkiemgandungTEN()
        {
            Console.WriteLine(" mời bạn nhập tên để tìm: ");
            string _input = Console.ReadLine();
            foreach (var x in _lstDanhBas.Where(c=> c.Ten.Contains(_input)))
            {
                x.InRaManHinh();
                Console.WriteLine("----------\n" +
                                  "\n");
            }
        }

        public void TimKiemDanDungSDT()
        {
            Console.Write(" Mời Bạn Nhập số điện thoại gần đúng: ");
            string _input = Console.ReadLine();
            var lstTemp = _lstDanhBas.Where(c => c.Sdt1.Contains(_input)).ToList();
            if (lstTemp.Count > 0)
            {
                foreach (var x in lstTemp)
                {
                    x.InRaManHinh();
                    Console.WriteLine("----------" +
                                      "\n");
                }
                return;
            }
            else
            {
                Console.WriteLine(" số điện thoại bạn tìm không có.");
            }


        }

        public void QuanLyDnhBa()// dùng sort
        {
            do
            {
                Console.Write("1. Thêm Liên lạc vào Danh bạ.\n" +
                                  "2. Sửa liên lạc trong Danh Bạ\n" +
                                  "3. Xóa Liên lạc trong Danh bạn\n" +
                                  "Mời bạn chọn CT: ");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":gsgn
                }

            } while (true);
        }

    }
}
