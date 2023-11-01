using DAL.QLSINHVIENTableAdapters;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class MonHocDAL
    {
        private readonly QLSINHVIENDataContext db;
        public MonHocDAL()
        {
            db = new QLSINHVIENDataContext();
        }
        public List<MonHoc> GetAll()
        {
            return db.MonHocs.ToList() ?? null;
        }
        public bool Insert(MonHoc mh)
        {
            try
            {
                db.MonHocs.InsertOnSubmit(mh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(MonHoc mh)
        {
            try
            {
                MonHoc h = db.MonHocs.FirstOrDefault(t => t.MaMonHoc == mh.MaMonHoc);
                db.MonHocs.DeleteOnSubmit(h);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(MonHoc mh)
        {
            try
            {
                MonHoc h = db.MonHocs.FirstOrDefault(t => t.MaMonHoc == mh.MaMonHoc);
                if (h != null)
                {
                    h.TenMonHoc = mh.TenMonHoc;
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
    }
}
