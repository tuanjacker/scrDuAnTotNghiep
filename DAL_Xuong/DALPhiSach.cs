
using DAL_PolyCafe;
using DTO_Xuong;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Xuong
{
    public class DALPhiSach
    {
        public List<PhiSach> LayDSPhiSach()
        {
            List<object> args = new List<object>();
            string sql = "SELECT * FROM PhiSach";

            return SelectBySql(sql, args);
        }

        public List<PhiSach> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhiSach> ds = new List<PhiSach>();
            SqlDataReader reader = DBUtil.Query(sql, new List<object>(), CommandType.Text);

            while (reader.Read())
            {
                PhiSach entity = new PhiSach();
                entity.MaPhiSach = reader.GetString("MaPhiSach");
                entity.MaSach = reader.GetString("MaSach");
                entity.PhiMuon = reader.GetDecimal("PhiMuon");
                entity.PhiPhat = reader.GetDecimal("PhiPhat");
                entity.TrangThai = reader.GetBoolean("TrangThai");
                entity.NgayTao = reader.GetDateTime("NgayTao");
                ds.Add(entity);
            }

            reader.Close();
            return ds;
        }

        public void ThemPhiSach(PhiSach s)
        {
            string sql = "INSERT INTO PhiSach VALUES (@0, @1, @2, @3, @4, @5 )";
            List<object> args = new List<object>
            {
                s.MaPhiSach, s.MaSach, s.PhiMuon, s.PhiPhat, s.TrangThai, s.NgayTao
            };
            DBUtil.Update(sql, args);
        }

        public void CapNhatPhiSach(PhiSach s)
        {
            string sql = @"UPDATE PhiSach SET MaSach=@1, PhiMuon=@2, PhiPhat = @3, TrangThai=@4 WHERE MaPhiSach=@0";
            List<object> args = new List<object>
            {
                s.MaPhiSach, s.MaSach, s.PhiMuon,s.PhiPhat, s.TrangThai
            };
            DBUtil.Update(sql, args);
        }

        public void XoaPhiSach(string maPhiSach)
        {
            string sql = "DELETE FROM PhiSach WHERE MaPhiSach=@0";
            DBUtil.Update(sql, new List<object> { maPhiSach });
        }

        public string generateMaPhiSach()
        {
            string prefix = "PS";
            string sql = "SELECT MAX(MaPhiSach) FROM PhiSach";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(2);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

    }
}
