using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Communicate_With_WebBrowser
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //设置浏览器扩展，主要是允许信息栏和弹出窗口
            SetFeature(FEATURE_SECURITYBAND, true);
            SetFeature(FEATURE_WEBOC_POPUPMANAGEMENT, true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FDemo());


        }

        #region 设置浏览器扩展

        // 参考
        // ms-help://MS.MSDNQTR.v90.chs/iesecurity/workshop/security/szone/reference/functions/cointernetsetfeatureenabled.htm
        // ms-help://MS.MSDNQTR.v90.chs/iesecurity/workshop/security/szone/reference/enums/internetfeaturelist.htm
        // http://blog.csdn.net/jiangsheng/archive/2004/11/07/170742.aspx

        private static void SetFeature(int FeatureEntry,bool fEnable)
        {
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_ON_THREAD, fEnable);
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_ON_PROCESS, fEnable);
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_IN_REGISTRY, fEnable);
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_ON_THREAD_LOCALMACHINE, fEnable);
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_ON_THREAD_INTRANET, fEnable);
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_ON_THREAD_TRUSTED, fEnable);
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_ON_THREAD_INTERNET, fEnable);
            CoInternetSetFeatureEnabled(FeatureEntry, SET_FEATURE_ON_THREAD_RESTRICTED, fEnable);
        }

        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        public static extern int CoInternetSetFeatureEnabled(
            int FeatureEntry,
            [MarshalAs(UnmanagedType.U4)]
            int dwFlags,
            bool fEnable);

        private const int FEATURE_WEBOC_POPUPMANAGEMENT = 5;
        private const int FEATURE_SECURITYBAND = 9;

        private const int SET_FEATURE_ON_THREAD = 0x00000001;
        private const int SET_FEATURE_ON_PROCESS = 0x00000002;
        private const int SET_FEATURE_IN_REGISTRY = 0x00000004;
        private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;
        private const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;
        private const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;
        private const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;
        private const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;
        #endregion
    }
}
