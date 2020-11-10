using Windows.UI.Xaml.Controls;

namespace SandboxApplication {
    public sealed partial class AppShell : UserControl
    {
        public AppShell()
        {
            this.InitializeComponent();
        }
        public void SetFrame(Frame frame)
        {
            ContentFrame.Content = frame;
        }
    }
}
