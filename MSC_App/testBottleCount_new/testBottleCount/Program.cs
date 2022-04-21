using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testBottleCount
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BottleCountMain());
            LoginForm myLogin =new LoginForm();
            if (myLogin.ShowDialog() == DialogResult.OK)
            {
                //Open your main form here
                //MessageBox.Show("Logged in successfully!");
                Application.Run(new BottleCountMain());//如果登录成功则打开主窗体
            }
            else
            {
               
            }
        }
    }
}
