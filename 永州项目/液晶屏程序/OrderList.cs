using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataRabbit.DBAccessing.Application;
using DataRabbit.DBAccessing;
using DataRabbit.DBAccessing.ORM;
using DataRabbit.HashOrm;
using DataRabbit;
using System.Threading;
using LEDSHOW.BLL;
using THOK.Util;
using LEDSHOW.Dao;

namespace LEDSHOW
{
    public partial class OrderList : Form
    {
        OrderFormConfig config = new OrderFormConfig(@".\OrderFormConfig.xml");
        LedShowBLL bll = new LedShowBLL();
        bool IsSendToasynChronousScreen = false;
        int _Left = 0;
        int _LeftOffset = 0;

        public OrderList()
        {
            InitializeComponent();
            lblTimeTxt.Text = DateTime.Now.ToString();
            Run();
        }
        /// <summary>
        /// 获取调度工作状态
        /// </summary>
        public bool getWorkState()
        {
            if (bll.getParameters("where parameter_name='state'").Rows[0]["parameter_value"].ToString()=="0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 计算等待时间
        /// </summary>
        /// <param name="port"></param>
        /// <param name="unCompletenum"></param>
        /// <returns></returns>
        public string getrate(int port, int unCompletenum)
        {
            int rate = int.Parse(bll.getParameters("where parameter_name='Rate'").Rows[0]["parameter_value"].ToString());
            string waitTimes = "";
            if ((Math.Round((decimal)unCompletenum / rate, 2) * 60) >= 60)
            {
                waitTimes = (Math.Round((decimal)unCompletenum / rate, 2)).ToString() + "小时";
            }
            else
            {
                waitTimes = (Math.Round((decimal)unCompletenum / rate, 2) * 60).ToString() + "分钟";
            }
            return waitTimes;
        }
        /// <summary>
        /// 该车辆前边未卸货总任务数量
        /// </summary>
        /// <param name="port"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int workTaskQty(int port, string id)
        {
            return bll.workTaskQty("where workstate='1' and port='" + port + "' and id<'" + id + "'");
        }
        /// <summary>
        /// 正在入库车辆未完成数量
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public int untotal(int port)
        {
            DataTable currentDt = bll.getRegistrationInfos("where workstate='2' and port='" + port + "'");
            if (currentDt.Rows.Count > 0)
            {
                return int.Parse(currentDt.Rows[0]["quantity"].ToString())-int.Parse(currentDt.Rows[0]["completeqty"].ToString());
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 工作状态展示
        /// </summary>
        public void workStateShow()
        {
            if (getWorkState())
            {
                lbworkstate.Text = "调度作业进行中！";
                lbworkstate.ForeColor = Color.Green;
            }
            else
            {
                lbworkstate.Text = "调度作业已停止！";
                lbworkstate.ForeColor = Color.Red;
            }
        }
        /// <summary>
        /// 送货单排队信息展示
        /// </summary>
        public void registrationInfosShouw()
        {
            lbbillnolist.Text = "";
            DataTable dtAllUnSubmit = bll.getRegistrationInfos("where workstate='0' order by id");
            int unSubmit = dtAllUnSubmit.Rows.Count;
            if (unSubmit > 0)
            {
                for (int i = 0; i < unSubmit; i++)
                {
                    lbbillnolist.Text += dtAllUnSubmit.Rows[i]["carcode"].ToString() + "     ";
                    lbbillnolist.ForeColor = Color.Red;
                }
            }
            else
            {
                lbbillnolist.Text = "所有送货单均已提交，暂无任务！";
                lbbillnolist.ForeColor = Color.Green;
            }      
        }
        /// <summary>
        /// 链板机入库等待车辆信息展示
        /// </summary>
        public void storageTaskShow(int port)
        {
            DataTable dtAllSubmit = bll.getRegistrationInfos("where workstate='1' and port='" + port + "' order by billno");
            int allSubmit = dtAllSubmit.Rows.Count;
            int unCompletenQty = untotal(port);
            if (port == 1)
            {
                lbno1.Text = "";
                lbno12.Text = "";
                if (allSubmit > 0)
                {
                    for (int i = 0; i < allSubmit; i++)
                    {
                        if (i == 0)
                        {
                            lbno1.Text = dtAllSubmit.Rows[i]["carcode"].ToString() + ": 等待时间约 " + getrate(port, workTaskQty(port, dtAllSubmit.Rows[i]["id"].ToString()) + unCompletenQty);
                            lbno1.ForeColor = Color.Red;
                        }
                        else
                        {

                            lbno12.Text += dtAllSubmit.Rows[i]["carcode"].ToString() + ": 等待时间约 " + getrate(port, workTaskQty(port, dtAllSubmit.Rows[i]["id"].ToString()) + unCompletenQty) + Environment.NewLine;
                            lbno12.ForeColor = Color.Green;
                        }
                    }
                }
                else
                {
                    lbno1.Text = "没有等待车辆，暂无任务！";
                    lbno1.ForeColor = Color.Green;
                }  
            }
            else
            {
                lbno2.Text = "";
                lbno22.Text = "";
                if (allSubmit > 0)
                {
                    for (int i = 0; i < allSubmit; i++)
                    {
                        if (i == 0)
                        {
                            lbno2.Text = dtAllSubmit.Rows[i]["carcode"].ToString() + ": 等待时间约 " + getrate(port, workTaskQty(port, dtAllSubmit.Rows[i]["id"].ToString()) + unCompletenQty);
                            lbno2.ForeColor = Color.Red;
                        }
                        else
                        {

                            lbno22.Text += dtAllSubmit.Rows[i]["carcode"].ToString() + ": 等待时间约 " + getrate(port, workTaskQty(port, dtAllSubmit.Rows[i]["id"].ToString()) + unCompletenQty) + Environment.NewLine;
                            lbno22.ForeColor = Color.Green;
                        }
                    }
                }
                else
                {
                    lbno2.Text = "没有等待车辆，暂无任务！";
                    lbno2.ForeColor = Color.Green;
                }
            }
        }
         /// <summary>
        /// 当前正在入库车辆信息展示
        /// </summary>
        public void CurrentStorageTaskShow(int port)
        {
            DataTable dtWorkCars = bll.getRegistrationInfos("where workstate='2' and port='" + port + "'");
            DataTable dtAllSubmit = bll.getRegistrationInfos("where workstate='1' and port='" + port + "'");
            int rate = int.Parse(bll.getParameters("where parameter_name='Rate'").Rows[0]["parameter_value"].ToString());
            int unCompletenQty = untotal(port);
            if (port == 1)
            {
                lbcarnum1.Text = dtAllSubmit.Rows.Count.ToString();
                lbcompletetime1.Text = getrate(port, unCompletenQty);
                if (dtWorkCars.Rows.Count > 0)
                {
                    lbcurrentcard1.Text = dtWorkCars.Rows[0]["carcode"].ToString();
                    lbaddress1.Text = dtWorkCars.Rows[0]["address_name"].ToString();
                }
                else
                {
                    lbcurrentcard1.Text = "无";
                    lbaddress1.Text = "无";
                }
            }
            else
            {
                lbcarnum2.Text = dtAllSubmit.Rows.Count.ToString();
                lbcompletetime2.Text = getrate(port, unCompletenQty);
                if (dtWorkCars.Rows.Count > 0)
                {
                    lbcurrentcard2.Text = dtWorkCars.Rows[0]["carcode"].ToString();
                    lbaddress2.Text = dtWorkCars.Rows[0]["address_name"].ToString();
                }
                else
                {
                    lbcurrentcard2.Text = "无";
                    lbaddress2.Text = "无";
                }
            }
        }
        private void Run()
        {
            workStateShow();
            registrationInfosShouw();
            storageTaskShow(1);//1号链板机
            storageTaskShow(2);//2号链板机
            CurrentStorageTaskShow(1);
            CurrentStorageTaskShow(2);
            lblTimeTxt.Text = DateTime.Now.ToString();

        }
        private Bitmap PrintForm()
        {
            Bitmap bit = new Bitmap(this.Size.Width, this.Size.Height);
            this.DrawToBitmap(bit, new Rectangle(0, 0, this.Width, this.Height));
            bit.Save("D:\\a.bmp");
            return bit;
        }
        private void PrintScreen()
        {
            Graphics graphic = this.CreateGraphics();

            Size s = this.Size;

            Image memImage = new Bitmap(s.Width, s.Height, graphic);

            Graphics memGraphic = Graphics.FromImage(memImage);

            IntPtr dc1 = graphic.GetHdc();

            IntPtr dc2 = memGraphic.GetHdc();

            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);

            graphic.ReleaseHdc(dc1);

            memGraphic.ReleaseHdc(dc2);

            memImage.Save(@".\test.jpg");

        }



        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]

        private static extern bool BitBlt(

                  IntPtr hdcDest,   //   handle   to   destination   DC     

                  int nXDest,   //   x-coord   of   destination   upper-left   corner     

                  int nYDest,   //   y-coord   of   destination   upper-left   corner     

                  int nWidth,   //   width   of   destination   rectangle     

                  int nHeight,   //   height   of   destination   rectangle     

                  IntPtr hdcSrc,   //   handle   to   source   DC     

                  int nXSrc,   //   x-coordinate   of   source   upper-left   corner     

                  int nYSrc,   //   y-coordinate   of   source   upper-left   corner     

                  System.Int32 dwRop   //   raster   operation   code     

                  );

        private void OrderList_Load(object sender, EventArgs e)
        {
            this.Top = Convert.ToInt32(config.getTop());
            this.Left = Convert.ToInt32(config.getLeft());
            this._Left = this.Left;
            this._LeftOffset = Convert.ToInt32(config.getLeftOffset());
            this.Height = Convert.ToInt32(config.getHeight());
            this.Width = Convert.ToInt32(config.getWidth());
            this.timer1.Interval = Convert.ToInt32(config.getTimerInterval());
            this.IsSendToasynChronousScreen = config.getIsSendToasynChronousScreen();

            if (IsSendToasynChronousScreen)
            {
                string[] ledaddresses = config.getLedAddressList();
                foreach (string address in ledaddresses)
                {
                    LED2008 led = LED2008.Create(Convert.ToInt32(address));

                    if (led.IsOpenScreen)
                    {
                        led.SendToLed(PrintForm());
                    }
                    else if (led.OpenScreen())
                    {
                        led.SendToLed(PrintForm());
                    }
                    else
                    {
                        MessageBox.Show(address + "号屏打开失败！请检查！", "电子标签服务", MessageBoxButtons.OK);
                    }
                }
            }

            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            this.timer1.Enabled = true;

        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (IsSendToasynChronousScreen)
            {
                string[] ledaddresses = config.getLedAddressList();
                foreach (string address in ledaddresses)
                {
                    LED2008 led = LED2008.Create(Convert.ToInt32(address));
                    led.Dispose();
                }
            }
        }
        private void SendToasynChronousScreen()
        {
            if (IsSendToasynChronousScreen)
            {
                string[] ledaddresses = config.getLedAddressList();
                foreach (string address in ledaddresses)
                {
                    LED2008 led = LED2008.Create(Convert.ToInt32(address));

                    if (led.IsOpenScreen)
                    {
                        led.SendToLed(PrintForm());
                    }
                    else if (led.OpenScreen())
                    {
                        led.SendToLed(PrintForm());
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(10000);
                this.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OpenScreen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void CloseScreen_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ExitScreen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BackShow_Click(object sender, EventArgs e)
        {
            this.Left = this._Left + this._LeftOffset;
        }

        private void ForeShow_Click(object sender, EventArgs e)
        {
            this.Left = this._Left;
        }
    }
}
