using DAL_Xuong;
using DTO_Xuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Xuong
{
    public class BUSSach
    {
        private DALSach dalSach = new DALSach();

        public List<Sach> GetAllSach()
        {
            return dalSach.LayDSSach();
        }

        public string InsertSach(Sach s)
        {
            try
            {
                s.MaSach = dalSach.generateMaSach();
                if (string.IsNullOrEmpty(s.MaSach))
                {
                    return "Mã sách không hợp lệ.";
                }

                dalSach.ThemSach(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm sách: " + ex.Message;
            }
        }

        public string UpdateSach(Sach s)
        {
            try
            {
                if (string.IsNullOrEmpty(s.MaSach))
                {
                    return "Mã sách không hợp lệ.";
                }

                dalSach.CapNhatSach(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật sách: " + ex.Message;
            }
        }

        public string DeleteSach(string maSach)
        {
            try
            {
                if (string.IsNullOrEmpty(maSach))
                {
                    return "Mã sách không hợp lệ.";
                }

                dalSach.XoaSach(maSach);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa sách: " + ex.Message;
            }
        }

      
    }
}
