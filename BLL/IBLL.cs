using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBLL<T> where T : class
    {
        List<T> GetAll();
        bool Insert(T e);
        bool Delete(T e);
    }
}
