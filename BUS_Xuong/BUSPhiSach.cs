using DAL_Xuong;
using DTO_Xuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Xuong
{
    public class BUSPhiSach
    {
        private DALPhiSach dalPhiSach = new DALPhiSach();

        public List<PhiSach> GetAllPhiSach()
        {
            return dalPhiSach.LayDSPhiSach();
        }

        public string InsertPhiSach(PhiSach s)
        {
            try
            {
                s.MaPhiSach = dalPhiSach.generateMaPhiSach();
                if (string.IsNullOrEmpty(s.MaPhiSach))
                {
                    return "Mã không hợp lệ.";
                }

                dalPhiSach.ThemPhiSach(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm phí sách: " + ex.Message;
            }
        }

        public string UpdatePhiSach(PhiSach s)
        {
            try
            {
                if (string.IsNullOrEmpty(s.MaPhiSach))
                {
                    return "Mã  không hợp lệ.";
                }

                dalPhiSach.CapNhatPhiSach(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật phí sách: " + ex.Message;
            }
        }

        public string DeletePhiSach(string maPhiSach)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhiSach))
                {
                    return "Mã không hợp lệ.";
                }

                dalPhiSach.XoaPhiSach(maPhiSach);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa phí sách: " + ex.Message;
            }
        }

      
    }
}
