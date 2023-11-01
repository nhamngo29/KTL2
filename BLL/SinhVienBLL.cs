using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVienBLL : IBLL<SinhVien>
    {
        SinhVienDAL db;

        public SinhVienBLL()
        {
            db= new SinhVienDAL();
        }

        public bool Delete(SinhVien e)
        {
            return db.Delete(e);
        }

        public List<SinhVien> GetAll()
        {
            return null;
        }
        public List<SinhVienModel> GetAllSV()
        {
            return db.GetAll();
        }
        public bool Insert(SinhVien e)
        {
            return db.Insert(e);
        }
        public bool Update(SinhVien e)
        {

            return db.Update(e);
        }
        public List<SinhVienModel> GétinhVienByIdLop(string id)
        {
            return db.GetSinhVienByIdLop(id);
        }
    }
}
