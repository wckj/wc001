using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Search
{
    public class D_SelectProjectModel
    {
        #region ˽�б���
        private long _ID = 0;
        private string  _Code,_Name, _Type, _State,_Used;
        private bool _Verify;
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
        /// ��������
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// ���ݿ�
        /// </summary>
        public string State { get { return _State; } set { _State = value; } }
        /// <summary>
        /// ״̬
        /// </summary>
        public string Used { get { return _Used ; } set {_Used  = value; } }
        /// <summary>
        ///���
        /// </summary>
        public bool Verify  { get { return _Verify ; } set { _Verify =true ; } }
        #endregion
    }
}
