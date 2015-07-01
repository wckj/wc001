using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using WSV;


namespace WSV.Model.Weight
{
    public class WeightModel
    {
        #region ˽�б���
        private long _ID;
        private string _Code = "";
        private TxtModel _Txt=new TxtModel();
        private NumModel _Float=new NumModel();
        private StateModel _StateFun = new StateModel();
       // private static long Add;
        #endregion
        #region ���б���
        public long ID { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// ���
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// �ֶ���
        /// </summary>
        public TxtModel Txt { get { return _Txt; } set { _Txt = value; } }
        /// <summary>
        /// ��ֵ��
        /// </summary>
        public NumModel Float { get { return _Float; } set { _Float = value; } }
        /// <summary>
        /// ״̬
        /// </summary>
        public StateModel StateFun { get { return _StateFun; } set { _StateFun = value; } }
        #endregion
      
      
    }
}
