using System;
using System.Windows.Forms;
using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample
{
    public partial class Main : WinFormView, IMainView
    {
        public Main()
        {
            InitializeComponent();
        }

        public event EventHandler OnLoaded
        {
            add => Load += value;
            remove => Load -= value;
        }
    }
}
