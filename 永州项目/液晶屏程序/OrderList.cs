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
using SpeechLib;
using System.Diagnostics;

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
            this.Run();
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
        /// 送货单提交语音提醒
        /// </summary>
        public void submitVoice()
        {
            //有未提交送货单，1号或者2号任意一台链板机等待车辆数<2
            DataTable dtUnAlarmNum = bll.getRegistrationInfos("where workstate='0'");//未提交送货单车辆
            DataTable dtUnAlarmNumHand = bll.getRegistrationInfos("where workstate='0' and alarmnum=-1");//未提交送货单车辆(手动调度状态)
            int num1 = bll.getRegistrationInfos("where workstate='1' and  port='1'").Rows.Count;//1号口已提交的车辆数
            int num2 = bll.getRegistrationInfos("where workstate='1' and  port='2'").Rows.Count;//2号口已提交的车辆数
            int unSubmitNum = int.Parse(bll.getParameters("where parameter_name='unSubmit'").Rows[0]["parameter_value"].ToString());//提交送货单条件
            int alarmnum = int.Parse(bll.getParameters("where parameter_name='alarmnum'").Rows[0]["parameter_value"].ToString());//报警提示次数
            int sum1 = unSubmitNum - num1 > 0 ? unSubmitNum - num1 : 0;//1号入库口可排队车辆数
            int sum2 = unSubmitNum - num2 > 0 ? unSubmitNum - num2 : 0;//2号入库口可排队车辆数
            if (dtUnAlarmNumHand.Rows.Count > 0)
            {
                for (int i = 0; i < dtUnAlarmNumHand.Rows.Count; i++)
                {
                    for (int j = 0; j < alarmnum; j++)
                    {
                        Voice("请'" + dtUnAlarmNumHand.Rows[i]["carcode"] + "'前去提交送货单");
                    }
                    bll.updateAlarmnum("where id='" + dtUnAlarmNumHand.Rows[i]["id"] + "'");
                }
            }
            else if ((sum1 > 0 || sum2 > 0) && dtUnAlarmNum.Rows.Count > 0)
            {
                for (int i = 0; i < sum1 + sum2; i++)
                {
                    if (int.Parse(dtUnAlarmNum.Rows[i]["alarmnum"].ToString()) < 1)
                    {
                        for (int j = 0; j < alarmnum; j++)
                        {
                            Voice("请'" + dtUnAlarmNum.Rows[i]["carcode"] + "'前去提交送货单");
                        }
                        bll.updateAlarmnum("where id='" + dtUnAlarmNum.Rows[i]["id"] + "'");
                    }
                }
            }
        }
        /// <summary>
        /// 开始卸烟语音提醒
        /// </summary>
        public void workVoice(int port)
        {
            //已提交送货单车辆数>0，正在卸货车辆数>0正在卸货的车辆任务总量=完成量
            DataTable dtWorkNum = bll.getRegistrationInfos("where workstate='2' and port='"+port+"'");//正在卸烟车辆
            DataTable dtUnWorkNumAuto = bll.getRegistrationInfos("where workstate='1' and port='" + port + "' order by billno");//自动调度状态
            DataTable dtUnWorkNumHand = bll.getRegistrationInfos("where workstate='1' and alarmnum=-1 and port='" + port + "' order by billno");//手动调度状态
            int alarmnum = int.Parse(bll.getParameters("where parameter_name='alarmnum'").Rows[0]["parameter_value"].ToString());//报警提示次数
            if (dtWorkNum.Rows.Count > 0)
            {
                if (dtUnWorkNumHand.Rows.Count > 0)
                {
                    if (int.Parse(dtUnWorkNumHand.Rows[0]["alarmnum"].ToString()) < 1)
                    {
                        for (int j = 0; j < alarmnum; j++)
                        {
                            Voice("请'" + dtUnWorkNumHand.Rows[0]["carcode"] + "'开车来到'" + port + "号入库口，等待卸烟");
                        }
                        bll.updateAlarmnum("where id='" + dtUnWorkNumHand.Rows[0]["id"] + "'");
                    }
                }
            }
            else
            {
                if (dtUnWorkNumAuto.Rows.Count > 0)
                {
                    if (int.Parse(dtUnWorkNumAuto.Rows[0]["alarmnum"].ToString()) < 1)
                    {
                        for (int j = 0; j < alarmnum; j++)
                        {
                            Voice("请'" + dtUnWorkNumAuto.Rows[0]["carcode"] + "'开车来到'" + port + "号入库口，等待卸烟");
                        }
                        bll.updateAlarmnum("where id='" + dtUnWorkNumAuto.Rows[0]["id"] + "'");
                    }
                }
            }
        }
        //语音提示公共方法
        public void Voice(string voice)
        {
            SpeechVoiceSpeakFlags SpFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice Voice = new SpVoice();
            Voice.Rate = -2;
            Voice.Speak(voice, SpFlags);
            Voice.WaitUntilDone(5000);
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
            DataTable dtAllUnSubmit = bll.getRegistrationInfos("where workstate='0' order by id");
            int unSubmit = dtAllUnSubmit.Rows.Count;
            if (unSubmit > 0)
            {
                lbbillnolist.Text = "";
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

            registrationInfosShouw();//送货单排队信息展示

            storageTaskShow(1);//1号链板机入库等待车辆信息展示
            storageTaskShow(2);//2号链板机入库等待车辆信息展示

            CurrentStorageTaskShow(1);//1号链板机当前正在入库车辆信息展示
            CurrentStorageTaskShow(2);//2号链板机当前正在入库车辆信息展示

            lblTimeTxt.Text = DateTime.Now.ToString();
        }
        private void RunVoice()
        {
            submitVoice();//提交送货单语音提醒

            workVoice(1);//1号入库口卸烟语音提醒

            workVoice(2);//2号入库口卸烟语音提醒
        }
        private static void showmessage(object message)
        {
            string temp = (string)message;
            Console.WriteLine(message);
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
            this.timer2.Interval = Convert.ToInt32(config.getTimerIntervalVoice());
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
            this.timer2.Enabled = true;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.RunVoice();
        }
    }
}
