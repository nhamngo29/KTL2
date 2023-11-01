using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiemDAL
    {
        private readonly QLSINHVIENDataContext db;
        public DiemDAL()
        {
            db = new QLSINHVIENDataContext();
        }
        public List<Diem> GetAll()
        {
            return db.Diems.ToList() ?? null;
        }
        public bool Insert(Diem mh)
        {
            try
            {
                db.Diems.InsertOnSubmit(mh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(Diem mh)
        {
            try
            {
                Diem h = db.Diems.FirstOrDefault(t => t.MaSinhVien == mh.MaSinhVien && t.MaMonHoc == mh.MaMonHoc);
                db.Diems.DeleteOnSubmit(h);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Diem mh)
        {
            try
            {
                Diem h = db.Diems.FirstOrDefault(t => t.MaSinhVien == mh.MaSinhVien && t.MaMonHoc == mh.MaMonHoc);
                if (h != null)
                {
                    h.Diem1 = mh.Diem1;
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
        public List<Diem> GetDiemByIdSV(string sv)
        {
            return db.Diems.Where(t => t.MaSinhVien == sv).ToList();
        }
    }
}
