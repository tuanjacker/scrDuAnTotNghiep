using DAL_Xuong;
using DTO_Xuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Xuong
{
    public class BUSTacGia
    {
        private DALTacGia dalTacGia = new DALTacGia();

        public List<TacGia> GetAllTacGia()
        {
            return dalTacGia.LayDSTacGia();
        }

        public string InsertTacGia(TacGia s)
        {
            try
            {
                s.MaTacGia = dalTacGia.generateMaTacGia();
                if (string.IsNullOrEmpty(s.MaTacGia))
                {
                    return "Mã tác giả không hợp lệ.";
                }

                dalTacGia.ThemTacGia(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm tác giả: " + ex.Message;
            }
        }

        public string UpdateTacGia(TacGia s)
        {
            try
            {
                if (string.IsNullOrEmpty(s.MaTacGia))
                {
                    return "Mã tác giả không hợp lệ.";
                }

                dalTacGia.CapNhatTacGia(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật tác giả: " + ex.Message;
            }
        }

        public string DeleteTacGia(string maTacGia)
        {
            try
            {
                if (string.IsNullOrEmpty(maTacGia))
                {
                    return "Mã tác giả không hợp lệ.";
                }

                dalTacGia.XoaTacGia(maTacGia);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa tác giả: " + ex.Message;
            }
        }

      
    }
}
