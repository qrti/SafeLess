using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SafeLess
{
    public class HookHelper
    {
        public delegate IntPtr HookDelegate(Int32 Code, Int32 wParam, ref keyboardHookStruct lParam);

        [DllImport("User32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hHook, Int32 nCode, Int32 wParam, ref keyboardHookStruct lParam);

        [DllImport("User32.dll")]
        public static extern IntPtr UnhookWindowsHookEx(IntPtr hHook);

        [DllImport("User32.dll")]
        public static extern IntPtr SetWindowsHookEx(Int32 idHook, HookDelegate lpfn, IntPtr hmod, Int32 dwThreadId);

        [DllImport("User32.dll")]
        public static extern Int16 GetAsyncKeyState(Int32 vKey);

 		public struct keyboardHookStruct{
			public Int32 vkCode;
			public Int32 scanCode;
			public Int32 flags;
			public Int32 time;
			public Int32 dwExtraInfo;
		}
    }

    class KeyboardInput : IDisposable
    {
        public event EventHandler<KeyEventArgs> KeyBoardKeyPressed;

        private HookHelper.HookDelegate keyBoardDelegate;
        private IntPtr keyBoardHandle;

        private const Int32 WH_KEYBOARD_LL = 0x0d;

		private const Int32 WM_KEYDOWN     = 0x100;
		private const Int32 WM_KEYUP       = 0x101;
		private const Int32 WM_SYSKEYDOWN  = 0x104;
		private const Int32 WM_SYSKEYUP    = 0x105;
        
        private const Int32 VK_TAB         = 0x09;          // virtual keys
        private const Int32 VK_CONTROL     = 0x11;
        private const Int32 VK_ESCAPE      = 0x1B;
        private const Int32 VK_DELETE      = 0x2E;

        private bool disposed;

        public KeyboardInput()
        {
            keyBoardDelegate = KeyboardHookDelegate;
            keyBoardHandle = HookHelper.SetWindowsHookEx(WH_KEYBOARD_LL, keyBoardDelegate, IntPtr.Zero, 0);
        }

        private IntPtr KeyboardHookDelegate(Int32 nCode, Int32 wParam, ref HookHelper.keyboardHookStruct lParam)
        {
            if(KeyBoardKeyPressed!=null && nCode==0 && (HookHelper.GetAsyncKeyState(VK_CONTROL) & 0x8000)!=0){
                Keys key = (Keys)lParam.vkCode;
				KeyEventArgs keyEventArgs = new KeyEventArgs(key);
                keyEventArgs.Handled = (wParam == WM_KEYUP);            // used as keyAction flag
                KeyBoardKeyPressed(this, keyEventArgs);

                if(keyEventArgs.Handled)                                // is handled flag again
                    return (IntPtr)1;
            }

            return HookHelper.CallNextHookEx(keyBoardHandle, nCode, wParam, ref lParam);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!disposed){
                if (keyBoardHandle != IntPtr.Zero)
                    HookHelper.UnhookWindowsHookEx(keyBoardHandle);

                disposed = true;
            }
        }

        ~KeyboardInput()
        {
            Dispose(false);
        }
    }
}

//no abuse of KeyEventArgs.Handled 
//
//public class MyKeyEventArgs : KeyEventArgs
//{
//    public MyKeyEventArgs(Keys keys, Int32 action) : base(keys)
//    {
//        this.KeyAction = action;
//    }
//
//    public Int32 KeyAction
//    {
//        get;
//        set;
//    }
//}