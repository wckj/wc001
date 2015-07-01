using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Weight
{
    public class TxtModel
    {
        #region ˽�б���
        private string _CarCode = "", _Item = "", _Specs = "", _Place = "", _Send = "", _Accept = "", _IdCard = "";
        private string _Carry = "", _Model = "", _Driver = "", _Spare = "", _Type = "", _Card = "", _Name = "", _Plan_Code = "";
        #endregion

        #region ���б���
        /// <summary>
        /// ����
        /// </summary>
        public string CarCode { get { return _CarCode; } set { _CarCode = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Item { get { return _Item; } set { _Item = value; } }
        /// <summary>
        /// ���
        /// </summary>
        public string Specs { get { return _Specs; } set { _Specs = value; } }
        /// <summary>
        /// ��λ
        /// </summary>
        public string Place { get { return _Place; } set { _Place = value; } }
        /// <summary>
        /// ������λ
        /// </summary>
        public string Send { get { return _Send; } set { _Send = value; } }
        /// <summary>
        /// �ջ���λ
        /// </summary>
        public string Accept { get { return _Accept; } set { _Accept = value; } }
        /// <summary>
        /// ���˵�λ
        /// </summary>
        public string Carry { get { return _Carry; } set { _Carry = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Model { get { return _Model; } set { _Model = value; } }
        /// <summary>
        /// ˾��
        /// </summary>
        public string Driver { get { return _Driver; } set { _Driver = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Spare { get { return _Spare; } set { _Spare = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Card { get { return _Card; } set { _Card = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// ������
        /// </summary>
        public string IdCard { get { return _IdCard; } set { _IdCard = value; } }
        /// <summary>
        /// �ƻ����
        /// </summary>
        public string Plan_Code { get { return _Plan_Code; } set { _Plan_Code = value; } }
        #endregion
    }
}
