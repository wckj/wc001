using System;
using System.Collections.Generic;
using System.Text;


namespace WSV.Model.Weight
{
    public class NumModel
    {
        #region ˽�б���
        private decimal _Gross = 0, _Tare = 0, _Net = 0, _ImpurityRate = 0;
        private decimal _DeductRate = 0, _Cube = 0, _InhereWei = 0, _DifferWei = 0, _Price = 0;
        private decimal _Money = 0, _Cubety = 0;
        private decimal _Impurity = 0, _EndNet = 0, _DeductWei = 0;
        #endregion

        #region ���б���

        /// <summary>
        /// ë��
        /// </summary>
        public decimal Gross { get { return _Gross; } set { _Gross = value; } }
        /// <summary>
        /// Ƥ��
        /// </summary>
        public decimal Tare { get { return _Tare; } set { _Tare = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public decimal Net { get { return _Net; } set { _Net = value; } }
        /// <summary>
        /// ���㾻��
        /// </summary>
        public decimal EndNet { get { return _EndNet; } set { _EndNet = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public decimal Impurity { get { return _Impurity; } set { _Impurity = value; } }
        /// <summary>
        /// ������
        /// </summary>
        public decimal ImpurityRate { get { return _ImpurityRate; } set { _ImpurityRate = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public decimal DeductWei { get { return _DeductWei; } set { _DeductWei = value; } }
        /// <summary>
        /// ������
        /// </summary>
        public decimal DeductRate { get { return _DeductRate; } set { _DeductRate = value; } }
        /// <summary>
        /// �۷�
        /// </summary>
        public decimal Cube { get { return _Cube; } set { _Cube = value; } }
        /// <summary>
        /// ԭ����
        /// </summary>
        public decimal InhereWei { get { return _InhereWei; } set { _InhereWei = value; } }
        /// <summary>
        /// ���
        /// </summary>
        public decimal DifferWei { get { return _DifferWei; } set { _DifferWei = value; } }
        /// <summary>
        /// ����
        /// </summary>
        public decimal Price { get { return _Price; } set { _Price = value; } }
        /// <summary>
        /// ���
        /// </summary>
        public decimal Money { get { return _Money; } set { _Money = value; } }
        /// <summary>
        /// �۷���
        /// </summary>
        public decimal Cubety { get { return _Cubety; } set { _Cubety = value; } }
        #endregion

        #region ����
        public decimal NetFun()
        {
            return Net = Gross - Tare;
        }
        #endregion

        #region ��������
        public decimal NetFun(decimal gross, decimal tare)
        {
            Gross = gross;
            Tare = tare;
            return Net = Gross - Tare;
        }
        #endregion

        #region ���㾻��
        public void EndNetFun(int Pro)
        {
            switch (Pro)
            {
                case 0:
                    _EndNet = Net - DeductWei - Impurity;
                    break;
                case 1:
                    _EndNet = Net - DeductWei;
                    break;
                case 2:
                    _EndNet = Net;
                    break;
            }
        }
        #endregion

        #region ���
        public void MoneyFun(int Pro)
        {
            switch (Pro)
            {
                case 0:
                    Money = Net * Price;
                    break;
                case 1:
                    Money = EndNet * Price;
                    break;
                case 2:
                    Money = Cube * Price;
                    break;
            }
        }
        #endregion

        #region ���أ�����
        public decimal Wei(decimal Net, decimal Rate)
        {
            decimal Wei = Net * Rate / 100;
            return Wei;
        }
        #endregion

        #region ���ʣ�������
        public decimal Rate(decimal Net, decimal Wei)
        {
            if (Net != 0)
            {
                decimal Rate = Wei / Net * 100;
                return Convert.ToDecimal(Math.Round(Rate, 10, MidpointRounding.AwayFromZero));
            }
            else
            {
                return 0;
            }

        }
        #endregion
        #region С��λ����ȡ����ʽ�ط���
        /// <summary>
        /// С��λ����ȡ����ʽ�ط���
        /// </summary>
        /// <param name="Num">��Ҫת������ֵ</param>
        /// <param name="Digit">Ҫ������С��λ��</param>
        /// <param name="Round">����С���ķ�ʽ</param>
        /// <returns></returns>
        public decimal NumDig(decimal Num, int Digit, int Round)
        {
            long a = 1;
            for (int i = 1; i <= Digit; i++)
            {
                a = a * 10;
            }
            try
            {
                if (Round == 0)
                {
                    return Convert.ToDecimal(Math.Round(Num, Digit, MidpointRounding.AwayFromZero));
                }
                else
                {
                    Num = Num * a;
                    decimal c = Math.Truncate(Num);
                    return c / a;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion
    }
}
