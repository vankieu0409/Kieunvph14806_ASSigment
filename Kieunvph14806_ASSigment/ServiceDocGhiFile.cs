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

        public void QLDocGhi()
        {

        }

        private List<DanhBa> GetLIst()
        {
            return _lstDanhBas;
        }
        public string Ghifile(List<DanhBa> listDanhbas, string path)
        {
            try
            {
                _fs = new FileStream(path,FileMode.Create);
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
                listD = (List<DanhBa>) data;
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