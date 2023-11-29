using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace 坐不住
{
    //键盘锁定
    class KeyBlocker
    {
        
        //private static Logger<KeyboardBlocker> log = new Logger<KeyboardBlocker>();
        private const int SE_PRIVILEGE_ENABLED = 0x00000002;
        private const int TOKEN_QUERY = 0x00000008;
        private const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        private const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr; 
        }

        /// <summary>
        /// 是否是管理员权限
        /// </summary>
        /// <returns></returns>
        public static bool IsAdmin()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        // 该函数声明了在advapi32.dll中实现的函数的原型
        [DllImport("user32.dll")]
        static extern void BlockInput(bool Block);

       
        public static bool off()
        {
            if (IsAdmin())
            {
                BlockInput(true);//锁定鼠标及键盘
                return true;
            }
            else
                return false;
        }
        
        public static bool on()
        {
            if (IsAdmin())
            {
                BlockInput(false);//解除键盘鼠标锁定
                return true;
            }
            else
                return false;
        }
        
        
    }
}
