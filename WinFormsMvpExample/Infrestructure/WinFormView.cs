using System.Windows.Forms;

namespace WinFormsMvpExample.Infrestructure
{
    public class WinFormView : Form, IView
    {
        public IView ParentView
        {
            get => MdiParent as IView;
            set => MdiParent = value as Form;
        }
    }
}
