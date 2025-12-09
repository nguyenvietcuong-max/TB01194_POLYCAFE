using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class BLL_NhanVien
    {
        DAL_NhanVien DAL_NhanVien = new DAL_NhanVien();

        public NhanVien DangNhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            return DAL_NhanVien.getNhanVien(username, password);
        }
        public bool ResetMatKhau(string email, string mk)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }
                DAL_NhanVien.ResetMatKhau(mk, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<NhanVien> GetNhanVienList()
        {
            return DAL_NhanVien.selectAll();
        }


        public string InsertNhanVien(NhanVien nv)
        {
            try
            {
                nv.MaNhanVien = DAL_NhanVien.generateMaNhanVien();
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }
                if (DAL_NhanVien.checkEmailExists(nv.Email))
                {
                    return "Email đã tồn tại.";
                }
                DAL_NhanVien.insertNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateNhanVien(NhanVien nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                DAL_NhanVien.updateNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteNhanVien(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                DAL_NhanVien.deleteNhanVien(maNV);
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
