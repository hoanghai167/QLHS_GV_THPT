using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_GV_HS_THPT_DAL;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_BUS
{
    public class BUS_tblGiangDay
    {
        SQL_tblGiangday bus = new SQL_tblGiangday();
        public void addGiangday(EC_tblGiangday et)
        {
            bus.addGiangday(et);
        }
        //Sua du lieu
        public void updateGiangday(EC_tblGiangday et)
        {
            bus.updateGiangday(et);
        }
        //Xoa du lieu
        public void delGiangday(EC_tblGiangday et)
        {
            bus.delGiangday(et);
        }
        //select
        public DataTable getAllgiangday()
        {
            return bus.getAllGiangday();
        }
        public DataTable getGiangday(string dk)
        {
            return bus.getThongTinGD(dk);
        }
        public DataTable getMagv()
        {
            return bus.getMaGV();
        }
        public DataTable getMalop()
        {
            return bus.getMalop();
        }

    }
}