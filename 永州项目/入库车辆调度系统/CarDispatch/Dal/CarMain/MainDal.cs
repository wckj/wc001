using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.CarMain
{
    public class MainDal : DataBaseVisitor
    {
        /// <summary>
        /// 主数据
        /// </summary>
        public override string ExecSql(string sqlCommand)
        {
            string sql = "";//返回查询结果集
            if ((sql = CommonSql(sqlCommand)) != "")
                return sql;
            return sql;
        }
        private static string CommonSql(string sqlCommand)
        {
            string sql = "";
            switch (sqlCommand)
            {
                //未提交运货单的排队车辆
                case "Selectstate0":
                    sql = "select carcode,address_name from V_Bus_RegistrationInfo Where workstate=0 order by daytime";
                    break;
                //1号伸缩链板机的未卸货排队车辆
                case "Selectstate1_1":
                    sql = "select carcode,address_name from V_Bus_RegistrationInfo Where workstate=1 and port=1";
                    break;
                //2号伸缩链板机的未卸货排队车辆
                case "Selectstate1_2":
                    sql = "select carcode,address_name from V_Bus_RegistrationInfo Where workstate=1 and port=2";
                    break;
                //1号伸缩链板机的正在卸烟车辆
                case "Selectstate2_1":
                    sql = "select carcode,address_name,quantity,completeqty from V_Bus_RegistrationInfo Where workstate=2 and port=1";
                    break;
                //2号伸缩链板机的正在卸烟车辆
                case "Selectstate2_2":
                    sql = "select carcode,address_name,quantity,completeqty from V_Bus_RegistrationInfo Where workstate=2 and port=2";
                    break;
                //未卸货的总车辆车辆
                case "Selectstate0+1":
                    sql = "select count(*) from V_Bus_RegistrationInfo Where workstate=0 or workstate=1";
                    break;
                //查询调度状态
                case "CarDispatchState":
                    sql = "select parameter_value from Sys_parameter Where parameter_name='state'";
                    break;
                //修改调度状态-开始调度
                case "UpdateCarDispatchState1":
                    sql = "update Sys_parameter set parameter_value=1 Where parameter_name='state'";
                    break;
                //修改调度状态-停止调度
                case "UpdateCarDispatchState0":
                    sql = "update Sys_parameter set parameter_value=0 Where parameter_name='state'";
                    break;
            }
            return sql;
        }
    }
}
