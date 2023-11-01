using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SinhVienModel
    {
        public string MaSinHVien { get; set; }
        public string HoTenSinhVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string TenLop { get; set; }

        public SinhVienModel(string maSinHVien, string hoTenSinhVien, DateTime ngaySinh, string tenLop)
        {
            MaSinHVien = maSinHVien;
            HoTenSinhVien = hoTenSinhVien;
            NgaySinh = ngaySinh;
            TenLop = tenLop;
        }

        public SinhVienModel()
        {
        }
    }
}
