using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using THOK.Util;
using LEDSHOW.Dao;

namespace LEDSHOW.BLL
{
    public class LedShowBLL : BaseDao
    {
        /// <summary>
        /// 参数表信息
        /// </summary>
        /// <param name="strRequires"></param>
        /// <returns></returns>
        public DataTable getParameters(string strRequires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                LedShowDao dao = new LedShowDao();
                dao.SetPersistentManager(pm);
                return dao.getParameters(strRequires);
            }
        }
        /// <summary>
        /// 送货单信息
        /// </summary>
        /// <param name="strRequires"></param>
        /// <returns></returns>
        public DataTable getRegistrationInfos(string strRequires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                LedShowDao dao = new LedShowDao();
                dao.SetPersistentManager(pm);
                return dao.getRegistrationInfos(strRequires);
            }
        }
        /// <summary>
        /// 待卸货总量
        /// </summary>
        /// <param name="strRequires"></param>
        /// <returns></returns>
        public int workTaskQty(string strRequires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                LedShowDao dao = new LedShowDao();
                dao.SetPersistentManager(pm);
                return dao.workTaskQty(strRequires);
            }
        }

        /// <summary>
        /// 更改报警次数
        /// </summary>
        /// <param name="requires"></param>
        /// <returns></returns>
        public void updateAlarmnum(string requires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                LedShowDao dao = new LedShowDao();
                dao.SetPersistentManager(pm);
                dao.updateAlarmnum(requires);
            }
        }
    }
}
