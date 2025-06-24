using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_Xuong
{
    public class DALTrangThaiThanhToan
    {
        public string MaTrangThai { get; set; } // Added property
        public string TenTrangThai { get; set; } // Added property


        public DALTrangThaiThanhToan GetTrangThaiThanhToan(string maTrangThai)
        {
            string sql = "SELECT * FROM TrangThaiThanhToan WHERE MaTrangThai = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(maTrangThai);
            DALTrangThaiThanhToan trangThai = DBUtil.Value<DALTrangThaiThanhToan>(sql, thamSo);
            return trangThai;
        }

        public void update(DALTrangThaiThanhToan entity)
        {
            try
            {
                string sql = "UPDATE TrangThaiThanhToan SET TenTrangThai = @1, MoTa = @2 WHERE MaTrangThai = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(entity.MaTrangThai);
                thamSo.Add(entity.TenTrangThai);

                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi cập nhật trạng thái thanh toán: " + e.Message);
            }
        }

        public List<DALTrangThaiThanhToan> selectBySql(string sql, List<object> thamSo)
        {
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, thamSo);
                List<DALTrangThaiThanhToan> result = new List<DALTrangThaiThanhToan>();
                while (reader.Read())
                {
                    DALTrangThaiThanhToan item = new DALTrangThaiThanhToan
                    {
                        MaTrangThai = reader["MaTrangThai"].ToString(),
                        TenTrangThai = reader["TenTrangThai"].ToString()
                    };
                    result.Add(item);
                }
                reader.Close();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi truy vấn trạng thái thanh toán: " + e.Message);
            }

        }

        public DALTrangThaiThanhToan selectById(string maTrangThai)
        {
            string sql = "SELECT * FROM TrangThaiThanhToan WHERE MaTrangThai = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(maTrangThai);
            List<DALTrangThaiThanhToan> result = selectBySql(sql, thamSo);
            if (result.Count > 0)
            {
                return result[0];
            }
            else
            {
                return null; // Hoặc ném ngoại lệ nếu không tìm thấy
            }
        }

        public string generateMaTrangThai()
        {
            string sql = "SELECT MAX(MaTrangThai) FROM TrangThaiThanhToan";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result != DBNull.Value)
            {
                string maxMa = result.ToString();
                int nextId = int.Parse(maxMa.Substring(2)) + 1; // Giả sử MaTrangThai có định dạng "TT01", "TT02", ...
                return "TT" + nextId.ToString("D2"); // Định dạng lại với 2 chữ số
            }
            else
            {
                return "TT01"; // Trả về giá trị mặc định nếu không có bản ghi nào
            }
        }
        public void delete(string maTrangThai)
        {
            try
            {
                string sql = "DELETE FROM TrangThaiThanhToan WHERE MaTrangThai = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maTrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi xóa trạng thái thanh toán: " + e.Message);
            }
        }
        public List<DALTrangThaiThanhToan> selectALL()
        {
            string sql = "SELECT * FROM TrangThaiThanhToan";
            List<object> thamSo = new List<object>();
            return selectBySql(sql, thamSo);
        }
    }
}
