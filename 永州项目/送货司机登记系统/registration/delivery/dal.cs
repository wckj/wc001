using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using THOK.Util;

namespace delivery
{
    public class dal : BaseDao
    {
        //按时间查询车辆登记信息
        public DataTable registrationInfo(DateTime date1, DateTime date2)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                string sql = @"select id, name,brandno,carcode,phone,daytime,state,port+'号链板机' port,b.address_name
                                ,case workstate  when 0 then '未提交'  when 1 then' 已提交' when 2 then' 卸货中' when 3 then' 已完成' end  workstate
                                from Bus_RegistrationInfo a 
                                left join Bus_productAddress b on a.address_code=b.address_code where daytime>='{0}' and  daytime<'{1}'  order by id";
                return this.ExecuteQuery(string.Format(sql, date1, date2)).Tables[0];
            }
        }
        //查询所有登记车辆信息
        public DataTable registrationInfo(string requires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                string sql = @"select id, name,brandno,carcode,phone,daytime,state,port+'号链板机' port,b.address_name
                                ,case workstate  when 0 then '未提交'  when 1 then' 已提交' when 2 then' 卸货中' when 3 then' 已完成' end  workstate
                                from Bus_RegistrationInfo a 
                                left join Bus_productAddress b on a.address_code=b.address_code  {0} order by id desc";
                return this.ExecuteQuery(string.Format(sql, requires)).Tables[0];
            }
        }
        //查询参数表数据
        public DataTable getParameters(string requires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                string sql = @"select * from Sys_parameter {0}";
                return this.ExecuteQuery(string.Format(sql, requires)).Tables[0];
            }
        }

        //查询参数表数据
        public DataTable getAdress(string requires)
        {
            using (PersistentManager pm = new PersistentManager())
            {
                string sql = @"select * from Bus_productAddress {0}";
                return this.ExecuteQuery(string.Format(sql, requires)).Tables[0];
            }
        }
        //新增车辆登记信息
        public bool addRegistrationInfo(RegistrationInfo registrationinformation, out string log)
        {
            string sql = "";
            bool state = false;
            try
            {
                if (registrationInfo("where id='" + registrationinformation._id + "'").Rows.Count > 0)
                {
                    sql = string.Format("update Bus_RegistrationInfo set brandno='{0}',carcode='{1}',phone='{2}',address_code='{3}' where id={4}"
                            , registrationinformation._brandno
                            , registrationinformation._carcode
                            , registrationinformation._phone
                            , registrationinformation._address
                            ,registrationinformation._id);
                    ExecuteNonQuery(sql);
                    state = true;
                    log = "修改成功！";
                }
                else
                {

                    using (PersistentManager persistentManager = new PersistentManager())
                    {
                        sql = string.Format(@"insert into  Bus_RegistrationInfo (name,brandno,carcode,phone,daytime,state,memo,port,address_code,workstate)
                        values( '{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
                          , registrationinformation._name
                          , registrationinformation._brandno
                          , registrationinformation._carcode
                          , registrationinformation._phone
                          , registrationinformation._daytime
                          , registrationinformation._state
                          , registrationinformation._memo
                          , registrationinformation._port
                          , registrationinformation._address
                          , registrationinformation._workstate);
                        ExecuteNonQuery(sql);
                        state = true;
                        log = "时间：" + registrationinformation._daytime + "姓名:" + registrationinformation._name + "车牌号：" + registrationinformation._carcode + "进入物流中心";
                    }

                }
            }
            catch (Exception ex)
            {
                state = false;
                log = ex.ToString();
            }
            return state;
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
                string sql = @"update  Bus_RegistrationInfo set alarmnum=1  {0}";
                ExecuteNonQuery(string.Format(sql, requires));
            }
        }
    }
}
