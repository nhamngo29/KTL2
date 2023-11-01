using DAL.QLSINHVIENTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaDAL
    {
        KhoaTableAdapter da;
        QLSINHVIENDataContext db;
        public KhoaDAL()
        {
            da = new KhoaTableAdapter();
            db= new QLSINHVIENDataContext();
        }
        public List<Khoa> GetKhoa()
        {
            return db.Khoas.ToList();
        }

    }
}
