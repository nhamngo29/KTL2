using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DiemBLL : IBLL<Diem>
    {
        public DiemDAL da;
        public DiemBLL()
        {
            da = new DiemDAL();
        }
        public bool Delete(Diem e)
        {
            return da.Delete(e);
        }

        public List<Diem> GetAll()
        {
            return da.GetAll();
        }

        public bool Insert(Diem e)
        {
            return da.Insert(e);
        }
        public bool Update(Diem e)
        {
            return da.Update(e);
        }
        public List<Diem> GetLopByIdSV(string sv)
        {
            return da.GetDiemByIdSV(sv);
        }
    }
}
