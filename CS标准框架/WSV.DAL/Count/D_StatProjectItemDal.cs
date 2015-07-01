using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Count
{
    public class D_StatProjectItemDal : DataBaseVisitor
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
                    //ɾ��
                case "Delete":
                    sql = "Delete from D_StatProjectItem where Code=@Code";
                    break;
                    //���
                case "Insert":
                    sql = "Insert into D_StatProjectItem (Code,StatCode,Place) values(@Code,@StatCode,@Place)";
                    break;
            }
            return sql;
        }
    }
}
