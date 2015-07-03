using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.EquipmentInfo
{
    public class Sys_EquipmentInfo
    {
        #region ˽�б���
        private DateTime _EquipmentBuyTime, _EquipmentUseTime;
        private bool _IsWarranty, _IsUsed, _Isexist;
        private string _EquipmentCode, _Modelcode, _Specifications, _Functions, _SuppliersCode, _Position, _Effect, _EquipmentLevel;
        #endregion

        #region ��������
        /// <summary>
        /// �豸���
        /// </summary>
        public string EquipmentCode { get { return _EquipmentCode; } set { _EquipmentCode = value; } }
        /// <summary>
        /// �ͺű���
        /// </summary>
        public string Modelcode { get { return _Modelcode; } set { _Modelcode = value; } }
        /// <summary>
        /// ���
        /// </summary>
        public string Specifications { get { return _Specifications; } set { _Specifications = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Functions { get { return _Functions; } set { _Functions = value; } }
        /// <summary>
        /// ��Ӧ�̱��
        /// </summary>
        public string SuppliersCode { get { return _SuppliersCode; } set { _SuppliersCode = value; } }
        /// <summary>
        /// λ��
        /// </summary>
        public string Position { get { return _Position; } set { _Position = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Effect { get { return _Effect; } set { _Effect = value; } }
        /// <summary>
        /// �Ƿ��ʱ���
        /// </summary>
        public bool IsWarranty { get { return _IsWarranty; } set { _IsWarrantyt = value; } }
        /// <summary>
        /// �Ƿ�����ʹ��
        /// </summary>
        public bool IsUsed { get { return _IsUsed; } set { _IsUsed = value; } }
        /// <summary>
        /// �Ƿ����豸
        /// </summary>
        public bool Isexist { get { return _Isexist; } set { _Isexist = value; } }
        /// <summary>
        /// �豸����ʱ��
        /// </summary>
        public DateTime EquipmentBuyTime { get { return _EquipmentBuyTime; } set { _EquipmentBuyTime = value; } }
        /// <summary>
        /// �豸����ʱ��
        /// </summary>
        public DateTime EquipmentUseTime { get { return _EquipmentUseTime; } set { _EquipmentUseTime = value; } }
        /// <summary>
        /// �豸��Ҫ�ȼ�
        /// </summary>
        public string EquipmentLevel { get { return _EquipmentLevel; } set { _EquipmentLevel = value; } }
        #endregion
    }
}
