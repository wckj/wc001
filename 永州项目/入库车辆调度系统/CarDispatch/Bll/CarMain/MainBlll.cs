using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Model;
using Dal;

namespace Bll.CarMain
{
    public class MainBlll
    {
        #region 查询出未递交货运单所有的车辆数据和未卸货的车辆总数
        /// <summary>
        /// 查询出未递交货运单所有的车辆数据和未卸货的车辆总数
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAllCar(string select)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new Dal.CarMain.MainDal();
            DataSet ds = new DataSet();
            try
            {
                switch (select)
                {
                    // 查询出未递交货运单所有的车辆数据
                    case "0":
                        ds = db.ReturnDataSet(visitor, "Selectstate0", "V_Bus_RegistrationInfo");
                        break;
                    //未卸货的车辆总数
                    case "1":
                        ds = db.ReturnDataSet(visitor, "Selectstate0+1", "V_Bus_RegistrationInfo");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 查询出未卸货的车辆数据
        /// <summary>
        /// 查询出未卸货的车辆数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAll(string select, string WhereSql)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new Dal.CarMain.MainDal();
            DataSet ds = new DataSet();
            try
            {
                switch (select)
                {
                    //1号伸缩链板机的未卸货排队车辆
                    case "1":
                        ds = db.ReturnDataSet(visitor, "Selectstate1_1", "V_Bus_RegistrationInfo", WhereSql);
                        break;
                    //2号伸缩链板机的未卸货排队车辆
                    case "2":
                        ds = db.ReturnDataSet(visitor, "Selectstate1_2", "V_Bus_RegistrationInfo", WhereSql);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 修改调度状态
        /// <summary>
        /// 修改调度状态
        /// </summary>
        /// <returns>返回数据源</returns>
        public static string UpdateCarDispatchState(string select)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new Dal.CarMain.MainDal();
            bool bSuc = false;
            int nEffectRows = 0;
            try
            {
                switch (select)
                {
                    //修改调度状态-开始调度
                    case "1":
                        bSuc = db.TransactSql(visitor, "UpdateCarDispatchState1", out nEffectRows);
                        break;
                    //修改调度状态-停止调度
                    case "0":
                        bSuc = db.TransactSql(visitor,"UpdateCarDispatchState0", out nEffectRows);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        #endregion

        #region 查询正在卸烟的车辆数据
        /// <summary>
        /// 查询正在卸烟的车辆数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet GetInfo(string select)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new Dal.CarMain.MainDal();
            DataSet ds = new DataSet();
            try
            {
                switch (select)
                {
                    //1号伸缩链板机正在卸烟的车辆信息
                    case "1":
                        ds = db.ReturnDataSet(visitor, "Selectstate2_1", "V_Bus_RegistrationInfo");
                        break;
                    //2号伸缩链板机正在卸烟的车辆信息
                    case "2":
                        ds = db.ReturnDataSet(visitor, "Selectstate2_2", "V_Bus_RegistrationInfo");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion
    }
}
