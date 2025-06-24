using DAL_Xuong;
using DTO_Xuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Xuong
{
    public class BUSKhachHang
    {
        DALKhachHang dalKhachHang = new DALKhachHang();

        public List<KhachHang> GetKhachHangList()
        {
            return dalKhachHang.selectAll();
        }

        public List<KhachHang> SearchKhachHang(string keyword)
        {
            List<KhachHang> nv = new List<KhachHang>();
            try
            {
                return dalKhachHang.SearchKhachHang(keyword);
            }
            catch (Exception ex)
            {
                return nv;
            }
        }
        public string InsertKhachHang(KhachHang nv)
        {
            try
            {
                nv.MaKhachHang = dalKhachHang.generateMaKhachHang();
                if (string.IsNullOrEmpty(nv.MaKhachHang))
                {
                    return "Mã nhân viên không hợp lệ.";
                }
                if (dalKhachHang.checkEmailExists(nv.Email))
                {
                    return "Email đã tồn tại.";
                }
                dalKhachHang.insertKhachHang(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateKhachHang(KhachHang nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaKhachHang))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalKhachHang.updateKhachHang(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteKhachHang(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalKhachHang.deleteKhachHang(maNV);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
