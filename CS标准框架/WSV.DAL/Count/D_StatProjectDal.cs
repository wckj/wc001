using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Count
{
    public class D_StatProjectDal : DataBaseVisitor
    {
        // <summary>
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
                //��ѯȫ������
                case "Select":
                    sql = "select Name,Code from D_StatProject";
                    break;
                //���ݷ������Ҷ�Ӧ�������ֶ�
                case "SelectByCode":
                    sql = "select Code,place from V_C_Stat where ProCode=@ProCode";
                    break;
                //���ݷ�����ȫ���Ķ�Ӧ��Ϣ
                case "SelectByName":
                    sql = "select Type,SataType,Flag,Month,Day,BeginTime,EndTime from D_StatProject where Name=@Name";
                    break;
                //����·���
                case "Insert":
                    sql = "Insert into D_StatProject (ID,Code,Name) values(@ID,@Code,@Name)  ";
                    break;
                //�޸ķ���
                case "Update":
                    sql = "update D_StatProject set Type=@Type,SataType=@SataType,Flag=@Flag,Month=@Month,Day=@Day,BeginTime=@BeginTime,EndTime=@EndTime where Code=@Code";
                    break;
                    break;
                //ɾ������
                case "Delete":
                    sql = "Delete from D_StatProject where Code=@Code";
                    break;
            }
            return sql;
        }
    }
}
