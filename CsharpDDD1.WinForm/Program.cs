using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsharpDDD1.ApplicationService.Services;
using CsharpDDD1.WinForm.Views;

namespace CsharpDDD1.WinForm
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.ThreadException += Application_ThreadException;

            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new BookListView(new BookApplicationService()));
        }

        
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {            
            //メッセージ表示
            MessageBox.Show(e.Exception.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
