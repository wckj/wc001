using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WSV.BLL.Weight
{
    public partial class VideoInfo
    {
        #region ���ò���
        /// <summary>
        /// ���ò���
        /// </summary>
        /// <param name="phParentWnd"></param>
        /// <param name="eDispTransType"></param>
        /// <param name="bInitAudDev"></param>
        /// <returns></returns>
        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAInitSdk", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAInitSdk(IntPtr phParentWnd, int eDispTransType, bool bInitAudDev);  //��ʼ��ϵͳ��Դ

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAUnInitSdk", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern void VCStream_VCAUnInitSdk(); //�ͷ�ϵͳ��Դ.

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAGetDevNum", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern Int32 VCStream_VCAGetDevNum();    //����ϵͳ���п�������

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAOpenDevice", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAOpenDevice(int iCard, IntPtr phPreviewWnd);     //��ָ�����ŵ��豸��������Ӧϵͳ��Դ

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCACloseDevice", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCACloseDevice(int iCard);    //�ر�ָ�����ŵ��豸���ͷ���Ӧϵͳ��Դ

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStartVideoPreview", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStartVideoPreview(int iCard);     //��ʼ��ƵԤ��.

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStopVideoPreview", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStopVideoPreview(int iCard); //ֹͣ��ƵԤ��.

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAUpdateVideoPreview", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAUpdateVideoPreview(int iCard, IntPtr phPreviewWnd);  //������ƵԤ����

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAUpdateOverlayWnd", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAUpdateOverlayWnd(IntPtr phPreviewWnd);   //��overlay���ھ���ı��ߴ硢λ�øı�ʱ����

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASaveBitsToBuf", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASaveBitsToBuf(int iCard, byte[] fb, out int Width, out int Height);   //����������ݵ���Ӧ�Ļ�����

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASaveAsJpegFile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASaveAsJpegFile(int iCard, String szFileName, int iQuality);  //�������ΪJPEG�ļ�

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAInitVidDev", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAInitVidDev(int iCard);     //��ʼ����Ƶ�豸������Ƶ����ʾ��ֻ����Ƶ¼�����Ƶ����ʱ����ͨ��VCAInitSdk()�����Ѿ���ʼ����ɿ��Բ���ʼ��

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidDeviceColor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidDeviceColor(int iCard, int EnCtlType, int DwValue);  //������Ƶ��ɫ����,����Ӱ����ƵԤ������Ƶ�������ʾ����

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAGetVidFieldFrq", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAGetVidFieldFrq(int iCard, out int eVidSourceFieldRate);  //�õ���ƵԴ����Ƶ�ʣ����ɵõ���ƵԴ������ʽ

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidFieldFrq", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidFieldFrq(int iCard, int eVidSourceFieldRate);  //������ƵԴ����Ƶ��( 0HZ / 50HZ / 60HZ )��Ӧ( ���ź� / PAL�� / NTSC�� )

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidCapDateTimeOSD", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidCapDateTimeOSD(int iCard, bool bEnableOSD, POINT ptTopLeft, bool bTransparent);

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidCapDateTimeOSDParam", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidCapDateTimeOSDParam(OSDPARAM pOSDParm);

        //��׽��Ƶ
        /// <summary>
        /// ��׽��Ƶ
        /// </summary>
        /// <param name="iCard">����</param>
        /// <param name="enCapMode">��ʾѡ������׽ģʽ��=0��ʾ��׽��Ч��=1��ʾԭʼ���ص���=2��ʾMpeg4����=3��ʾXVID����������=4��ʾWMV9��������5��6��7������2��3��6</param>
        /// <param name="enMp4Mode">��ʾMPEGѹ��ģʽ��ֻ�������CAP_MPEG4_STREAMʱenMp4Mode����Ч,=0��ʾ��ΪMPEG�ļ���=1MPEG���ݻص���=2��ΪMPEG�ļ����ص�.</param>
        /// <param name="lpFileName">�ļ�·��</param>
        /// <returns></returns>
        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStartVideoCapture", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStartVideoCapture(int iCard, int enCapMode, int enMp4Mode, string lpFileName);  
         
        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStopVideoCapture", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStopVideoCapture(int iCard);  //ֹͣ��Ƶ

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidCapDateTimeOSDParam", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidCapDateTimeOSDParam(int iCard);  //������Ƶʱ�䡢���ڵ��Ӳ���.


        #endregion

        public struct OSDPARAM
        {
            public long cfHeight; //�ַ��߶�
            public long cfWidth; //�ַ����
            public long cfWeight; //�ַ���ϸ
            public long cfSpacing; //�ַ����
            public bool cfItalic; //б��
            public bool cfUnderline; //�»���
            public bool cfStrikeOut; //ɾ����
            public bool bTransparent; //͸��
            public Color cfBkColor; //����ɫ 
            public Color cfTextColor; //ǰ��ɫ
            //public string cfFaceName; //������
            //public byte[] cfFaceName;//{"����"}; //������
            public char[] cfFaceName;
        }
        public struct POINT
        {
            public int cx;
            public int cy;
        }
    }
}
