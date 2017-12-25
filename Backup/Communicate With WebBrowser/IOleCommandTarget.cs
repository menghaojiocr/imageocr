using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Communicate_With_WebBrowser
{
    // 如何： 从 Visual C#.net web 浏览器控件的调用查找、 
    // 查看源文件和选项对话框:http://support.microsoft.com/?kbid=329014

    [ComImport,
    Guid("b722bccb-4e68-101b-a2bc-00aa00404770"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleCommandTarget
    {
        //IMPORTANT: The order of the methods is critical here. You
        //perform early binding in most cases, so the order of the methods
        //here MUST match the order of their vtable layout (which is determined
        //by their layout in IDL). The interop calls key off the vtable ordering,
        //not the symbolic names. Therefore, if you 
        //switched these method declarations
        //and tried to call the Exec method 
        //on an IOleCommandTarget interface from your
        //application, it would translate 
        //into a call to the QueryStatus method instead.
        void QueryStatus(
            ref Guid pguidCmdGroup,
            UInt32 cCmds,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] 
            OLECMD[] prgCmds, ref OLECMDTEXT CmdText
            );

        void Exec(
            ref Guid pguidCmdGroup,
            uint nCmdId,
            uint nCmdExecOpt,
            ref object pvaIn,
            ref object pvaOut
            );
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct OLECMDTEXT
    {
        public uint cmdtextf;
        public uint cwActual;
        public uint cwBuf;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public char rgwz;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OLECMD
    {
        public uint cmdID;
        public uint cmdf;
    }

    public enum OLECMDEXECOPT
    {
        OLECMDEXECOPT_DODEFAULT = 0,
        OLECMDEXECOPT_PROMPTUSER = 1,
        OLECMDEXECOPT_DONTPROMPTUSER = 2,
        OLECMDEXECOPT_SHOWHELP = 3
    }
}
