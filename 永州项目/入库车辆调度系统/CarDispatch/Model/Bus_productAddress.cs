using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Bus_productAddress
    {
        private string _address_code; //中烟信息编号
        private string _address_name; //中烟信息名称
        private string _shortname;    //中烟信息名称助记码

        public string address_code
        {
            get { return _address_code; }
            set { _address_code = value; }
        }
        public string address_name
        {
            get { return _address_name; }
            set { _address_name = value; }
        }
        public string shortname
        {
            get { return _shortname; }
            set { _shortname = value; }
        }
    }
}
