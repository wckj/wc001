using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Count
{
    public class D_StatProjectItemModel
    {
        #region ˽�б���
        private string _Code, _StatCode, _OldStatCode;
        private int _Place;
        #endregion

        #region ��������
        /// <summary>
        /// ���������
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// �����ֶ�
        /// </summary>
        public string StatCode { get { return _StatCode; } set { _StatCode = value; } }
        /// <summary>
        ///��ʾλ��
        /// </summary>
        public int Place { get { return _Place; } set { _Place = value; } }
        /// <summary>
        /// ��Ҫ�޸ĵĻ����ֶ�
        /// </summary>
        public string OldStatCode { get { return _OldStatCode; } set { _OldStatCode = value; } }
        #endregion
    }
}
