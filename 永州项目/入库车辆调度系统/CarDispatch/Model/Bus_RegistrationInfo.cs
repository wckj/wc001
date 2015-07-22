using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Bus_RegistrationInfo
    {
        private int _id;              //id
        private string _name;         //司机姓名
        private string _brandno;      //货运单号
        private string _carcode;      //车牌号
        private string _phone;        //司机联系电话
        private DateTime _daytime;    //登记时间
        private string _state;        //车辆目标
        private string _memo;         //备注
        private string _port;         //伸缩链板机编号
        private string _address_code; //中烟信息编号
        private string _workstate;    //车辆工作状态
        private DateTime _worktime;   //入库开始时间
        private string _billno;       //入库单
        private int _quantity;        //入库总量
        private int _completeqty;     //已入库量

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string brandno
        {
            get { return _brandno; }
            set { _brandno = value; }
        }
        public string carcode
        {
            get { return _carcode; }
            set { _carcode = value; }
        }
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public DateTime daytime
        {
            get { return _daytime; }
            set { _daytime = value; }
        }
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public string memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        public string port
        {
            get { return _port; }
            set { _port = value; }
        }
        public string address_code
        {
            get { return _address_code; }
            set { _address_code = value; }
        }
        public string workstate
        {
            get { return _workstate; }
            set { _workstate = value; }
        }
        public DateTime worktime
        {
            get { return _worktime; }
            set { _worktime = value; }
        }
        public string billno
        {
            get { return _billno; }
            set { _billno = value; }
        }
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int completeqty
        {
            get { return _completeqty; }
            set { _completeqty = value; }
        }
    }
}
