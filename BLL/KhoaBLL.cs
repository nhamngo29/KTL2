using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoaBLL
    {
        KhoaDAL da=new KhoaDAL();
        public KhoaBLL() { }    
        public List<Khoa> GetKhoa()
        {
            return da.GetKhoa();
        }
    }
}
