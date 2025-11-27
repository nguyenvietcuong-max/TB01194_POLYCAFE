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
    }
}
