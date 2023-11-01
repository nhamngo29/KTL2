using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonHocBLL:IBLL<MonHoc>
    {
        public MonHocDAL da;
        public MonHocBLL()
        {
            da = new MonHocDAL();
        }

        public bool Delete(MonHoc e)
        {
            return da.Delete(e);
        }

        public List<MonHoc> GetAll()
        {
            return da.GetAll();
        }

        public bool Insert(MonHoc e)
        {
            return da.Insert(e);
        }

        public bool Update(MonHoc e)
        {

            return da.Update(e);
        }
    }
}
