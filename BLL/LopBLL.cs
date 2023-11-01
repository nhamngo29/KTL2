using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LopBLL : IBLL<Lop>
    {
        public LopDAL da;
        public LopBLL()
        {
            da = new LopDAL();
        }
        public bool Delete(Lop e)
        {
            return da.Delete(e);
        }

        public List<Lop> GetAll()
        {
            return da.GetAll();
        }

        public bool Insert(Lop e)
        {
            return da.Insert(e);
        }
        public bool Update(Lop e)
        {
            return da.Update(e);
        }
        public List<Lop> GetLopByIdKhoa(string khoa)
        {
            return da.GetLopByIdKhoa(khoa);
        }
    }
}
