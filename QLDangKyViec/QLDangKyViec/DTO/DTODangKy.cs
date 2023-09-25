using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDangKyViec.DTO
{
    public class DTODangKy
    {
        public int ID { get; set; }
        public DateTime TUNGAY { get; set; }
        public DateTime DENNGAY { get; set; }
        public string TUGIO { get; set; }
        public string DENGIO { get; set; }
        public string NGUOIDANGKY { get; set; }
        public string LYDO { get; set; }
    }
}
