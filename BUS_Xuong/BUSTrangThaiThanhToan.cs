using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Xuong;

namespace BUS_Xuong
{
    public class BUSTrangThaiThanhToan
    {
        DALTrangThaiThanhToan DALTrangThaiThanhToan = new DALTrangThaiThanhToan();
        public List<DALTrangThaiThanhToan> GetAllTrangThaiThanhToan()
        {
            return DALTrangThaiThanhToan.selectALL();
        }

        public string UpdateTrangThaiThanhToan(DALTrangThaiThanhToan trangThaiThanhToan)
        {
            try
            {
                if (string.IsNullOrEmpty(trangThaiThanhToan.MaTrangThai))
                {
                    return "Mã trạng thái thanh toán không được để trống";
                }
                DALTrangThaiThanhToan.update(trangThaiThanhToan);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi cập nhật trạng thái thanh toán: " + ex.Message;
            }
        }


    }
}
