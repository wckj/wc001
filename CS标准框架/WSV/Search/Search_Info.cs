using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.Search
{
    public partial class Search_Info : Form
    {
        string My_RunCode = "";             //������־���
        private string _Sql, _DateType, _Type, _BeginTime, _EndTime, DateCode;
        /// <summary>
        /// sql ���
        /// </summary>
        public string Sql { get { return _Sql; } set { _Sql = value; } }
        /// <summary>
        /// ��������
        /// </summary>
        public string DateType { get { return _DateType; } set { _DateType = value; } }
        /// <summary>
        /// ��������
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public string BeginTime { get { return _BeginTime; } set { _BeginTime = value; } }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string EndTime { get { return _EndTime; } set { _EndTime = value; } }

        public Search_Info()
        {
            InitializeComponent();
            //this.Icon = Properties.Resources.wucheng;
        }
        private void Search_Info_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            this.Dgv_SearchInfo.DataSource = BLL.Count.CountBll.SaverInfo(this.Sql).Tables[0];
            this.lab_DateType.Text = this.Type + this.DateType;
            this.lab_BeginTime.Text = this.BeginTime;
            this.lab_EndTime.Text = this.EndTime;
            this.lab_ReportCount.Text = this.Dgv_SearchInfo.Rows.Count.ToString();
            this.lab_Explain.Text = "��ɫ�����ʾ�����ϣ�   ��ɫ�����ʾ����ˣ�";
            this.lab_Explain.ForeColor = Color.Red;
            if (this.DateType == "��ʱ����")
            {
                this.Btn_PrintMend.Enabled = false;
            }
            this.lab_DateType.Left = (this.Size.Width - lab_DateType.Width) / 2;
            if (Model.User.LUser.Id == 1)
            {
                this.Btn_Delete.Visible = true;
            }
            else
            {
                this.Btn_Delete.Visible = false;
            }
        }
        /// <summary>
        /// ��ѯ
        /// </summary>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search_Conditions searchWin = new Search_Conditions();
            this.Close();
            searchWin.ShowDialog();
        }
        /// <summary>
        /// ����DGVѡ����
        /// </summary>
        private void Dgv_SearchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //��ѡ�����
            if (e.RowIndex < 0 || e.RowIndex >= this.Dgv_SearchInfo.Rows.Count)
            { return; }
            if ((bool)this.Dgv_SearchInfo.Rows[e.RowIndex].Cells["Col_Verify"].Value)
            {
                //�����
                Btn_UnCheck.Enabled = true;
                //���
                Btn_IsCheck.Enabled = false;
                //����
                Btn_IsUsed.Enabled = false;
                //������
                Btn_UnUsed.Enabled = false;
                //�޸�
                Btn_Updata.Enabled = false;
                //ɾ��
                Btn_Delete.Enabled = false;
                //����
                Btn_PrintMend.Enabled = true;
            }
            else if ((bool)this.Dgv_SearchInfo.Rows[e.RowIndex].Cells["Col_Used"].Value)
            {
                Btn_IsUsed.Enabled = false;
                Btn_UnUsed.Enabled = true;
                Btn_UnCheck.Enabled = false;
                Btn_IsCheck.Enabled = false;
                Btn_Updata.Enabled = false;
                Btn_Delete.Enabled = true;
                Btn_PrintMend.Enabled = false;
            }
            else
            {
                Btn_IsUsed.Enabled = true;
                Btn_UnUsed.Enabled = false;
                Btn_UnCheck.Enabled = false;
                Btn_IsCheck.Enabled = true;
                Btn_Updata.Enabled = true;
                Btn_Delete.Enabled = true;
                Btn_PrintMend.Enabled = true;
            }
            this.DateCode = this.Dgv_SearchInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        /// <summary>
        /// ��ӡ
        /// </summary>
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            //Print.PrintDGV.Print_DataGridView(this.Dgv_SearchInfo, this.lab_DateType.Text, "");
        }
        /// <summary>
        /// ����
        /// </summary>
        private void Btn_Export_Click(object sender, EventArgs e)
        {
            BaseClass.ExportExcel Export = new WSV.BaseClass.ExportExcel();
            Export.Export(this.Dgv_SearchInfo);
        }
        /// <summary>
        /// �޸�
        /// </summary>
        private void Btn_Updata_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_Updata.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("�޴�Ȩ�ޣ�");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫ�޸ĵ���Ϣ��");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "1";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// ˢ��
        /// </summary>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            BindDGV();
        }
        /// <summary>
        /// ɾ��
        /// </summary>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫɾ������Ϣ��");
                return;
            }
            if (BaseClass.Function.MessageYesNo("ȷ��Ҫɾ��ѡ����Ϣ��"))
            {
                for (int i = 0; i < this.Dgv_SearchInfo.SelectedRows.Count; i++)
                {
                    BLL.Search.SearchBll.Delete(Convert.ToInt32(this.Dgv_SearchInfo.Rows[i].Cells[0].Value));
                }
                BaseClass.Function.Message("ɾ���ɹ���");
            }
            BindDGV();
        }
        /// <summary>
        /// ���
        /// </summary>
        private void Btn_IsCheck_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_IsCheck.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("�޴�Ȩ�ޣ�");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫ��˵���Ϣ��");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "2";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// �����
        /// </summary>
        private void Btn_UnCheck_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_UnCheck.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("�޴�Ȩ�ޣ�");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫ����˵���Ϣ��");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "3";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// ����
        /// </summary>
        private void Btn_IsUsed_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_IsUsed.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("�޴�Ȩ�ޣ�");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫ���ϵ���Ϣ��");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "4";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// ������
        /// </summary>
        private void Btn_UnUsed_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_UnUsed.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("�޴�Ȩ�ޣ�");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫ�����ϵ���Ϣ��");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "5";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// ����
        /// </summary>
        private void Btn_PrintMend_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_PrintMend.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("�޴�Ȩ�ޣ�");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫ�������Ϣ��");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "6";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
        }
        /// <summary>
        /// �˳�
        /// </summary>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Search_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);           //������¼
        }
        /// <summary>
        /// �������
        /// </summary>
        private void Search_Info_Resize(object sender, EventArgs e)
        {
            this.lab_DateType.Left = (this.Size.Width - lab_DateType.Width) / 2;
        }
        /// <summary>
        /// ��DGV
        /// </summary>
        private void BindDGV()
        {
            this.Dgv_SearchInfo.DataSource = BLL.Count.CountBll.SaverInfo(this.Sql).Tables[0];
            if (Dgv_SearchInfo.Rows.Count > 0)
            {
                for (int i = 0; i < Dgv_SearchInfo.Rows.Count; i++)
                {
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Verify"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Used"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }
        /// <summary>
        /// ����Ҽ��˵�
        /// </summary>
        private void Dgv_SearchInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }
        /// <summary>
        /// ��һ����ʾ���壬dgv������ɫ
        /// </summary>
        private void Search_Info_Shown(object sender, EventArgs e)
        {
            if (Dgv_SearchInfo.Rows.Count > 0)
            {
                for (int i = 0; i < Dgv_SearchInfo.Rows.Count; i++)
                {
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Verify"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Used"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }
        /// <summary>
        /// ��ͼƬ����
        /// </summary>
        private void Dgv_SearchInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmImage frmIge = new FrmImage();
            if (this.DateType == "��ʱ����")
            {
                frmIge.Flag = false;
            }
            frmIge.Code = this.DateCode;
            frmIge.ShowDialog();
        }

        private void Btn_Pic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.DateCode))
            {
                BaseClass.Function.MessageWarning("����ѡ��Ҫ�鿴����Ϣ��");
                return;
            }
            FrmImage frmIge = new FrmImage();
            if (this.DateType == "��ʱ����")
            {
                frmIge.Flag = false;
            }
            frmIge.Code = this.DateCode;
            frmIge.ShowDialog();
        }
    }
}