using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Count
{
    public class D_StatProjectModel
    {
        #region ˽�б���
        private long _ID = 0;
        private string _Code, _Name, _Type, _SataType, _Flag, _Month, _Day,_BeginTime, _EndTime;
        #endregion

        #region ��������
        /// <summary>
        /// ID
        /// </summary>
        public long ID { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// ���
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// ��������
        /// </summary>
        public string SataType { get { return _SataType; } set { _SataType = value; } }
        /// <summary>
        /// ��ʼ����
        /// </summary>
        public string Flag { get { return _Flag; } set { _Flag = value; } }
        /// </summary>
        /// ��ʼ�·�
        /// </summary>
        public string Month { get { return _Month; } set { _Month = value; } }
        /// </summary>
        /// ��ʼ����
        /// </summary>
        public string Day { get { return _Day; } set { _Day = value; } }
        /// </summary>
        /// ��ʼʱ��
        /// </summary>
        public string BeginTime { get { return _BeginTime; } set { _BeginTime = value; } }
        /// </summary>
        /// ����ʱ��
        /// </summary>
        public string EndTime { get { return _EndTime; } set { _EndTime = value; } }
        #endregion
    }
}
