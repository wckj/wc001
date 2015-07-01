using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV;

namespace WSV.Count
{
    public partial class FrmCount_Info : Form
    {
        public FrmCount_Info()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
        }
        string My_RunCode = "";             //������־���
        private string _Sql, _BeginTime, _EndTime, _ReportName, _ReportType, _Byname, _sqlCountInfo;
        /// <summary>
        /// sql ���
        /// </summary>
        public string Sql { get { return _Sql; } set { _Sql = value; } }
        /// <summary>
        ///  ��ʼʱ��
        /// </summary>
        public string BeginTime { get { return _BeginTime; } set { _BeginTime = value; } }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string EndTime { get { return _EndTime; } set { _EndTime = value; } }
        /// <summary>
        /// ��������
        /// </summary>
        public string ReportName { get { return _ReportName; } set { _ReportName = value; } }
        /// <summary>
        /// ��������
        /// </summary>
        public string ReportType { get { return _ReportType; } set { _ReportType = value; } }
        /// <summary>
        /// ���ܵĵ�һ���ֶ�
        /// </summary>
        public string Byname { get { return _Byname; } set { _Byname = value; } }
        /// <summary>
        /// ���ܵ�����
        /// </summary>
        public string sqlCountInfo { get { return _sqlCountInfo; } set { _sqlCountInfo = value; } }

        private void FrmCount_Info_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            this.Dgv_CountInfo.DataSource = BLL.Count.CountBll.SaverInfo(Sql).Tables[0];
            this.Dgv_CountInfo[0, this.Dgv_CountInfo.Rows.Count - 1].Value = "�ϼ�";
            this.lab_BeginTime.Text = this.BeginTime;
            this.lab_EndTime.Text = this.EndTime;
            int Flag = this.Dgv_CountInfo.Rows.Count - 1;
            this.lab_ReportCount.Text = Flag.ToString();
            this.lab_RepotType.Text = this.ReportType;
            this.lab_ReportName.Text = this.ReportName;
            this.panel5.Left = (this.Size.Width - panel5.Width) / 2;
        }
        /// <summary>
        /// �˳�
        /// </summary>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// ��ӡ
        /// </summary>
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            //Print.PrintDGV.Print_DataGridView(this.Dgv_CountInfo, this.ReportType + this.ReportName, "");
        }
        /// <summary>
        /// ����
        /// </summary>
        private void Btn_ToExecel_Click(object sender, EventArgs e)
        {
            BaseClass.ExportExcel export = new WSV.BaseClass.ExportExcel();
            export.Export(this.Dgv_CountInfo);
        }
        /// <summary>
        /// ���ػ��ܹ���
        /// </summary>
        private void Btn_Count_Click(object sender, EventArgs e)
        {
            FrmCount CountWin = new FrmCount();
            this.Close();
            CountWin.ShowDialog();
        }
        /// <summary>
        /// �������С
        /// </summary>
        private void FrmCount_Info_Resize(object sender, EventArgs e)
        {
            this.panel5.Left = (this.Size.Width - panel5.Width) / 2;
        }

        private void FrmCount_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);           //������¼
        }
        private void Btn_VCount_Click(object sender, EventArgs e)
        {
            Graph GraphWin = new Graph();
            GraphWin.Title = this.ReportType + this.ReportName + "(" + this.BeginTime + "��" + this.EndTime + ")";
            GraphWin.ByName = this.Byname;
            GraphWin.sqlCount = this.sqlCountInfo;
            GraphWin.ShowDialog();
        }
    }
}