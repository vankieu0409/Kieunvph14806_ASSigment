using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kieunvph14806_ASSigment
{
    partial class Service
    {
        private FileStream _fs;
        private BinaryFormatter _bf;
        private List<DanhBa> listD;
        string path = @"E:\C# (Sharp)\C#2\Kieunvph14806_ASSigment\Kieunvph14806_ASSigment\kieu.bin";
        public void QLDocGhi()
        {
            do
            {
                Console.Write(" ct đọc ghi file\n" +
                              " 1. LƯu file (Save File)\n" +
                              " 2. ĐỌc File\n" +
                              " 0. THoát ra main monitor\n");
                _input = Mess(" để chọ chương trình: ");
                switch (_input)
                {
                    case "1":

                        Console.WriteLine(Ghifile(GetLIst(), path)); break;
                    case "2":
                        foreach (var VARIABLE in DocFile(path))
                        {
                            VARIABLE.InRaManHinh();
                        } ; break;
                    case "0": Console.WriteLine(" Về main monitor");break;

                    default: Console.WriteLine(" bạn chọ sai mời chọn lại");break;
                }

                Console.WriteLine("                     *");
            } while (!(_input == "0"));
        }

        private List<DanhBa> GetLIst()
        {
            return _lstDanhBas;
        }
        public string Ghifile(List<DanhBa> listDanhbas, string path)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, listDanhbas);
                _fs.Close();
                return "Ghi File Thành Công";

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return " ghi file thất  bại rồi!";
        }

        public List<DanhBa> DocFile(string path)
        {
            try
            {
                listD = new List<DanhBa>();
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                listD = (List<DanhBa>)data;
                _fs.Close();
                return listD;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            return null;
        }

    }
}