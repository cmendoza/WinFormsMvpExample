using Unity;
using WinFormsMvpExample.Infrestructure;

namespace WinFormsMvpExample.Navigation
{
    public class WinFormsNavigator : BaseNavigator
    {
        private readonly IUnityContainer _container;

        public WinFormsNavigator(IUnityContainer container)
        {
            _container = container;
        }

        public override void Show<TPresenter, TView>()
        {
            var presenter = _container.Resolve<TPresenter>();
            presenter.View.Show();
        }

        public override void ShowAsChild<TPresenter, TView>(IView parent)
        {
            var presenter = _container.Resolve<TPresenter>();
            presenter.View.ParentView = parent;
            presenter.View.Show();
        }

        public override void ShowModal<TPresenter, TView>()
        {
            var presenter = _container.Resolve<TPresenter>();
            presenter.View.ShowDialog();
        }
    }
}
