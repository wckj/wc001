using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpeechLib;

namespace delivery
{
    public partial class Add : Form
    {
        dal da = new dal();
        private allinformation allinformationFrom;
        RegistrationInfo registrationinformation = new RegistrationInfo();
        public Add(int id, allinformation allinformationFroms)
        {
            InitializeComponent();
            lbid.Text = id.ToString();
            allinformationFrom = allinformationFroms;
            
        }
        private void Add_Load(object sender, EventArgs e)
        {
            lbid.Visible = false;
            getCobaddressValue();
            if (lbid.Text == "" || lbid.Text == "0")
            {
                this.cobaddress.Text = "";
            }
            else
            {
                updateRegistrationInfo(int.Parse(lbid.Text));
            }
        }
        public void updateRegistrationInfo(int id)
        {
            DataTable dtRegistrationInfo = da.registrationInfo("where id='" + id + "'");
            if (dtRegistrationInfo.Rows.Count > 0)
            {
                lbid.Text = id.ToString();
                txbcarcode.Text = dtRegistrationInfo.Rows[0]["carcode"].ToString();
                txbbillno.Text = dtRegistrationInfo.Rows[0]["brandno"].ToString();
                txbphone.Text = dtRegistrationInfo.Rows[0]["phone"].ToString();
                cobaddress.Text = dtRegistrationInfo.Rows[0]["address_name"].ToString();
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Dispose();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txbcarcode.Text != "" && txbbillno.Text != "" && txbphone.Text != "" && cobaddress.SelectedValue != null)
            {
                registrationinformation._id =int.Parse(lbid.Text);
                registrationinformation._carcode = txbcarcode.Text;
                registrationinformation._brandno = txbbillno.Text;
                registrationinformation._phone = txbphone.Text;
                registrationinformation._daytime = DateTime.Now;
                registrationinformation._address = cobaddress.SelectedValue.ToString();
                registrationinformation._workstate = "0";
                registrationinformation._name = "送货司机";
                registrationinformation._state = "送货";
                registrationinformation._memo = "";
                registrationinformation._port = "0";
                string voices = "请" + txbcarcode.Text + "前去提交送货单！";
                string log = "";
                if (da.addRegistrationInfo(registrationinformation, out log))
                {
                    DataTable dtUnAlarmNum = da.registrationInfo("where workstate='0'");//未提交送货单车辆
                    int num1 = da.registrationInfo("where workstate='1' and  port='1'").Rows.Count;//1号口已提交的车辆数
                    int num2 = da.registrationInfo("where workstate='1' and  port='2'").Rows.Count;//2号口已提交的车辆数
                    int unSubmitNum = int.Parse(da.getParameters("where parameter_name='unSubmit'").Rows[0]["parameter_value"].ToString());//提交送货单条件
                    int alarmnum = int.Parse(da.getParameters("where parameter_name='alarmnum'").Rows[0]["parameter_value"].ToString());//报警提示次数
                    int sum1 = unSubmitNum - num1 > 0 ? unSubmitNum - num1 : 0;//1号入库口可排队车辆数
                    int sum2 = unSubmitNum - num2 > 0 ? unSubmitNum - num2 : 0;//2号入库口可排队车辆数
                    if ((sum1 > 0 || sum2 > 0) && dtUnAlarmNum.Rows.Count > 0)
                    {
                        for (int i = 0; i < sum1 + sum2; i++)
                        {
                            if (int.Parse(dtUnAlarmNum.Rows[i]["alarmnum"].ToString()) < 1 && dtUnAlarmNum.Rows[i]["carcode"].ToString() == txbcarcode.Text)
                            {
                                for (int j = 0; j < alarmnum; j++)
                                {
                                    Voice("请'" + dtUnAlarmNum.Rows[i]["carcode"] + "'前去提交送货单");
                                }
                                da.updateAlarmnum("where id='" + dtUnAlarmNum.Rows[i]["id"] + "'");
                            }
                        }
                    }
                    if (num1 < unSubmitNum || num2 < unSubmitNum)
                    {
                        for (int i = 0; i < alarmnum; i++)
                        {
                            Voice(voices);
                        }
                        da.updateAlarmnum("where brandno='" + txbbillno .Text+ "'");
                    }
                    this.Close();
                    allinformation ower = (allinformation)this.Owner;
                    allinformationFrom.getDataGridView();
                }
                else
                {
                    MessageBox.Show(log);
                }
            }
            else
            {
                MessageBox.Show("登记信息不能为空，请补充完整！");
            }
        }
        /// <summary>
        /// 语音提醒该车辆提交送货单
        /// </summary>0：未提交 1：已提交  2：卸货中  3 卸货完成
        /// <param name="voices"></param>
        public void Voice(string voices)
        {
            SpeechVoiceSpeakFlags SpFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice Voice = new SpVoice();
            Voice.Rate = -5;
            Voice.Speak(voices, SpFlags);
        }

