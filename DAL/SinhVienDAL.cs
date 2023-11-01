using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienDAL
    {
        private readonly QLSINHVIENDataContext db;
        public SinhVienDAL()
        {
            db = new QLSINHVIENDataContext();
        }
        public List<SinhVienModel> GetAll()
        {
            return db.SinhViens.Select(t => new SinhVienModel { MaSinHVien = t.MaSinhVien, HoTenSinhVien = t.HoTen, NgaySinh = t.NgaySinh, TenLop = t.Lop.TenLop }).ToList();
        }
        //public List<SinhVien> GetAll()
        //{
        //    return db.SinhViens.Select(t => new
        //    {
        //        MaSinhVien = t.MaSinhVien,
        //        HoTen = t.HoTen,
        //        NgaySinh = t.NgaySinh,
        //        LopDAL=t.LopDAL,
        //    }).ToList();
        //}
        public bool Insert(SinhVien mh)
        {
            try
            {
                db.SinhViens.InsertOnSubmit(mh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(SinhVien mh)
        {
            try
            {
                SinhVien h = db.SinhViens.FirstOrDefault(t => t.MaSinhVien == mh.MaSinhVien);
                db.SinhViens.DeleteOnSubmit(h);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(SinhVien mh)
        {
            try
            {
                SinhVien h = db.SinhViens.FirstOrDefault(t => t.MaSinhVien == mh.MaSinhVien);
                if (h != null)
                {
                    h.Diems = mh.Diems;
                    h.HoTen = mh.HoTen;
                    h.MaLop = mh.MaLop;
                    h.NgaySinh = mh.NgaySinh;
                    db.SubmitChanges();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<SinhVienModel> GetSinhVienByIdLop(string id)
        {
            return db.SinhViens.Where(t=>t.MaLop==id).Select(t => new SinhVienModel { MaSinHVien = t.MaSinhVien, HoTenSinhVien = t.HoTen, NgaySinh = t.NgaySinh, TenLop = t.Lop.TenLop }).ToList();
        }
    }
}
