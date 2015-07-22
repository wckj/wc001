using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarDispatch
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //绑定未递交货运单所有的车辆数据
        private void CarDataBind()
        {
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.DataSource = Bll.CarMain.MainBlll.SelectAllCar("0").Tables[0];
        }

        //绑定1号伸缩链板机的未卸货排队车辆数据
        private void DataBind1()
        {
            this.myDataGridView2.AutoGenerateColumns = false;
            this.myDataGridView2.DataSource = Bll.CarMain.MainBlll.SelectAll("1", "").Tables[0];
        }

        //绑定2号伸缩链板机的未卸货排队车辆数据
        private void DataBind2()
        {
            this.myDataGridView3.AutoGenerateColumns = false;
            this.myDataGridView3.DataSource = Bll.CarMain.MainBlll.SelectAll("2", "").Tables[0];
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //BLL.PublicFun.IniFile Ini = new BLL.PublicFun.IniFile(Model.FilePath.Config);
            this.button1.Text = "开始调度";
            CarDataBind();
            this.myDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.comboBox1.Text = "请选择车牌号";
            //if (this.myDataGridView1.Rows.Count > 0)
            //    this.myDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataBind1();
            DataBind2();
            this.label32.Text = Bll.CarMain.MainBlll.SelectAllCar("1").Tables[0].Rows[0][0].ToString();
        }

        //调度按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "开始调度")
            {
                if (Bll.CarMain.MainBlll.UpdateCarDispatchState("1") == "0101")
                {
                    this.button1.Text = "停止调度";
                    GetInfo();
                }
            }
            else
            {
                if (Bll.CarMain.MainBlll.UpdateCarDispatchState("0") == "0101")
                {
                    this.button1.Text = "开始调度";

                }
            }
        }

        //关闭窗口
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.button1.Text == "停止调度")
            {
                BaseClass.Function.MessageWarning("退出前，请先停止车辆调度！");
                this.Owner = this;
            }
        }

        //参数设置
        private void button5_Click(object sender, EventArgs e)
        {
            inform.inform frm = new inform.inform();
            frm.ShowDialog();
        }

        //手动调度
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //获得卸烟信息
        private void GetInfo()
        {
            //1号伸缩链板机正在卸烟车辆信息
            if (Bll.CarMain.MainBlll.GetInfo("1").Tables[0].Rows.Count > 0)
            {
                this.label3.Text = Bll.CarMain.MainBlll.GetInfo("1").Tables[0].Rows[0][0].ToString();
                this.label33.Text = Bll.CarMain.MainBlll.GetInfo("1").Tables[0].Rows[0][1].ToString();
                this.label5.Text = Bll.CarMain.MainBlll.GetInfo("1").Tables[0].Rows[0][2].ToString();
                int x = Int32.Parse(this.label5.Text.Trim());
                int y = Int32.Parse(Bll.CarMain.MainBlll.GetInfo("1").Tables[0].Rows[0][3].ToString());
                this.label7.Text = (x - y).ToString();
                this.label15.Text = Bll.CarMain.MainBlll.SelectAll("1", "").Tables[0].Rows[0][0].ToString();
                this.label34.Text = Bll.CarMain.MainBlll.SelectAll("1", "").Tables[0].Rows[0][1].ToString();
            }
            else
            {
                this.label3.Text = "";
                this.label33.Text = "";
                this.label5.Text = "";
                this.label7.Text = "";
                this.label15.Text = "";
                this.label34.Text = "";
            }
            //2号伸缩链板机正在卸烟车辆信息
            if (Bll.CarMain.MainBlll.GetInfo("2").Tables[0].Rows.Count > 0)
            {
                this.label30.Text = Bll.CarMain.MainBlll.GetInfo("2").Tables[0].Rows[0][0].ToString();
                this.label35.Text = Bll.CarMain.MainBlll.GetInfo("2").Tables[0].Rows[0][1].ToString();
                this.label28.Text = Bll.CarMain.MainBlll.GetInfo("2").Tables[0].Rows[0][2].ToString();
                int x = Int32.Parse(this.label5.Text.Trim());
                int y = Int32.Parse(Bll.CarMain.MainBlll.GetInfo("2").Tables[0].Rows[0][3].ToString());
                this.label26.Text = (x - y).ToString();
                this.label24.Text = Bll.CarMain.MainBlll.SelectAll("2", "").Tables[0].Rows[0][0].ToString();
                this.label36.Text = Bll.CarMain.MainBlll.SelectAll("2", "").Tables[0].Rows[0][1].ToString();
            }
            else
            {
                this.label30.Text = "";
                this.label35.Text = "";
                this.label28.Text = "";
                this.label26.Text = "";
                this.label24.Text = "";
                this.label36.Text = "";
            }
        }

        private void Getbrush()
        {
            this.label32.Text = "";
            this.label3.Text = "";
            this.label33.Text = "";
            this.label5.Text = "";
            this.label7.Text = "";
            this.label15.Text = "";
            this.label34.Text = "";
            this.label30.Text = "";
            this.label35.Text = "";
            this.label28.Text = "";
            this.label26.Text = "";
            this.label24.Text = "";
            this.label36.Text = "";
        }

        //中烟接口信息
        private void GetbrushInfo()
        {
            if(this.label7.Text =="0")
            {}
        }
    }
}