        private void btnadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnadd_Click(null, null);
        }
        /// <summary>
        /// 助记码生成
        /// </summary>
        /// <param name="ChineseStr"></param>
        /// <returns></returns>
        public static string VailCode(string ChineseStr)
        {
            byte[] ZW = new byte[2];
            long ChineseStr_int;
            string Capstr = "", ChinaStr = "";
            for (int i = 0; i < ChineseStr.Length; i++)
            {
                ZW = System.Text.Encoding.Default.GetBytes(ChineseStr.Substring(i, 1).ToString());
                if (ZW.Length == 2)
                {
                    int i1 = (short)(ZW[0]);
                    int i2 = (short)(ZW[1]);
                    ChineseStr_int = i1 * 256 + i2;

                    if ((ChineseStr_int >= 45217) && (ChineseStr_int <= 45252))
                    {
                        ChinaStr = "A";
                    }
                    else if ((ChineseStr_int >= 45253) && (ChineseStr_int <= 45760))
                    {
                        ChinaStr = "B";
                    }
                    else if ((ChineseStr_int >= 45761) && (ChineseStr_int <= 46317))
                    {
                        ChinaStr = "C";

                    }
                    else if ((ChineseStr_int >= 46318) && (ChineseStr_int <= 46825))
                    {
                        ChinaStr = "D";
                    }
                    else if ((ChineseStr_int >= 46826) && (ChineseStr_int <= 47009))
                    {
                        ChinaStr = "E";
                    }
                    else if ((ChineseStr_int >= 47010) && (ChineseStr_int <= 47296))
                    {
                        ChinaStr = "F";
                    }
                    else if ((ChineseStr_int >= 47297) && (ChineseStr_int <= 47613))
                    {
                        ChinaStr = "G";
                    }
                    else if ((ChineseStr_int >= 47614) && (ChineseStr_int <= 48118))
                    {

                        ChinaStr = "H";
                    }

                    else if ((ChineseStr_int >= 48119) && (ChineseStr_int <= 49061))
                    {
                        ChinaStr = "J";
                    }
                    else if ((ChineseStr_int >= 49062) && (ChineseStr_int <= 49323))
                    {
                        ChinaStr = "K";
                    }
                    else if ((ChineseStr_int >= 49324) && (ChineseStr_int <= 49895))
                    {
                        ChinaStr = "L";
                    }
                    else if ((ChineseStr_int >= 49896) && (ChineseStr_int <= 50370))
                    {
                        ChinaStr = "M";
                    }

                    else if ((ChineseStr_int >= 50371) && (ChineseStr_int <= 50613))
                    {
                        ChinaStr = "N";

                    }
                    else if ((ChineseStr_int >= 50614) && (ChineseStr_int <= 50621))
                    {
                        ChinaStr = "O";
                    }
                    else if ((ChineseStr_int >= 50622) && (ChineseStr_int <= 50905))
                    {
                        ChinaStr = "P";

                    }
                    else if ((ChineseStr_int >= 50906) && (ChineseStr_int <= 51386))
                    {
                        ChinaStr = "Q";

                    }

                    else if ((ChineseStr_int >= 51387) && (ChineseStr_int <= 51445))
                    {
                        ChinaStr = "R";
                    }
                    else if ((ChineseStr_int >= 51446) && (ChineseStr_int <= 52217))
                    {
                        ChinaStr = "S";
                    }
                    else if ((ChineseStr_int >= 52218) && (ChineseStr_int <= 52697))
                    {
                        ChinaStr = "T";
                    }
                    else if ((ChineseStr_int >= 52698) && (ChineseStr_int <= 52979))
                    {
                        ChinaStr = "W";
                    }
                    else if ((ChineseStr_int >= 52980) && (ChineseStr_int <= 53688))
                    {
                        ChinaStr = "X";
                    }

                    else if ((ChineseStr_int >= 53689) && (ChineseStr_int <= 54480))
                    {
                        ChinaStr = "Y";
                    }
                    else if ((ChineseStr_int >= 54481) && (ChineseStr_int <= 55289))
                    {
                        ChinaStr = "Z";
                    }
                }
                else
                {
                    ChinaStr = ChineseStr.Substring(i, 1);
                }
                Capstr += ChinaStr;
            }
            return Capstr;
        }
        public void getCobaddressValue()
        {
            cobaddress.Items.Clear();
            DataTable dt = da.getAdress("");
            this.cobaddress.DataSource = dt;
            this.cobaddress.DisplayMember = "address_name";
            this.cobaddress.ValueMember = "address_code";
        }

        private void cobaddress_TextUpdate(object sender, EventArgs e)
        {
            string keys = cobaddress.Text.Trim();
            DataTable dt = da.getAdress("where address_code LIKE '%" + keys + "%' or address_name LIKE '%" + keys + "%' or  shortname LIKE '%" + keys + "%'");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                
                cobaddress.DroppedDown = true;
                cobaddress.DataSource = dt;
                cobaddress.DisplayMember = "address_name";
                cobaddress.ValueMember = "address_code";
                Cursor.Current = Cursors.Default;//设置鼠标显示
                cobaddress.Refresh();
                cobaddress.Text = keys;
                cobaddress.SelectionStart = cobaddress.Text.Length;
            }
            if (dt.Rows.Count == 0)
            {
                cobaddress.DroppedDown = false;
            }
        }
    }
}
