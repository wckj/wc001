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
using LEDSHOW.Dao;
using THOK.Util;

namespace LEDSHOW
{
    public partial class OrderList : Form
    {
        OrderFormConfig config = new OrderFormConfig(@".\OrderFormConfig.xml");
        bool IsSendToasynChronousScreen = false;
        int _Left = 0;
        int _LeftOffset = 0;
        LedShowBLL ledShowBll = new LedShowBLL();

        public OrderList()
        {
            InitializeComponent();
        }
        private void Run()
        {
            try
            {
                lblTimeTxt.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分");
                Refresh(1, untotal(1));
                Refresh(2, untotal(2));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 正在入库车辆未完成数量
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public int untotal(int port)
        {
            DataTable currentDt = ledShowBll.getRegistrationInfos("where workstate='2' and port='" + port + "'");
            if (currentDt.Rows.Count > 0)
            {
                return int.Parse(currentDt.Rows[0]["quantity"].ToString()) - int.Parse(currentDt.Rows[0]["completeqty"].ToString());
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 界面数据刷新
        /// </summary>
        /// <param name="refreshData"></param>
        private void Refresh(int port, int untotal)
        {
            RefreshData refreshData = getdatas(port, untotal);
            lbAllWaitCars.Text = refreshData.AllWaitCas.ToString();
            int completeqty = 0;
            if (port == 1)
            {
                lblAllCurrentQty1.Text = refreshData.Total.ToString();//入库总数
                lblCurrentQty1.Text = refreshData.Untotal.ToString();//未入库数量 
                completeqty = refreshData.Total - refreshData.Untotal;
                lbwaitcars1.Text = refreshData.UnWorktotalCars.ToString();//等待入库车辆数
                lbcurrentstoragecar1.Text = refreshData.CurrentCarcode;//正在入库车牌号
                lbwaitstoragecar1.Text = refreshData.WaitCarcode;//准备入库车牌号
                if (refreshData.Total == 0)
                {
                    progressBar1.Value = 0;
                }
                else
                {
                    progressBar1.Value = (int)(Convert.ToDouble(completeqty) / refreshData.Total * 100);
                }
                lblBatchValue1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                lblAllCurrentQty2.Text = refreshData.Total.ToString();//入库总数
                lblCurrentQty2.Text = refreshData.Untotal.ToString();//未入库数量
                completeqty = refreshData.Total - refreshData.Untotal;
                lbwaitcars2.Text = refreshData.UnWorktotalCars.ToString();//等待入库车辆数
                lbcurrentstoragecar2.Text = refreshData.CurrentCarcode;//正在入库车牌号
                lbwaitstoragecar2.Text = refreshData.WaitCarcode;//准备入库车牌号
                if (refreshData.Total == 0)
                {
                    progressBar2.Value = 0;
                }
                else
                {
                    progressBar2.Value = (int)(Convert.ToDouble(completeqty) / refreshData.Total * 100);
                }
                lblBatchValue2.Text = progressBar2.Value.ToString() + "%";
            }
        }
        /// <summary>
        /// 界面数据提取
        /// </summary>
        public RefreshData getdatas(int port, int untotal)
        {
            RefreshData refreshData = new RefreshData();
            DataTable currentDt = ledShowBll.getRegistrationInfos("where workstate='2' and port='" + port + "'");
            DataTable waitCars = ledShowBll.getRegistrationInfos("where workstate='1' and port='" + port + "'");
            refreshData.AllWaitCas = ledShowBll.getRegistrationInfos("where workstate<'2'").Rows.Count;
            if (currentDt.Rows.Count > 0)
            {
                refreshData.Total = int.Parse(currentDt.Rows[0]["quantity"].ToString());
                refreshData.Untotal = untotal;
                refreshData.CurrentCarcode = currentDt.Rows[0]["carcode"].ToString();
            }
            else
            {
                refreshData.Total = 0;
                refreshData.Untotal = 0;
                refreshData.CurrentCarcode = "无";
            }
            if (waitCars.Rows.Count > 0)
            {
                refreshData.WaitCarcode = waitCars.Rows[0]["carcode"].ToString();
            }
            else
            {
                refreshData.WaitCarcode = "暂无任务！";
            }
            refreshData.UnWorktotalCars = waitCars.Rows.Count;
            return refreshData;
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
