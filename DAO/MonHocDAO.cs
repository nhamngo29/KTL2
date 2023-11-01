using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHocDAO
    {
        public string MaMonHoc { get; set; }
        public string TenMonHoc { set; get; }
        public MonHocDAO() { }

        public MonHocDAO(string maMonHoc, string tenMonHoc)
        {
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;
        }
        public MonHocDAO(DataRow row)
        {
            MaMonHoc = (string)row["MaMonHoc"];
            TenMonHoc = (string)row["TenMonHoc"];
        }
    }
}
