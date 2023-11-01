using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopDAL
    {
        private readonly QLSINHVIENDataContext db;
        public LopDAL()
        {
            db = new QLSINHVIENDataContext();
        }
        public List<Lop> GetAll()
        {
            return db.Lops.ToList() ?? null;
        }
        public bool Insert(Lop mh)
        {
            try
            {
                db.Lops.InsertOnSubmit(mh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(Lop mh)
        {
            try
            {
                Lop h = db.Lops.FirstOrDefault(t => t.MaLop == mh.MaLop);
                db.Lops.DeleteOnSubmit(h);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Lop mh)
        {
            try
            {
                Lop h = db.Lops.FirstOrDefault(t => t.MaLop == mh.MaLop);
                if (h != null)
                {
                    h.TenLop = mh.TenLop;
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
        public List<Lop> GetLopByIdKhoa(string khoa)
        {
            return db.Lops.Where(t=>t.MaKhoa== khoa).ToList();  
        }
    }
}
