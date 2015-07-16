using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Xml;
using DataRabbit.DBAccessing;

namespace LEDSHOW
{
    class OrderFormConfig
    {
        private string _XMLFilePath = @"C:\Users\Z\Desktop\天水分拣车间LED2\天水分拣车间LED\LEDSHOW[原始版本]\LEDSHOW\bin\Debug\OrderFormConfig.xml";

        public string XMLFilePath
        {
            get { return _XMLFilePath; }
            set { _XMLFilePath = value; }
        }
        public OrderFormConfig()
        {
        }
        public OrderFormConfig(string path)
        {
            _XMLFilePath = path;
        }
        public string getTop()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("Top").Item(0).InnerText;
        }
        public string getLeft()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("Left").Item(0).InnerText;
        }
        public string getLeftOffset()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("LeftOffset").Item(0).InnerText;
        }
        public string getHeight()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("Height").Item(0).InnerText;
        }
        public string getWidth()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("Width").Item(0).InnerText;
        }
        public string getTimerInterval()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("TimerInterval").Item(0).InnerText;
        }
        public string getTimerIntervalVoice()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("TimerIntervalVoice").Item(0).InnerText;
        }
        public bool getIsSendToasynChronousScreen()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return Convert.ToBoolean(Convert.ToInt32(doc.GetElementsByTagName("IsSendToasynChronousScreen").Item(0).InnerText));
        }
        public string[] getLedAddressList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_XMLFilePath);
            return doc.GetElementsByTagName("LedAddressList").Item(0).InnerText.Split(","[0]);
        }
    }
}
