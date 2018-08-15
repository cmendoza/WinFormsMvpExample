using System.Windows.Forms;

namespace WinFormsMvpExample.Infrestructure
{
    public interface IView
    {
        void Show();
        void Close();
        DialogResult ShowDialog();

        IView ParentView { get; set; }
    }
}
