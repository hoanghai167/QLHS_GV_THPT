using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QV_HS_THPT_Entity
{
    public class EC_tblGiangday
    {
       
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _MaGV;

        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }
        private DateTime _Ngayday;

        public DateTime Ngayday
        {
            get { return _Ngayday; }
            set { _Ngayday = value; }
        }
        private string _Tietday;

        public string Tietday
        {
            get { return _Tietday; }
            set { _Tietday = value; }
        }
    }
}
