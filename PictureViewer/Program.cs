using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace PictureViewer {
    static class Program {

        [STAThread]
        static void Main(String[] args) {
            //TODO: Debug
            //if(checkRegistry()) {
            //    addRegistry();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0) {
                Application.Run(new Form1());
            } else {
                Application.Run(new Form1(args[0]));
            }
        }

        public static bool checkRegistry() {
            return Registry.CurrentUser.OpenSubKey("Software\\Classes\\Applications\\PictureViewer.exe") == null;
        }

        public static void addRegistry() {
            RegistryKey appReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\PictureViewer.exe");
            appReg.CreateSubKey("shell\\open\\command").SetValue("", "\"" + Application.ExecutablePath + "\" \"%1\"");
            appReg.CreateSubKey("shell\\edit\\command").SetValue("", "\"" + Application.ExecutablePath + "\" \"%1\"");
            appReg.CreateSubKey("DefaultIcon").SetValue("", "C:\\Program Files\\Picture Viewer\\resource\\icon.ico");

            Registry.CurrentUser.OpenSubKey("Software\\Classes\\.jpg\\DefaultIcon", true).SetValue("", "C:\\Program Files\\Picture Viewer\\resource\\icon.ico");
            Registry.CurrentUser.OpenSubKey("Software\\Classes\\.bmp\\DefaultIcon", true).SetValue("", "C:\\Program Files\\Picture Viewer\\resource\\icon.ico");
            Registry.CurrentUser.OpenSubKey("Software\\Classes\\.png\\DefaultIcon", true).SetValue("", "C:\\Program Files\\Picture Viewer\\resource\\icon.ico");
        }
    }
}
