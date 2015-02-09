using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace Helper
{
    static class Program
    {
        public static readonly ApplicationContext Context = new ApplicationContext();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var applicationController = new ApplicationController();
            applicationController.RegisterView<IMainView, MainForm>().
                RegisterView<INewActionView, NewActionForm>();

            DependencyFactory.Container.RegisterInstance(Context);

            applicationController.Run<MainPresenter>();
        }
    }
}
