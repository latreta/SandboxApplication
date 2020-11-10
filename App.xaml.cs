using Prism.Unity.Windows;
using SandboxApplication.Utils;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SandboxApplication
{
    sealed partial class App : PrismUnityApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(PageTokens.MAIN_PAGE, null);
            return Task.CompletedTask;
        }

        protected override UIElement CreateShell(Frame rootFrame)
        {
            var shell = new AppShell();
            shell.SetFrame(rootFrame);
            return shell;
        }

        protected override void ConfigureContainer()
        {
            // Configurar services e singletons da aplicação aqui
            base.ConfigureContainer();
        }
    }
}
