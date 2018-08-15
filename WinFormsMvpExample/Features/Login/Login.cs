using System;
using System.Windows.Forms;
using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample.Features.Login
{
    public partial class Login : WinFormView, ILoginView
    {
        public Login()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get => userTextBox.Text;
            set => userTextBox.Text = value;
        }
        public string Password
        {
            get => passwordTextBox.Text;
            set => passwordTextBox.Text = value;
        }

        public event EventHandler SignInPressed
        {
            add => signinButton.Click += value;
            remove => signinButton.Click -= value;
        }

        public event EventHandler ExitPressed
        {
            add => exitButton.Click += value;
            remove => exitButton.Click -= value;
        }

        public void CloseApplication() => Application.Exit();
    }
}
