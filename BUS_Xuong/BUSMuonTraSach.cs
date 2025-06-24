using DAL_Xuong;
using DTO_Xuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Xuong
{
    public class BUSMuonTraSach
    {
        DALMuonTraSach dalMuonTraSach = new DALMuonTraSach();
        public List<MuonTra> GetAllMuonTra()
        {
            return dalMuonTraSach.selectAll();
        }

        public string InsertMuonTra(MuonTra s)
        {
            try
            {
                s.MaMuonTra = dalMuonTraSach.generateMuonTra();
                if (string.IsNullOrEmpty(s.MaMuonTra))
                {
                    return "Mã không hợp lệ.";
                }

                dalMuonTraSach.insertMuonTra(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm mượn trả sách: " + ex.Message;
            }
        }

        public string UpdateMuonTra(MuonTra s)
        {
            try
            {
                if (string.IsNullOrEmpty(s.MaMuonTra))
                {
                    return "Mã  không hợp lệ.";
                }

                dalMuonTraSach.updateMuonTra(s);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật : " + ex.Message;
            }
        }

        public string DeleteMuonTra(string maMuonTra)
        {
            try
            {
                if (string.IsNullOrEmpty(maMuonTra))
                {
                    return "Mã không hợp lệ.";
                }

                dalMuonTraSach.deleteMuonTra(maMuonTra);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa phí sách: " + ex.Message;
            }
        }

    }
}
