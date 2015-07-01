using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Count
{
    public class CountDal : DataBaseVisitor
    {
        /// <summary>
        /// ������
        /// </summary>
        public override string ExecSql(string sqlCommand)
        {
            string sql = "";//���ز�ѯ�����
            if ((sql = CommonSql(sqlCommand)) != "")
                return sql;
            return sql;
        }
        private static string CommonSql(string sqlCommand)
        {
            string sql = "";
            switch (sqlCommand)
            {
                //ȫ��������Ŀ
                case "Select":
                    sql = "select Name,Code,DbName from V_C_StatSelect Order By Place asc";
                    break;
                //���ݷ�����Ų�ѯ�÷����Ļ�����Ŀ
                case "SelectCode":
                    sql = "select StatCode from D_StatProjectItem where Code = @Code Order By Place asc";
                    break;
                //���ݷ�����Ų�ѯ�÷����Ļ�����Ŀ
                case "SelectEidtCode":
                    sql = "select StatCode from D_StatProjectItem where Code = @Code  Order By Place desc";
                    break;
                //����
                case "Selecttype":
                    sql = "select Code,Name from D_Type";
                    break;
                //��ѯȫ�����������ֶ�
                case "Select_V_C_Stat":
                    sql = "select ID,[As],Name,Place,Show,DBName,fun from V_C_Stat Order By Place asc";
                    break;
                //��ѯfun�����ֶ�
                case "Selectfun":
                    sql = "select Fun,Name from C_Function";
                    break;
                //��������
                case "Update":
                    sql = "Update C_Stat set [As]=@As,Show=@Show,Place=@Place,Fun=@Fun where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
