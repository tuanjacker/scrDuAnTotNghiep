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
    public class DALMuonTraSach
    {
        public List<MuonTra> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<MuonTra> list = new List<MuonTra>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    MuonTra entity = new MuonTra();
                    entity.MaMuonTra = reader.GetString("MaMuonTra");
                    entity.MaKhachHang = reader.GetString("MaKhachHang");
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.NgayMuon = reader.GetDateTime("NgayMuon");
                    entity.NgayTra = reader.GetDateTime("NgayTra");
                    entity.MaTrangThai = reader.GetString("MaTrangThai");
                    entity.NgayTao = reader.GetDateTime("NgayTao");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }


        public List<MuonTra> selectAll()
        {
            string sql = "SELECT * FROM MuonTraSach";
            return SelectBySql(sql, new List<object>());
        }

        public List<MuonTra> SearchMuonTra(string keyword)
        {
            string sql = "SELECT * FROM MuonTraSach WHERE MaKhachHang LIKE " + $"N'%{keyword}%' COLLATE Latin1_General_CI_AI" + " OR MaMuonTra LIKE " + $"N'%{keyword}%' COLLATE Latin1_General_CI_AI";
            // + " OR Email LIKE "+ $"N'%{keyword}%' COLLATE Latin1_General_CI_AI";
            List<object> thamSo = new List<object>();
            return SelectBySql(sql, thamSo);
        }


        public MuonTra selectById(string id)
        {
            String sql = "SELECT * FROM MuonTraSach WHERE MaMuonTra=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<MuonTra> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insertMuonTra(MuonTra mt)
        {
            try
            {
                string sql = @"INSERT INTO MuonTraSach (MaMuonTra, MaKhachHang, MaNhanVien, NgayMuon, NgayTra, MaTrangThai) 
                   VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> thamSo = new List<object>();
                thamSo.Add(mt.MaMuonTra);
                thamSo.Add(mt.MaKhachHang);
                thamSo.Add(mt.MaNhanVien);
                thamSo.Add(mt.NgayMuon);
                thamSo.Add(mt.NgayTra);
                thamSo.Add(mt.MaTrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateMuonTra(MuonTra mt)
        {
            try
            {
                string sql = @"UPDATE MuonTraSach 
                   SET MaKhachHang = @1, MaNhanVien = @2, NgayMuon = @3, NgayTra = @4, MaTrangThai = @5 
                   WHERE MaMuonTra = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(mt.MaMuonTra);
                thamSo.Add(mt.MaKhachHang);
                thamSo.Add(mt.MaNhanVien);
                thamSo.Add(mt.NgayMuon);
                thamSo.Add(mt.NgayTra);
                thamSo.Add(mt.MaTrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void deleteMuonTra(string maMuonTra)
        {
            try
            {
                string sql = "DELETE FROM MuonTraSach WHERE MaMuonTra = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maMuonTra);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public string generateMuonTra()
        {
            string prefix = "MT";
            string sql = "SELECT MAX(MaMuonTra) FROM MuonTraSach";
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
