using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Search
{
    public class SearchDal : DataBaseVisitor
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
                //��ѯ���õ���Ϣ
                case "Select_V_C_Select":
                    sql = "select ID,[As],Name,DBName,Place,Show,[Print] from V_C_Select Order By Place asc";
                    break;
                //��������
                case "Update":
                    sql = "Update C_Select set [As]=@As,Show=@Show,Place=@Place where ID=@ID";
                    break;
                //ɾ������
                case "Delete":
                    sql = "Delete from D_Saver where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
