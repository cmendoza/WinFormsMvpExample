using System;
using System.Windows.Forms;
using Unity;
using WinFormsMvpExample.Features.Login;
using WinFormsMvpExample.Features.Main;

namespace WinFormsMvpExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var container = new UnityContainer();

            container
                .RegisterType<IMainView, Main>()
                .RegisterType<ILoginView, Login>();

            Navigation.NavigationService.Navigator = new Navigation.WinFormsNavigator(container);

            var presenter = container.Resolve<MainPresenter>();

            Application.Run(presenter.View as Form);
        }
    }
}
